using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.Saga;

namespace SagaDataLongFieldIssue
{
    public class TestSaga : Saga<TestSagaData>, IAmStartedByMessages<TestCommand>
    {
        public void Handle(TestCommand message)
        {
            throw new NotImplementedException();
        }

        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<TestSagaData> mapper)
        {
           
        }
    }
}
