using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldiDesignPrinciple
{

    //The Interface segregation principle: "Clients should not be forced to depend upon interfaces that they do not use."
    //Instead of one fat interface, many small interfaces are preferred based on groups of methods, each one serving one submodule.
    //So instead of huge interfaces, it is better to create multiple small ones so that
    //they are utilized in the best possible way.


    // Let's take a interface for example
    interface Features
    {
        void TextMessaging();
        void VedioCall();
        void Gamming();
    }

    // according to our interface segration principle, instade of creating one big interface we can create multiple small task specific interface.
    // buy which the consumer are not foreced to implement all methods of interface. They only implement interface that they need.

    interface FeatureTextMessage
    {
        public void TextMessaging();
    }

    interface FeatureVedioCall
    {
        public void VedioCall();
    }

    interface FeatureGamming
    {
        public void Gamming();
    }

    // if a conusmer need to implement all feature then it have to extend all interface otherwise the consumer can extend only needed interface.

    public class IPhone : FeatureTextMessage, FeatureVedioCall, FeatureGamming
    {
        public void Gamming()
        {
            Console.WriteLine("Yes");
        }

        public void TextMessaging()
        {
            Console.WriteLine("Yes");
        }

        public void VedioCall()
        {
            Console.WriteLine("Yes");
        }
    }

    // Let's create another class that inplement only text message interface
    public class OldNokia : FeatureTextMessage
    {
        public void TextMessaging()
        {
            Console.WriteLine("Yes");
        }
    }

    
}
