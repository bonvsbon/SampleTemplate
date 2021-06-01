using System;
using SampleTemplate.InitialAppSettings;
using SampleTemplate.Context;
using SampleTemplate.Common;
using Microsoft.Extensions.Options;
using SampleTemplate.Models;

namespace SampleTemplate.Models
{
    public class SampleModel : ContextBase
    {
        AppSettings config;
        private Statement statement;
        public ResultAccess resAccess;
        private Utility func;

        public SampleModel(IOptions<AppSettings> initial) : base(initial)
        {
            config = initial.Value;
            resAccess = new ResultAccess(initial);
            statement = new Statement();
            func = new Utility();
        }

        public ResponseModel InitialState(string agreementNo)
        {
            statement.AppendStatement("EXEC REST_CustomerInformation @AgreementNo");
            statement.AppendParameter("@AgreementNo", agreementNo);
            
            return resAccess.ExecuteDataTable(statement);
        }

    }
}