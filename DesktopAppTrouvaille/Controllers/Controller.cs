using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views;
using System;
using System.Collections.Generic;



namespace DesktopAppTrouvaille.Controllers
{
    public enum SortingOrder { Ascending, Descending}

    public enum State { ConnectionError, OK, LoadData, SendingData, Saved, Deleted }

    // This Controller Class contains Functions which are used by all specific Controllers.
    public abstract class Controller : IController
    {
        // Interface for Updating the GUI:
        private List<IView> _views= new List<IView>();
        protected State _state;

        protected SortingOrder SortOrder;

        private IModel _selectedModel;

        public State state { get { return _state; } }

        // Iterator:
        protected Iterator _iterator = new Iterator();

        public abstract int GetCount();

        public abstract void UpdateData();

        public int GetCurrentPage()
        {
           return _iterator.CurrentPage + 1;
        }

        public void AttachView(IView view)
        {
            _views.Add(view);
        }

        public void DetachView(IView view)
        {
            _views.Remove(view);
        }

        protected void UpdateView()
        {
            foreach(IView v in _views)
            {
                v.UpdateView();
            }
        }

        public int GetPageCount()
        {
            return _iterator.Count / _iterator.StepSize;
        }

        public void Next()
        {
            _iterator.Next();
            UpdateData();
        }

        public void Previous()
        {
            _iterator.Previous();
            UpdateData();
        }

        public  void ItemSelected(IModel model)
        {
            _selectedModel = model;
        }
        public  IModel GetSelectedModel()
        {
            return _selectedModel;
        }

        public void Search(string searchText)
        {
            throw new NotImplementedException();
        }

        public abstract IEnumerable<IModel> GetModels();


        public void SetSortingOrder(SortingOrder order)
        {
            SortOrder = order;
        }

        public SortingOrder GetSortingOrder()
        {
            return SortOrder;
        }

        public abstract void SelectDetailModel(IModel model);
    }
}
