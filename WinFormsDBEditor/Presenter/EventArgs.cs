using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDBEditor.Presenter {
    public class EventArgs<T> {
        private readonly T _value;

        public EventArgs(T value) {
            _value = value;
        }

        public T value {
            get { return _value; }
        }
    }
}
