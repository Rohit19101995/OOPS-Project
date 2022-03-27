using System;
namespace oops
 {                 
   // It contains: Class, Objects, Constructor, Overriding(Polymorphism), Abstraction, Interface                  
  public interface Human                      // interface Human
{
 public void skincolor();
}
                                                    
   abstract  public class Father                       // Base class
    {
        public virtual  void property()               //Property  method- to be overrride in derived class
        {
            
            Console.WriteLine("This property belong to Father");
        }
        public  Father()                // Father constructor
        {
          Console.WriteLine ("This is the father constructor");
        }
       public abstract void mobilenumber();   // abstract method - so no body

       public void house(){
         Console.WriteLine(" This is Father's House!");
       }
        
    }


                         
    public class Child : Father , Human          ////Child class - implement abstract Father class and implement interface Human class
    {
         public override void property()               //Property  method- override
        {
        
            Console.WriteLine("This property belong to Child");
        }
        public  Child()  // no return type for constructor
        {
            Console.WriteLine("This is the child constructor");
        }
        public override void mobilenumber(){
          Console.WriteLine("This is child contact number");
        } 

       public void skincolor()
        {
         Console.WriteLine("Child's skin color is Brown"); //provide body to interface menthod- skinColors 
        }


        
    }
    class MyMainClass
    {
        //Entry point
        static void Main(string[] args)
        {

            Father fObj = new Child();
            fObj.property();
            fObj.mobilenumber();
            fObj.house();
            //fObj.skincolor(); // thows Error , because father doen't contain definition for ''skincolor"
          

            //Here Child object can access both class methods
            Child cObj = new Child();
            cObj.property();
            cObj.mobilenumber();
            cObj.house();
            cObj.skincolor();
        }
    }
}