using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace ModeloTarea4.ViewModel
{
    class ViewModel : ViewModelBase
    {
        private Worker _worker;
        private ObservableCollection<Worker> _workers;
        private ICommand _SubmitCommand;

        public Worker Worker
        {
            get
            {
                return _worker;
            }
            set
            {
                _worker = value;
                NotifyProperyChanged("Worker");
            }
        }

        public ObservableCollection<Worker> Workers
        {
            get
            {
                return _workers;
            }
            set
            {
                _workers = value;
                NotifyProperyChanged("Workers");
            }
        }

        //public ICommand SubmitCommand
        //{
        //    get
        //    {
        //        if (_SubmitCommand == null)
        //        {
        //            _SubmitCommand = new RelayCommand(ParamArrayAttribute => this.SubmitCommand(), null);

        //        }
        //        return _SubmitCommand;
        //    }
        //}

        public ViewModel()
        {
            Worker = new Worker();
            Workers = new ObservableCollection<Worker>();
        }
        void Worker_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyProperyChanged("Workers");
        }
        private void Submit()
        {
            Workers.Add(Worker);
            Worker = new Worker();
        }
    }
}
