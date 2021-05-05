using System;
using System.Collections.Generic;

namespace Finance.ApiModels.Common
{
    public class ErrorsModel
    {
        public IList<ErrorsModel> Errors { get; set; }

        public ErrorsModel()
        {
            Errors = new List<ErrorsModel>();
        }

        public ErrorsModel(params ErrorsModel[] errorsViewModel) : this()
        {
            foreach (var error in errorsViewModel)
                Errors.Add(error);
        }

        public ErrorsModel(IEnumerable<ErrorsModel> errorsViewModel) : this()
        {
            foreach (var error in errorsViewModel)
                Errors.Add(error);
        }

        public void ErrorsViewModelModel(ErrorsModel error)
        {
            if (error == null)
                throw new ArgumentException(nameof(error));

            Errors.Add(error);
        }
    }
}
