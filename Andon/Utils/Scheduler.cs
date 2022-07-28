using Quartz;
using Quartz.Impl;

namespace Andon.Utils
{
    public class Scheduler
    {
        public async void Start()

        {

            StdSchedulerFactory factory = new StdSchedulerFactory();

            // get a scheduler
            IScheduler scheduler = await factory.GetScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<ExportExcelJob>()
               .WithIdentity("myJob", "group1")
               .Build();

            IJobDetail job2 = JobBuilder.Create<ExportExcelJob>()
                .WithIdentity("myJob1", "group1")
                .Build();
            // Trigger the job to run now, and then every 40 seconds
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(23, 59))
                .ForJob(job)
                .Build();

            ITrigger trigger2 = TriggerBuilder.Create()
                .WithIdentity("myTrigger1", "group1")
                .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(06, 30))


                .ForJob(job2)
                .Build();
            await scheduler.ScheduleJob(job, trigger);
            await scheduler.ScheduleJob(job2, trigger2);
        }

    }
}
