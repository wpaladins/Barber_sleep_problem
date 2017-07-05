using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber_sleep_problem
{
    public partial class Barber_sleep_problem : Form
    {
        Semaphore sema_sleep = new Semaphore(0, 1);
        Semaphore sema_chairs = new Semaphore(3, 3);
        Semaphore sema_barber = new Semaphore(1, 1);

        bool bool_sleep = true;
        bool no_created = true;
        int chairs = 3;

        public Barber_sleep_problem()
        {
            InitializeComponent();
        }

        private void Barber_sleep_problem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            chair_haircut.Image = Resource1.sleep;
            warning.Image = null;
        }

        private delegate void dele_customer();//delegate方法；
        private delegate void dele_barber();

        private static void by_customer()
        {
            return;
        }//被调用方法；
        private static void by_barber()
        {
            return;
        }

        private void customer_completed(IAsyncResult asyncResult)
        {
            if (bool_sleep)
            {
                sema_sleep.Release();
                return;
            }
            else if (chairs == 0)
            {
                warning.Image = Resource1.warning;
                Thread.Sleep(500);
                warning.Image = null;
                return;
            }
            else
            {
                sema_chairs.WaitOne();
                chairs--;
                wait();
                sema_barber.WaitOne();
                return;
            }
        }//customer线程的回调函数；
        private void barber_completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                if(chairs == 3)
                {
                    sleep();
                    bool_sleep = true;
                    sema_sleep.WaitOne();
                    bool_sleep = false;
                }
                else
                {
                    sema_chairs.Release();
                    chairs++;
                    sema_barber.Release();
                }
                haircut();
                adjust();
                Thread.Sleep(5000);
                chair_haircut.Image = Resource1.question;
                Thread.Sleep(1000);
            }

        }//barber线程的回调函数；

        private void button1_Click(object sender, EventArgs e)
        {
            if(no_created)
            {
                dele_barber barber = by_barber;
                IAsyncResult asyncResult0 = barber.BeginInvoke(barber_completed, barber);
                no_created = false;
                Thread.Sleep(50);
            }
            dele_customer customer = by_customer;
            IAsyncResult asyncResult1 = customer.BeginInvoke(customer_completed, customer);
        }

        //操作图形的函数们；
        private void wait()
        {
            if (chair1.Image == null)
                chair1.Image = Resource1.wait;
            else if (chair2.Image == null)
                chair2.Image = Resource1.wait;
            else
                chair3.Image = Resource1.wait;
        }
        private void sleep()
        {
            chair_haircut.Image = Resource1.sleep;
        }
        private void haircut()
        {
            chair_haircut.Image = Resource1.hair_cut;
            if (chair1.Image != null)
                chair1.Image = null;
            else if (chair2.Image != null)
                chair2.Image = null;
            else
                chair3.Image = null;
        }
        private void adjust()
        {
            if ((chair1.Image == null && chair2.Image != null && chair3.Image == null) || (chair1.Image == null && chair2.Image == null && chair3.Image != null))
            {
                chair1.Image = Resource1.wait;
                chair2.Image = null;
                chair3.Image = null;
            }
            else if (chair1.Image == null && chair2.Image != null && chair3.Image != null)
            {
                chair1.Image = Resource1.wait;
                chair2.Image = Resource1.wait;
                chair3.Image = null;
            }
        }
    }
}
