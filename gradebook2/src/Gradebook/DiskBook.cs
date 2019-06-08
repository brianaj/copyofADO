using System;
using System.IO;

namespace Gradebook
{
    public class DiskBook : Book
    {
        private string v;

        public DiskBook(string v): base(v)
        {
            this.v = v;
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
           using(var streamer = File.AppendText( $"/Users/brijohns/DotNetProjects/gradebook2/gradebook2/src/Gradebook/{Name}.txt"))
           {
               streamer.WriteLine(grade);
               if(GradeAdded != null)
               {
                   GradeAdded(this, new EventArgs());
               }
           }
           // using statement will invoke Close or Disponse in a finally block
        //    streamer.Close();
        }

        public override Statistics GetStats()
        {
            throw new System.NotImplementedException();
        }
    }
}