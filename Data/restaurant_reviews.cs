﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class restaurant_reviews {
    
    private restaurant[] restaurantField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("restaurant")]
    public restaurant[] restaurant {
        get {
            return this.restaurantField;
        }
        set {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class restaurant {
    
    private string restaurant_nameField;
    
    private string websiteField;
    
    private logoType logoField;
    
    private addressType addressField;
    
    private string phoneField;
    
    private rating ratingField;
    
    private string food_typeField;
    
    private cost costField;
    
    private dateType dateField;
    
    private string reviewerField;
    
    private string summaryField;
    
    private menuType menuField;
    
    /// <remarks/>
    public string restaurant_name {
        get {
            return this.restaurant_nameField;
        }
        set {
            this.restaurant_nameField = value;
        }
    }
    
    /// <remarks/>
    public string website {
        get {
            return this.websiteField;
        }
        set {
            this.websiteField = value;
        }
    }
    
    /// <remarks/>
    public logoType logo {
        get {
            return this.logoField;
        }
        set {
            this.logoField = value;
        }
    }
    
    /// <remarks/>
    public addressType address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    public rating rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
    
    /// <remarks/>
    public string food_type {
        get {
            return this.food_typeField;
        }
        set {
            this.food_typeField = value;
        }
    }
    
    /// <remarks/>
    public cost cost {
        get {
            return this.costField;
        }
        set {
            this.costField = value;
        }
    }
    
    /// <remarks/>
    public dateType date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public string reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    public string summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
    
    /// <remarks/>
    public menuType menu {
        get {
            return this.menuField;
        }
        set {
            this.menuField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class logoType {
    
    private string widthField;
    
    private string heightField;
    
    private string unitField;
    
    private string pathField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class priceType {
    
    private string quantityField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class menuType {
    
    private foodTypeItem[] appetizersField;
    
    private foodTypeItem[] entreesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
    public foodTypeItem[] appetizers {
        get {
            return this.appetizersField;
        }
        set {
            this.appetizersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
    public foodTypeItem[] entrees {
        get {
            return this.entreesField;
        }
        set {
            this.entreesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class foodTypeItem {
    
    private string nameField;
    
    private string descriptionField;
    
    private priceType[] priceField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price")]
    public priceType[] price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class dateType {
    
    private ushort yearField;
    
    private string monthField;
    
    private byte dayField;
    
    /// <remarks/>
    public ushort year {
        get {
            return this.yearField;
        }
        set {
            this.yearField = value;
        }
    }
    
    /// <remarks/>
    public string month {
        get {
            return this.monthField;
        }
        set {
            this.monthField = value;
        }
    }
    
    /// <remarks/>
    public byte day {
        get {
            return this.dayField;
        }
        set {
            this.dayField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class addressType {
    
    private string streetField;
    
    private string cityField;
    
    private provinceType provinceField;
    
    private string postal_codeField;
    
    /// <remarks/>
    public string street {
        get {
            return this.streetField;
        }
        set {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    public string city {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public provinceType province {
        get {
            return this.provinceField;
        }
        set {
            this.provinceField = value;
        }
    }
    
    /// <remarks/>
    public string postal_code {
        get {
            return this.postal_codeField;
        }
        set {
            this.postal_codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public enum provinceType {
    
    /// <remarks/>
    ON,
    
    /// <remarks/>
    QC,
    
    /// <remarks/>
    BC,
    
    /// <remarks/>
    ALBT,
    
    /// <remarks/>
    SK,
    
    /// <remarks/>
    MB,
    
    /// <remarks/>
    NL,
    
    /// <remarks/>
    PEI,
    
    /// <remarks/>
    NB,
    
    /// <remarks/>
    NS,
    
    /// <remarks/>
    NT,
    
    /// <remarks/>
    NV,
    
    /// <remarks/>
    YK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class rating {
    
    private byte minField;
    
    private byte maxField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class cost {
    
    private byte minField;
    
    private byte maxField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}