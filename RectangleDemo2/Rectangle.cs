using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo2
{
    public class Rectangle
    {
        /*Struct(by value) <> Interface(is totally abstruct by default;no implementation) <> Class(by ref)  
        abstract(child "completes" or does whole implementation) <> sealed(class can't be parent & sealed member can'tbe modified by child) <> static(class can't be parent & can't be "new")*/

        /*Abstract Class calssName(){...all members have to be declared abstract + some or no implementation done in abstractparent...}
        Abstract is similar to declaring members as "virtual" i.e abstract members have to be "override" in child-classes
        BUT BUT we can't instantiate asbtract classes directly, as opposed to classes containing "virtual" methods
        */
        /*"Interface" is a type of abstract class, but abstract could have SOME direct implementation, interface don't have ANY implementation.
        A child class could have ONLY one parent class BUT can have MANY parent-interfaces*/

        /*"sealed" decorated classes cannot be a "base"(parent) class.
        BUT decorating methods/prop e "sealed" allow it to be base class BUT stop child from changing implementation of base method/prop*/

        /*overloading operator = step-by-step-page-551  --  joyce-p-323  -- "struct"=? -- "interface" p-395
        "Abstract-classes"
       Cannot overload dot (.) op. All op must be public & must be static. <public static ClassName operator +(Hour lhs, Hour rhs)> 
       binary op must have 2 params of w at least one is of containing-type(class), unary have one. Method overload r called like 
       method() BUT op-OL r called just by using that op like obj1+obj2. a+=b; is evaluated like a=a+b; so overloaded + will also play role in such compound-assignment ops.
       Unary op like postfix(1st assign then increment) var++ & prefix ++var when overloaded, keep their precedence in same order. Postfix/Prefix unary op work properly ONLY if type is a STRUCT (structure is by value) NOT a CLASS(by ref). Bcoz if it's a class(by ref), postfix objNew=obj++ will assign obj to objNew then increment++ the PHYSICAL location referred-to by both obj & objNew, so if it's a class, obj++ behaves like ++obj w is BAD:-solution is to instantiate a new class-obj everytime ++ is called by puttg following in op-overload-method <return new Hour(arg.value + 1);><NOT arg.value++ coz it will ASSIGN incremented value to original obj w we don't want> so that increment if NOT done to previous obj.
       Some ops MUST be defined in pairs i.e write 2 methods. (== & !=) (> & <) (>= & <=).
       */


        /*Inheritence: childClass auto contain all fields/properties/methods of parentClass PLUS it's own. Parent doesn't inherit anything.
        class childClassName : parentClassName
        {... }           
        if parentClass constructor needs args, then use "base" to refer to immediate-parentClass:-
        class childClassName(int arg1, string arg2) : base(arg1) <--> constructor(int arg1, string arg2...):this(arg1) refer to self-class, explained a while later below.
        
        Another e.g. public CommissionEmployee(int id, string name) : base(id, name) {} >>> 2 of params passed on as args to base-constructor.


        obj = new childClassName() gives access to all fields/properties/methods of parentClass.
        Access modifier "Private" will NOT give access to field even to childClass so will have to go thru "set" of the PUBLIC property. but "Protected" will allow childClass to accedd parentClass's fields. "protected" is intermediate b/w public & private.
        Like we put static aft public etc, if put 'public "virtual" int PropertyName...'  in parentClass then
        childClass can have method e EXACT same name to override/hide parent's method e.g. 'override public int PropertyName'. Virtual prop stays "visible" to child, until child's same-name prop "Hides" it.
        We can even use parent as "Type" and instantiate child-obj like >>> ParentClassName obj = new ChildClassName(); bcoz chilsClass-obj is an instance of BOTH childClass & parentClass. This is where using "override" or "new" makes a difference as explained below:
        If obj declaration-"type" is same as class used to create obj, new/override both do same thing. But if declared a parent-type BUT assign it a child then "override" causes child-obj to use child's prop while "new" causes obj to use parents same-name prop. Child Ko Parent Ki Type Declare Kia Ja Sakta Hay.
        Same-Name methods of parent & child r NOT over-Loads.
        Even if we don't use override above, still prog works 7 child's prop/method "Hides" same-name thing of parent, but a warning is given that u r 'Hiding' parent's prop/method. Using override eliminates warning.
        Despite override/new a child-obj can still use parent's-same-name method (not prop!?) as "base.methodCall();" [e.g on p-444].
        */

        /*Like int is alias of "System.Int32", "object" is alias of "System.Object" w is a parent(root)-class of ALL classes(implicitly; or explicitly[but not needed] as class parentClass : object) [more on p-447]*/


        /*Constructor initializers <> Obj init: p-383
        say we have 3 overloads of constors Class() & Class(int x) & Class(int x, int y)
        Then init is like =>>   ClassConstructor() : this(999, 0) & Class(x, 0) >>> init exe 3rd overload e 2 params first & THEN exe the overload that init it.
        There's NO init for the most elaborate constructor Class(int x, int y) >>> Any future modifications could just be done in 3rd OL (see p-383)*/

        /*Obj init.zers P-385
        Instead of calling const e args we can do as below. Param-less constructor is called auto before assignment is made:
        Employee aWorker = new Employee {IdNumber = 101, Salary = 2000};
        Where IdNumber is PUBLIC prop.
        Above Obj init replaced  [aWorker.IdNumber = 101; aWorker.Salary = 2000;]
            */

        /*Emumerations: book-p-78   ---  http://www.dotnetperls.com/enum
         are declared e small-e [ enum nameOfEnum {comma separated CONSTANTS w r given int values of 0, 1, 2...so on by default} ]. We can assign 1st item value other than 0 & next items will auto increment by 1. or can assign ALL items a value of their own.
        To change default int type to another (only)numerical&nonDouble-wholeNumber-type [enum nameOfEnum : nonInt-numerical-typeHere {-,-,-,-,-,-}] 
        enum can be cast into any other data type by casting as (int)nameOfEnum; --- BUT ONLY int van be converted to enum by "casting" as (nameOfEnum)intValue; --- 
        non-int like string caould be converted to enum as (nameOfEnum)Enum.Parse(typeof(nameOfEnum), stringValue); more here: http://www.dotnetperls.com/enum*/

        /*fields("instance variables" belong to ea obj created from a class i.e. non-static) <-> ( Class-Variables=r static & belong to class NOT obj):- are object's "attributes"(taken from "class"). Fields are just variables but named differently to differentiate from other variables we might use. Object-specific "values" of these fields(attributes) are called "state" of object."instance variables" are "fields-of-class" when they become "variables-for-objects instantiated from that class instance variable(are non-static i.e. diff value for each obj -&- mostly made PRIVATE)=field=data field=a class-field=attributes=variable-of-class="attributes"-of-objects acquired from class. p-356

            "state"=value of instance variable for an obj. 
            
            "instance methods"(r non-static i.e. gives diff result for ea obj due to diff data-fields of ea obj -&- mostly made PUBLIC & r non-static(i.e. one for ea obj created;; NOT one for the whole class.)    & validate/check the value being imparted to field against criteria)=methods-of-class that are available to ea object(s) created from that class.
            
            "class-method"= r static-methods that can be called without instantiating an object from class. 
            
            "client-of-class" or  "class-user"(e.g Main() in a program) = class/program that use another class to instantiate object(s).class=a type of object.
         class has fields & methods(regular & constructor-method & override-method-to-display on screen etc) Using an object within another object is known as composition. = "has-a relationship"
         The  "new" operator is allocating a new, unused portion of computer memory. Not needed for build-in data-types like int x = new int(); x is initialized to 0. int x; x holds no usable starting value BUT in an object int x; will be initialized to 0, & compiler gives a warning msg. Object-made-from-a-class<->(opp is "struct") is passed by-reference & obj-identifiers refer to physical memory location hence called "reference type"<==>"value  types"=e.g. "struct"(same as class but by value NOT by ref), int, double identifiers just refer to "value" NOT physical memory location.*/


        //Fields(become 'instance var' once obj is instantiated. if 'static' then these r NOT fields BUT "class-variables".):
        private int length; //assigned 0 value when object is instantiated, even e-out we doing so.
        private int width;
        /*private &  non-static is default access-modifier for class-field is not written.which means that no other
class can access the field’s values, and only nonstatic methods of the same class will be allowed to set, get, or otherwise use the field="information hiding". But their contents are accessed through  public methods , like, attribute="level of petrol in gas tank" cannot be accesssed with naked eye, but thru a public-guage.*/



        /*constructor(method): Used to assign(set) values to PRIVATE fields(variables) from within the class.  
        Have no return type not even void, (so executes without being called=self-invoking!!??). 
        Name of constructor-method must exactly match name of class bcoz to instantiate an obj of a class, we call upon it's constructor-method e.g. new Rectangle(); In fact, it is the name of construct-method that constructs a  Rectangle-object(teacher said it's "new" that constructs obj NOT the construct-method!!).
        If we don't create a constructor, then automatically-generated constructor takes NO args inside ().
        not mentioning "static" makes it NON-static so that method can ONLY be accessed as =mew constructor(); -OR- as object.method(); if 
        it was NOT instantiated using "new"*/


        //Constructor is:
        public Rectangle(int len, int wid)
        {
            length = len;
            width = wid;
        }

        //method: to display more meaningful obj
        public override string ToString()
        {
            return "Length: " + length + " Width: " + width;
            //return string.Format("Length: {0}.  Width: {1}", length, width);
        }


        //another method: to calculate area:
        public void CalculateAndDisplayArea()
        {
            Console.WriteLine("Area: {0}", length * width);
        }
//Properties step-by-step page-352.
//Whenever i try to read a prop, get is fired. Whenever i try to assign(write to) a prop, set is triggered. Assignment is passes to set-block by auto-declared variable "value".
        /*To get or set fields of an Obj, we can also use "properties" instead of regular methods as above:
Until i try to assign(write to) the property, "set" will NOT be fired. Also there's no automatic link b/w prop & it's field, I can even name them 2 diff names & it'll still work.
So if I don't want to write to/read-from the field of a prop, I don't have to create a field, rather leave the prop alone.
Prop cannot be used as "ref" & "out". A math calculation returned directly from prop without being set to a writable field is said do be "dunamically" rather than physically,because the property doesn’t
really point to a memory location but rather to an accessor method
        property=smart-field coz looks like we're declaring the same fields again, BUT we use capital first letter.
        get-accessor=getter, set-accessor=setter, 
        to "get" value of field in Main() just use id with CAPITAL 'L', & to set a value just assign value to property id 
        (e.g. Length = 14;). Similarly create property "Width" to get/set "width"
        contextual-keywords (e.g. get, set, value) can be used as id except in context of 'property' of class etc*/

        /*public int Length  //capital L
        {
        get{return length;} //can be this.length for clarity that I refer to instance-variable not the parameter"length", BUT not reqd.    //small "l", 
        if put 'L' by mistake , infinite loop coz keeps calling itself 'Length'.
        set{length = value;}    //small "l"
        }

        //shorthand in C#3.0 =  auto-implemented property = automatic properties. Compiler creates 'fields' for auto-prop. DON'T declare 'idNumber' or anything.

        // public int IdNumber {get; set;}  //{get; private set;} is read-only.
        */

        /*string const MOTTO = "lkalhasl" will make field "static" by-default. It's accessed by className.MOTTO, NOT by objName.MOTTO,  since there's just one copy stored for class no matter how many obj.s u create. <<<NON-static means it "varies" for ALL objects created from a class. i.e it's class-specific NOT object-specific>>>.*/



        


    }
}
