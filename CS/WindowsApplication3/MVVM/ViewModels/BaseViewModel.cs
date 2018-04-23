using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using DevExpress.Mvvm.POCO;

namespace MVVMSample {
    public class BaseViewModel<T>
            where T : class, new() {
        public BaseViewModel() {
            SupportNewEntities = true;
        }
        public virtual BindingList<T> Entities { get; set; }
        public virtual bool SupportNewEntities { get; set; }
        public void Add() {
            Entities.Add(new T());
        }
        public bool CanAdd() {
            return SupportNewEntities;
        }
        protected void OnSupportNewEntitiesChanged() {
            this.RaiseCanExecuteChanged(x => x.Add());
        }
        public void Clear() {
            Entities.Clear();
        }
        public void RemoveLast() {
            if (Entities.Count > 0) {
                Entities.RemoveAt(Entities.Count - 1);
            }
        }
    }
}
