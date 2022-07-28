using LiteDB;
using System;

namespace Andon.Entity
{
    public class MyDbContext : IDisposable
    {
        public ILiteCollection<MachineState> MachineCollection { get; set; }
        private ILiteDatabase _db;
        public MyDbContext()
        {
            _db = new LiteDatabase(@"Andon.db");


            MachineCollection = _db.GetCollection<MachineState>("Machines");


        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
