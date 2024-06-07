using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarPricePrediction.Module.BusinessObjects
{
    // Register this entity in your DbContext (usually in the BusinessObjects folder of your project) with the "public DbSet<VwCars> VwCarss { get; set; }" syntax.
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("Name")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    // You do not need to implement the INotifyPropertyChanged interface - EF Core implements it automatically.
    // (see https://learn.microsoft.com/en-us/ef/core/change-tracking/change-detection#change-tracking-proxies for details).
    public class VwCars : BaseObject
    {
        public VwCars()
        {
            // In the constructor, initialize collection properties, e.g.: 
            // this.AssociatedEntities = new ObservableCollection<AssociatedEntityObject>();
        }

        // You can use the regular Code First syntax.
        // Property change notifications will be created automatically.
        // (see https://learn.microsoft.com/en-us/ef/core/change-tracking/change-detection#change-tracking-proxies for details)
        //public virtual string Name { get; set; }

        // Alternatively, specify more UI options:
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), VisibleInListView(false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        //public virtual string Name { get; set; }

        // Collection property:
        //public virtual IList<AssociatedEntityObject> AssociatedEntities { get; set; }

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}

        public virtual string model { get; set; }       // 15157 non-null  object 
        public virtual int? year { get; set; }        // 15157 non-null  int64  
        public virtual int? price { get; set; }       //15157 non-null  int64  
        public virtual string transmission { get; set; } //15157 non-null  object 
        public virtual int? mileage { get; set; }     //15157 non-null  int64  
        public virtual string fuelType { get; set; }     //15157 non-null  object 
        public virtual int? tax { get; set; }          //15157 non-null  int64  
        public virtual double? mpg { get; set; }          //15157 non-null  float64
        public virtual double? engineSize { get; set; }    //15157 non-null  float64
    }
}