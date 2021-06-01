using System.Threading;
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Extensions.Options;
using DataTable = System.Data.DataTable;


namespace SampleTemplate.Common
{
    public class Utility
    {
        public string EncryptString(string value)
        {
            return AESEncrypt.AESOperation.EncryptString(value);
        }

        public string DecryptString(string value)
        {
            return AESEncrypt.AESOperation.EncryptString(value);
        }
            public string GetStateHttp(StatusHttp code)
        {
            string resultCode = "";
            switch (code)
            {
                case StatusHttp.Created:
                    resultCode = "201";
                    break;
                case StatusHttp.Accepted:
                    resultCode = "202";
                    break;
                case StatusHttp.InvalidToken:
                    resultCode = "400";
                    break;
                case StatusHttp.SecurityError:
                    resultCode = "401";
                    break;
                case StatusHttp.NotFound:
                    resultCode = "404";
                    break;
                case StatusHttp.InternalError:
                    resultCode = "500";
                    break;
                default:
                    resultCode = "200";
                    break;
            }

            return resultCode;
        }
    }        
    public enum StatusHttp
    {
        OK,
        Created,
        Accepted,
        NotFound,
        InternalError,
        InvalidToken,
        SecurityError
    }
}