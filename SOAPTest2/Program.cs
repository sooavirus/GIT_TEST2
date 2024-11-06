using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SOAPTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HDEL_PP_GET_ZPPR005Client client = new HDEL_PP_GET_ZPPR005Client();
            FlexNet.WebServices.HDEL_PP_GET_ZPPR005Inputs inputs = new FlexNet.WebServices.HDEL_PP_GET_ZPPR005Inputs();
            inputs.AUFNR = "000010784729";
            // 서비스에서 작업을 호출하려면 'client' 변수를 사용하십시오.
            FlexNet.WebServices.OperationInvocationResult result = client.Invoke(inputs);
            
            //세개 항목 CHNUM, SEQ, TEXT 어레이크기는 항상 같음.
            for(int i = 0; i < result.Output_CHNUM.Length; i++)
            {
                Console.WriteLine("CHNUM : " + result.Output_CHNUM.GetValue(i));
                Console.WriteLine("SEQ : " + result.Output_SEQ.GetValue(i));
                Console.WriteLine("TEXT : " + result.Output_TEXT.GetValue(i));
            }
            Console.ReadLine();
            // 항상 클라이언트를 닫으십시오.
            client.Close();
        }
    }
}
