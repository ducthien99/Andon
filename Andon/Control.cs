using ActUtlTypeLib;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace Andon

{

    struct Control
    {
        
        public static ActUtlType plc = new ActUtlType();
        //public static bool IsConnect = false, IsMode = false, IsHorn, IsRecord;
        //public static int Statusconect, Statusmode, StatusHorn, StatusRecord;
        static bool isMax = false, isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;
        //public static bool IsHome = true, IsConnection = false, IsDisplay = false;
        public static void SetInitial(Form form)
        {

            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;

            isMax = false;
            isFull = false;

            //IsHome = true;
            //IsConnection = false;

            //IsDisplay = false;

            plc.ActLogicalStationNumber = 2;
            plc.Open();
            plc.Connect();
            // plc.SetDevice("M0", 0);
            //plc.SetDevice("M7", 0);
            //plc.SetDevice("M6", 0);

            //IsConnect = false;
            //IsMode = false;
            //AddFormBM();

        }

        //public static void ReadStatusConnect()
        //{
        //    plc.GetDevice("M0", out Statusconect);
        //    if (Statusconect == 1)
        //    {
        //        IsConnect = true;
        //    }
        //    else IsConnect = false;
        //}

        //public static void ReadStatusMode()
        //{
        //    plc.GetDevice("M100", out Statusmode);

        //    if (Statusmode == 0)
        //    {
        //        IsMode = false;
        //    }
        //    if (Statusmode == 1)
        //    {
        //        IsMode = true;
        //    }
        //    plc.GetDevice("M385", out StatusHorn);
        //    if (StatusHorn == 0)
        //    {
        //        IsHorn = false;
        //    }
        //    if (StatusHorn == 1)
        //    {
        //        IsHorn = true;
        //    }
        //    plc.GetDevice("M386", out StatusRecord);
        //    if (StatusRecord == 0)
        //    {
        //        IsRecord = false;
        //    }
        //    if (StatusRecord == 1)
        //    {
        //        IsRecord = true;
        //    }


        //}

        //control Screen//////
        public static void DoMaximed(Form form, Button Maxbtn)
        {
            if (isMax == false)//app not maximized then MAXIMIZED IT!
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximized(form);
                isMax = true;
                isFull = false;
                Maxbtn.Text = "2";
            }
            else//app currently maximized; then make it normal!
            {
                if (old_size.Width >= SystemInformation.WorkingArea.Width || old_size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = default_loc;
                    form.Size = default_size;
                }
                else
                {
                    form.Location = old_loc;
                    form.Size = old_size;
                }

                isMax = false;
                isFull = false;
                Maxbtn.Text = "1";

            }

        }
        public static void DoFullsreen(Form form)
        {
            if (isFull == false)//app not fullscreen; then maximized it!
            {
                old_loc = new Point(form.Location.X, form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                FullScreen(form);
                isMax = false;
                isFull = true;
            }
            else//app currently fullscreen; then make it normal!
            {
                if (old_size.Width >= SystemInformation.WorkingArea.Width || old_size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = default_loc;
                    form.Size = default_size;
                }
                else
                {
                    form.Location = old_loc;
                    form.Size = old_size;
                }
                FullScreen(form);
                isMax = false;
                isFull = false;

            }
        }
        static void FullScreen(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Maximized;
        }
        public static void Maximized(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);

        }
        public static void Minimized(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;

            //else if (form.WindowState == FormWindowState.Normal)
            //    form.WindowState = FormWindowState.Minimized;

        }
       
       
        //////////////////////////////////////////////////////

    }
}
