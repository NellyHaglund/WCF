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
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Ecutbildning.Laboration2Service", ConfigurationName="IBMICalculator")]
public interface IBMICalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/IBMICalculator/CalculateBMI", ReplyAction="http://Ecutbildning.Laboration2Service/IBMICalculator/CalculateBMIResponse")]
    float CalculateBMI(float weight, float height);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/IBMICalculator/CalculateBMI", ReplyAction="http://Ecutbildning.Laboration2Service/IBMICalculator/CalculateBMIResponse")]
    System.Threading.Tasks.Task<float> CalculateBMIAsync(float weight, float height);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IBMICalculatorChannel : IBMICalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class BMICalculatorClient : System.ServiceModel.ClientBase<IBMICalculator>, IBMICalculator
{
    
    public BMICalculatorClient()
    {
    }
    
    public BMICalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BMICalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BMICalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BMICalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public float CalculateBMI(float weight, float height)
    {
        return base.Channel.CalculateBMI(weight, height);
    }
    
    public System.Threading.Tasks.Task<float> CalculateBMIAsync(float weight, float height)
    {
        return base.Channel.CalculateBMIAsync(weight, height);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Ecutbildning.Laboration2Service", ConfigurationName="IHobby")]
public interface IHobby
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/IHobby/AmIStrong", ReplyAction="http://Ecutbildning.Laboration2Service/IHobby/AmIStrongResponse")]
    string AmIStrong(string input);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/IHobby/AmIStrong", ReplyAction="http://Ecutbildning.Laboration2Service/IHobby/AmIStrongResponse")]
    System.Threading.Tasks.Task<string> AmIStrongAsync(string input);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHobbyChannel : IHobby, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HobbyClient : System.ServiceModel.ClientBase<IHobby>, IHobby
{
    
    public HobbyClient()
    {
    }
    
    public HobbyClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HobbyClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HobbyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HobbyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string AmIStrong(string input)
    {
        return base.Channel.AmIStrong(input);
    }
    
    public System.Threading.Tasks.Task<string> AmIStrongAsync(string input)
    {
        return base.Channel.AmIStrongAsync(input);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Ecutbildning.Laboration2Service", ConfigurationName="INext1000DaysCalculator")]
public interface INext1000DaysCalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/INext1000DaysCalculator/CalculateNext1000D" +
        "ays", ReplyAction="http://Ecutbildning.Laboration2Service/INext1000DaysCalculator/CalculateNext1000D" +
        "aysResponse")]
    string CalculateNext1000Days(System.DateTime date);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/INext1000DaysCalculator/CalculateNext1000D" +
        "ays", ReplyAction="http://Ecutbildning.Laboration2Service/INext1000DaysCalculator/CalculateNext1000D" +
        "aysResponse")]
    System.Threading.Tasks.Task<string> CalculateNext1000DaysAsync(System.DateTime date);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface INext1000DaysCalculatorChannel : INext1000DaysCalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class Next1000DaysCalculatorClient : System.ServiceModel.ClientBase<INext1000DaysCalculator>, INext1000DaysCalculator
{
    
    public Next1000DaysCalculatorClient()
    {
    }
    
    public Next1000DaysCalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public Next1000DaysCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public Next1000DaysCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public Next1000DaysCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string CalculateNext1000Days(System.DateTime date)
    {
        return base.Channel.CalculateNext1000Days(date);
    }
    
    public System.Threading.Tasks.Task<string> CalculateNext1000DaysAsync(System.DateTime date)
    {
        return base.Channel.CalculateNext1000DaysAsync(date);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Ecutbildning.Laboration2Service", ConfigurationName="IYearCalculator")]
public interface IYearCalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/IYearCalculator/CalculateAgeIntoYears", ReplyAction="http://Ecutbildning.Laboration2Service/IYearCalculator/CalculateAgeIntoYearsRespo" +
        "nse")]
    float CalculateAgeIntoYears(System.DateTime date);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Ecutbildning.Laboration2Service/IYearCalculator/CalculateAgeIntoYears", ReplyAction="http://Ecutbildning.Laboration2Service/IYearCalculator/CalculateAgeIntoYearsRespo" +
        "nse")]
    System.Threading.Tasks.Task<float> CalculateAgeIntoYearsAsync(System.DateTime date);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IYearCalculatorChannel : IYearCalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class YearCalculatorClient : System.ServiceModel.ClientBase<IYearCalculator>, IYearCalculator
{
    
    public YearCalculatorClient()
    {
    }
    
    public YearCalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public YearCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public YearCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public YearCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public float CalculateAgeIntoYears(System.DateTime date)
    {
        return base.Channel.CalculateAgeIntoYears(date);
    }
    
    public System.Threading.Tasks.Task<float> CalculateAgeIntoYearsAsync(System.DateTime date)
    {
        return base.Channel.CalculateAgeIntoYearsAsync(date);
    }
}