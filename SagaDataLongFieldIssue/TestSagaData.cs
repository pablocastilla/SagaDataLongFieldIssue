using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.Saga;

namespace SagaDataLongFieldIssue
{
    public class TestSagaData : ContainSagaData
    {
        //if DisconnectTransactionInProgress is changed to DisconnectTranInProgress the table for the saga is created
        public virtual string DisconnectTransactionInProgress { get; set; }
    }
}
