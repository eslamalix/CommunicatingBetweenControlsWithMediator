using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        //Singleton functionality
        private static readonly Mediator Instance = new Mediator();
        

        public static Mediator GetInstance()
        {
            return Instance;
        }

        //Instance functionality
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(Object sender, Job job)
        {
            var jobChangeDelegate = JobChanged;
            jobChangeDelegate?.Invoke(sender, new JobChangedEventArgs { Job = job });
        }

    }
}
