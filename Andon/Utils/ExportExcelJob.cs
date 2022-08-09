
using Andon.Entity;
using Andon.UI;
using Quartz;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andon.Utils
{
    public class ExportExcelJob : IJob
    {
        private MachineState[] _machineStates = Data.machineStates();


        Task IJob.Execute(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now + "-----exportexcel");
            ExportData();
            return Task.CompletedTask;
            //throw new System.NotImplementedException();
        }
        //private void ExportData()
        //{

        //    StringBuilder csv = new StringBuilder("");

        //    csv.Append("Name Mchine,Running Time\r\n");

        //    for (int i = 0; i < 4; i++)
        //    {
        //        csv.Append("=\"" + i.ToString() + "\",\"" + j.ToString() + "\"\r\n");
        //    }
        //    string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
        //    string folderName = "Running Time/" + timestamp;

        //    if (!Directory.Exists(folderName))
        //    {
        //        Directory.CreateDirectory(folderName);
        //    }

        //    File.WriteAllText(folderName + "/RunningTime_" + timestamp + ".csv", csv.ToString());

        //}
        private void ExportData()
        {
            using (var db = new MyDbContext())
            {
                // lay data downtime
                //var listDownDetails = db.MachineCollection.Find(x => x.FlagDown).ToList();
                //
                var listDownDetails = db.MachineCollection.Find(x => x.Date.Date == DateTime.Now.Date).ToList();
                //var listDowntime = listDownDetails.GroupBy(x => x.Id).Select(g => new
                //{
                //    g.FirstOrDefault().Date,
                //    Id = g.Key,
                //    g.FirstOrDefault().Address,
                //    Downtime = g.Sum(x => x.Downtime),
                //    Counter = g.ToList().Count
                //}).ToList();

                if (listDownDetails.Count > 0)
                {
                    Console.WriteLine(DateTime.Now + "-----exportexcel has data");
                    //string csv = string.Empty;
                    StringBuilder csv = new StringBuilder("");
                    StringBuilder csv1 = new StringBuilder("");
                    // export data downtime
                    //        DataTable dt = new DataTable();
                    //        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Date", typeof(string)),
                    //new DataColumn("Machine", typeof(string)),
                    //new DataColumn("Downtime",typeof(int)),
                    //new DataColumn("Counter",typeof(int)),
                    //new DataColumn("Address PLC",typeof(string))});
                    csv.Append("Date,Time,Machine,Downtime,Address PLC\r\n");
                    csv1.Append("Name Mchine,Running Time\r\n");


                    foreach (var mc in listDownDetails)
                    {
                        //dt.Rows.Add(mc.Date.ToString("DD/mm/yyy") , mc.Id, mc.Downtime, mc.Downtime, mc.Address);
                        //csv += "="+mc.Date.ToString("dd/MM/yyyy")+",=" + mc.Date.ToString("HH:mm:ss") + "," + mc.Name + "," + mc.Downtime + "," + mc.Address +"\r\n";
                        csv.Append("=\"" + mc.Date.ToString("yyyy/MM/dd") + "\",\"" + mc.Date.ToString("HH:mm:ss") + "\",\"" + mc.Name + "\",\"" + mc.Downtime + "\",\"" + mc.Address + "\"\r\n");
                    }
                    for (int i = 0; i < 22; i++)
                    {
                        csv1.Append("=\"" + (_machineStates[i].Name).ToString() + "\",\"" + HomeSlide.ValueTimeRun[i].ToString() + "\"\r\n");
                    }


                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                    string folderName = "DateExport/" + timestamp;

                    //string folderName1 = "RunningTime/" + timestamp;

                    if (!Directory.Exists(folderName))
                    {
                        Directory.CreateDirectory(folderName);
                        //Directory.CreateDirectory(folderName1);
                    }

                    File.WriteAllText(folderName + "/DowntimeDetails_" + timestamp + ".csv", csv.ToString());
                    File.WriteAllText(folderName + "/RunningTime_" + timestamp + ".csv", csv1.ToString());
                    
                }
                db.Dispose();
            }
        }
    }
}
