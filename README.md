# SpecFlowTraining
### SpecFlow, Cucumber for .NET.

## In order to run specflow with NUnit download the following packges via Nuget package manager:
* Specflow
* NUnit
* NUnit3TestAdapter

### Additionaly insert the following section in app.config to specify test adapter (MSTest for instance)
```csharp
  <specFlow>
    <unitTestProvider name="NUnit" />
    <!-- For additional details on SpecFlow configuration options see http://go.specflow.org/doc-config -->
  </specFlow>
 ``` 
  
