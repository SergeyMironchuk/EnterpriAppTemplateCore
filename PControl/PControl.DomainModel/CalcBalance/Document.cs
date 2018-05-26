using System;
using System.Collections.Generic;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace PControl.DomainModel.CalcBalance
{
    public class Document
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        private ISet<DocumentDetail> _details;

        public ISet<DocumentDetail> Details
        {
            get
            {
                _details = _details ?? new HashSet<DocumentDetail>();
                return _details;
            }
            set { _details = value; }
        }

        public void AddDetail(DocumentDetail detail)
        {
            detail.Document = this;
            Details.Add(detail);
        }

        public string AdditionalInformation { get; set; }
    }
}