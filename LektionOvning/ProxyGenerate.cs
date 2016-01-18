﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Ecutbildning.SocialSecurityNumber", ConfigurationName="IGender")]
public interface IGender
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.SocialSecurityNumber/IGender/ReturnGender", ReplyAction="http://Ecutbildning.SocialSecurityNumber/IGender/ReturnGenderResponse")]
    string ReturnGender(string socialSecurityNumber);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.SocialSecurityNumber/IGender/ReturnGender", ReplyAction="http://Ecutbildning.SocialSecurityNumber/IGender/ReturnGenderResponse")]
    System.Threading.Tasks.Task<string> ReturnGenderAsync(string socialSecurityNumber);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IGenderChannel : IGender, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GenderClient : System.ServiceModel.ClientBase<IGender>, IGender
{
    
    public GenderClient()
    {
    }
    
    public GenderClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public GenderClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GenderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GenderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string ReturnGender(string socialSecurityNumber)
    {
        return base.Channel.ReturnGender(socialSecurityNumber);
    }
    
    public System.Threading.Tasks.Task<string> ReturnGenderAsync(string socialSecurityNumber)
    {
        return base.Channel.ReturnGenderAsync(socialSecurityNumber);
    }
}
