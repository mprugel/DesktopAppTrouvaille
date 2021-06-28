﻿using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views;
using System;
using System.Collections.Generic;



namespace DesktopAppTrouvaille.Controllers
{
    public enum State { ConnectionError, OK, LoadData, SendingData, Saved, Deleted, Updated, SaveFailed, UpdateFailed, DeleteFailed, LoggedIn, LoginFailed }

    // This Controller Class contains Functions which are used by all specific Controllers.
    public abstract class Controller : IController, IErrorHandler
    {

        // Interface for Updating the GUI:
        private List<IView> _views= new List<IView>();
        protected State _state = State.OK;
        protected ErrorHandler _errorHandler = new ErrorHandler();
        protected SortingOrder SortOrder;
        protected string _searchText;
        private IModel _selectedModel;

        public State state { get { return _state; } }

        protected bool _locked = true;
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
            _locked = false;
            foreach (IView v in _views)
            {
                v.UpdateView();
            }
            _errorHandler.Reset();
        }

        public int GetPageCount()
        {
            return (_iterator.Count / _iterator.StepSize) +1;
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

        public abstract void Search(string searchText);
 

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

        public string GetSearchText()
        {
            return _searchText;
        }

        public List<Errors> GetError()
        {
            
            return _errorHandler.GetErrors();
        }

        public bool IsLocked()
        {
            return _locked;
        }
    }
}
