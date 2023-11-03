using BenchmarkDotNet.Running;
using GeneralTesting;
using GeneralTesting.ExtensionMethods;
using GeneralTesting.LazyLoading;
using GeneralTesting.MultipleClassesSameInterfaceInjection;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

//Teste da ferramenta de Benchmark
// BenchmarkRunner.Run<BenchmarkParallelism>();

// Teste de criação de métodos de extensão
// OBS.: Dificil de testar unitáriamente, usar para situações pontuais e especificas como I18N
// ExtensionMethodExample.Run();

// Teste de injeção de dependencias com LayzyLoading
// OBS.: Em um cenário que o construtor faz algum tipo de leitura grande pode ser válido, normalmente não vale a pena
// BenchmarkRunner.Run<DependencyInjection>();
// var injection = new DependencyInjection();
// injection.Lazy();
// injection.Normal();

// Teste de injeção múltipla para a mesma interface
// OBS.: Nesse cenário a interface estaria descrita em um pacote SharedKernel e a implementação de cada classe, 1 e 2 
//       Estariam em seus respectivos pacotes
var multiInjection = new TestInjection();
multiInjection.Inject();