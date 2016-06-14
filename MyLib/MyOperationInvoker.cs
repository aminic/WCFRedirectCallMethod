using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;


namespace MyLib
{
    public class MyOperationInvoker : IOperationInvoker
    {
        IOperationInvoker invoker;
        string name;

        public MyOperationInvoker(IOperationInvoker invoker, string name)
        {
            this.invoker = invoker;
            this.name = name;
        }

        public bool IsSynchronous
        {
            get
            {
                return true;
            }
        }

        public object[] AllocateInputs()
        {

            var inputs = this.invoker.AllocateInputs();
            return inputs;
        }

        public object Invoke(object instance, object[] inputs, out object[] outputs)
        {

            //var result= this.invoker.Invoke(instance, inputs, out outputs);
            //return result;

            string result = string.Empty;
            var s = new MyService();

            if (this.name == "Hello")
            {
                result = s.Welcome(inputs[0].ToString());
            }
            else
            {
                result = s.Hello(inputs[0].ToString());
            }
            outputs = new object[] { };
            return result as object;






            //try
            //{
            //    //根据参数及方法名称生成一个唯一的 key
            //    string key = GenerateKey(_name, inputs);
            //    CacheItem result = MemoryCache.Default.GetCacheItem(key);
            //    if (result == null)
            //    {
            //        object obj = _invoker.Invoke(instance, inputs, out outputs);
            //        //这里利用了 .Net 4.0 内置的 MemoryCache
            //        MemoryCache.Default.Add(key, new object[] { obj, outputs }, new CacheItemPolicy { SlidingExpiration = new TimeSpan(0, 20, 0) });
            //        return obj;
            //    }
            //    else
            //    {
            //        object[] cachedItems = result.Value as object[];
            //        outputs = cachedItems[1] as object[];
            //        return cachedItems[0];
            //    }
            //}
            //catch (Exception e)
            //{
            //    //TODO: log
            //    throw;
            //}

        }

        public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
        {
            //throw new NotImplementedException();
            return invoker.InvokeBegin(instance, inputs, callback, state);
        }

        public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
        {
            //throw new NotImplementedException();
            return this.invoker.InvokeEnd(instance, out outputs, result);
        }
    }
}
