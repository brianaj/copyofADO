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
           var streamer = File.AppendText( $"/Users/brijohns/DotNetProjects/gradebook2/gradebook2/src/Gradebook/{Name}.txt");
           streamer.WriteLine(grade);
           streamer.Close();
        }

        public override Statistics GetStats()
        {
            throw new System.NotImplementedException();
        }
    }
}