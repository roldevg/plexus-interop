// <auto-generated>
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: plexus\interop\testing\echo_server.interop
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Testing.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
					
	public partial interface IEchoServerClient: IClient {
		EchoServerClient.IEchoServiceProxy EchoService { get; }
		
		EchoServerClient.IGreetingServiceProxy GreetingService { get; }
	}
	
	public sealed partial class EchoServerClient: ClientBase, IEchoServerClient {
		
		public const string Id = "plexus.interop.testing.EchoServer";
		
		private static ClientOptions CreateClientOptions(EchoServerClient.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null) {
			ClientOptionsBuilder builder = new ClientOptionsBuilder().WithApplicationId(Id).WithDefaultConfiguration();
			serviceBinder.Bind(builder);
			if (setup != null) {
				builder = setup(builder);
			}
			return builder.Build();
		}
		
		public EchoServerClient(
			EchoServerClient.IEchoServiceImpl echoService,
			EchoServerClient.IGreetingServiceImpl greetingService,
			EchoServerClient.IAlwaysLaunchGreetingServiceImpl alwaysLaunchGreetingService,
			EchoServerClient.INeverLaunchGreetingServiceImpl neverLaunchGreetingService,
			Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null
		)
		:this(new EchoServerClient.ServiceBinder(
			echoService,
			greetingService,
			alwaysLaunchGreetingService,
			neverLaunchGreetingService
		), setup) { }
		
		public EchoServerClient(EchoServerClient.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null): base(CreateClientOptions(serviceBinder, setup)) 
		{
			EchoService = new EchoServerClient.EchoServiceProxy(this.CallInvoker);
			GreetingService = new EchoServerClient.GreetingServiceProxy(this.CallInvoker);
		}
	
		public sealed partial class ServiceBinder {
			
			public ServiceBinder(
				EchoServerClient.IEchoServiceImpl echoService,
				EchoServerClient.IGreetingServiceImpl greetingService,
				EchoServerClient.IAlwaysLaunchGreetingServiceImpl alwaysLaunchGreetingService,
				EchoServerClient.INeverLaunchGreetingServiceImpl neverLaunchGreetingService
			) {
				_echoServiceBinder = new EchoServerClient.EchoServiceBinder(echoService);
				_greetingServiceBinder = new EchoServerClient.GreetingServiceBinder(greetingService);
				_alwaysLaunchGreetingServiceBinder = new EchoServerClient.AlwaysLaunchGreetingServiceBinder(alwaysLaunchGreetingService);
				_neverLaunchGreetingServiceBinder = new EchoServerClient.NeverLaunchGreetingServiceBinder(neverLaunchGreetingService);
			}
			
			private EchoServiceBinder _echoServiceBinder;
			private GreetingServiceBinder _greetingServiceBinder;
			private AlwaysLaunchGreetingServiceBinder _alwaysLaunchGreetingServiceBinder;
			private NeverLaunchGreetingServiceBinder _neverLaunchGreetingServiceBinder;
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				builder = _echoServiceBinder.Bind(builder);
				builder = _greetingServiceBinder.Bind(builder);
				builder = _alwaysLaunchGreetingServiceBinder.Bind(builder);
				builder = _neverLaunchGreetingServiceBinder.Bind(builder);
				return builder;
			}
		}
	
		public partial interface IEchoServiceImpl:
			global::Plexus.Interop.Testing.Generated.EchoService.IUnaryImpl,
			global::Plexus.Interop.Testing.Generated.EchoService.IServerStreamingImpl,
			global::Plexus.Interop.Testing.Generated.EchoService.IClientStreamingImpl,
			global::Plexus.Interop.Testing.Generated.EchoService.IDuplexStreamingImpl
		{ }
		
		private sealed partial class EchoServiceBinder {
			
			
			private readonly IEchoServiceImpl _impl;
			
			public EchoServiceBinder(IEchoServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Testing.Generated.EchoService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest>(global::Plexus.Interop.Testing.Generated.EchoService.UnaryMethodId, _impl.Unary);
				builder = builder.WithServerStreamingMethod<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest>(global::Plexus.Interop.Testing.Generated.EchoService.ServerStreamingMethodId, _impl.ServerStreaming);
				builder = builder.WithClientStreamingMethod<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest>(global::Plexus.Interop.Testing.Generated.EchoService.ClientStreamingMethodId, _impl.ClientStreaming);
				builder = builder.WithDuplexStreamingMethod<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest>(global::Plexus.Interop.Testing.Generated.EchoService.DuplexStreamingMethodId, _impl.DuplexStreaming);
				return builder; 							
			}
		}
		
		public sealed partial class EchoServiceImpl: IEchoServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> _unaryHandler;
			private readonly ServerStreamingMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> _serverStreamingHandler;
			private readonly ClientStreamingMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> _clientStreamingHandler;
			private readonly DuplexStreamingMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> _duplexStreamingHandler;
			
			public EchoServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> unaryHandler,
				ServerStreamingMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> serverStreamingHandler,
				ClientStreamingMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> clientStreamingHandler,
				DuplexStreamingMethodHandler<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> duplexStreamingHandler
			) {
				_unaryHandler = unaryHandler;
				_serverStreamingHandler = serverStreamingHandler;
				_clientStreamingHandler = clientStreamingHandler;
				_duplexStreamingHandler = duplexStreamingHandler;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.EchoRequest> Unary(global::Plexus.Interop.Testing.Generated.EchoRequest request, MethodCallContext context) {
				return _unaryHandler(request, context);
			}
			
			public Task ServerStreaming(global::Plexus.Interop.Testing.Generated.EchoRequest request, IWritableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> responseStream, MethodCallContext context) {
				return _serverStreamingHandler(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.EchoRequest> ClientStreaming(IReadableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> requestStream, MethodCallContext context) {
				return _clientStreamingHandler(requestStream, context);
			}
			
			public Task DuplexStreaming(IReadableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> requestStream, IWritableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> responseStream, MethodCallContext context) {
				return _duplexStreamingHandler(requestStream, responseStream, context);
			}
		}					
		
		public sealed partial class EchoServiceImpl<T>: IEchoServiceImpl
			where T:
			global::Plexus.Interop.Testing.Generated.EchoService.IUnaryImpl,
			global::Plexus.Interop.Testing.Generated.EchoService.IServerStreamingImpl,
			global::Plexus.Interop.Testing.Generated.EchoService.IClientStreamingImpl,
			global::Plexus.Interop.Testing.Generated.EchoService.IDuplexStreamingImpl
		{
			private readonly T _impl;
			
			public EchoServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.EchoRequest> Unary(global::Plexus.Interop.Testing.Generated.EchoRequest request, MethodCallContext context) {
				return _impl.Unary(request, context);
			}
			
			public Task ServerStreaming(global::Plexus.Interop.Testing.Generated.EchoRequest request, IWritableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> responseStream, MethodCallContext context) {
				return _impl.ServerStreaming(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.EchoRequest> ClientStreaming(IReadableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> requestStream, MethodCallContext context) {
				return _impl.ClientStreaming(requestStream, context);
			}
			
			public Task DuplexStreaming(IReadableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> requestStream, IWritableChannel<global::Plexus.Interop.Testing.Generated.EchoRequest> responseStream, MethodCallContext context) {
				return _impl.DuplexStreaming(requestStream, responseStream, context);
			}
		}
		
		public partial interface IGreetingServiceImpl:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloImpl
		{ }
		
		private sealed partial class GreetingServiceBinder {
			
			
			private readonly IGreetingServiceImpl _impl;
			
			public GreetingServiceBinder(IGreetingServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Testing.Generated.GreetingService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse>(global::Plexus.Interop.Testing.Generated.GreetingService.HelloMethodId, _impl.Hello);
				return builder; 							
			}
		}
		
		public sealed partial class GreetingServiceImpl: IGreetingServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse> _helloHandler;
			
			public GreetingServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse> helloHandler
			) {
				_helloHandler = helloHandler;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request, MethodCallContext context) {
				return _helloHandler(request, context);
			}
		}					
		
		public sealed partial class GreetingServiceImpl<T>: IGreetingServiceImpl
			where T:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloImpl
		{
			private readonly T _impl;
			
			public GreetingServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request, MethodCallContext context) {
				return _impl.Hello(request, context);
			}
		}
		
		public partial interface IAlwaysLaunchGreetingServiceImpl:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloImpl
		{ }
		
		private sealed partial class AlwaysLaunchGreetingServiceBinder {
			
			public const string Alias = "AlwaysLaunchGreetingService";
			
			private readonly IAlwaysLaunchGreetingServiceImpl _impl;
			
			public AlwaysLaunchGreetingServiceBinder(IAlwaysLaunchGreetingServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Testing.Generated.GreetingService.Id, Alias, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse>(global::Plexus.Interop.Testing.Generated.GreetingService.HelloMethodId, _impl.Hello);
				return builder; 							
			}
		}
		
		public sealed partial class AlwaysLaunchGreetingServiceImpl: IAlwaysLaunchGreetingServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse> _helloHandler;
			
			public AlwaysLaunchGreetingServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse> helloHandler
			) {
				_helloHandler = helloHandler;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request, MethodCallContext context) {
				return _helloHandler(request, context);
			}
		}					
		
		public sealed partial class AlwaysLaunchGreetingServiceImpl<T>: IAlwaysLaunchGreetingServiceImpl
			where T:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloImpl
		{
			private readonly T _impl;
			
			public AlwaysLaunchGreetingServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request, MethodCallContext context) {
				return _impl.Hello(request, context);
			}
		}
		
		public partial interface INeverLaunchGreetingServiceImpl:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloImpl
		{ }
		
		private sealed partial class NeverLaunchGreetingServiceBinder {
			
			public const string Alias = "NeverLaunchGreetingService";
			
			private readonly INeverLaunchGreetingServiceImpl _impl;
			
			public NeverLaunchGreetingServiceBinder(INeverLaunchGreetingServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Testing.Generated.GreetingService.Id, Alias, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse>(global::Plexus.Interop.Testing.Generated.GreetingService.HelloMethodId, _impl.Hello);
				return builder; 							
			}
		}
		
		public sealed partial class NeverLaunchGreetingServiceImpl: INeverLaunchGreetingServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse> _helloHandler;
			
			public NeverLaunchGreetingServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Testing.Generated.GreetingRequest, global::Plexus.Interop.Testing.Generated.GreetingResponse> helloHandler
			) {
				_helloHandler = helloHandler;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request, MethodCallContext context) {
				return _helloHandler(request, context);
			}
		}					
		
		public sealed partial class NeverLaunchGreetingServiceImpl<T>: INeverLaunchGreetingServiceImpl
			where T:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloImpl
		{
			private readonly T _impl;
			
			public NeverLaunchGreetingServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request, MethodCallContext context) {
				return _impl.Hello(request, context);
			}
		}
		
		public partial interface IEchoServiceProxy:
			global::Plexus.Interop.Testing.Generated.EchoService.IUnaryProxy,
			global::Plexus.Interop.Testing.Generated.EchoService.IServerStreamingProxy,
			global::Plexus.Interop.Testing.Generated.EchoService.IClientStreamingProxy,
			global::Plexus.Interop.Testing.Generated.EchoService.IDuplexStreamingProxy
		{ }
		
		public sealed partial class EchoServiceProxy: IEchoServiceProxy {
			
			public static global::Plexus.Interop.Testing.Generated.EchoService.Descriptor Descriptor = global::Plexus.Interop.Testing.Generated.EchoService.DefaultDescriptor;
			
			private readonly IClientCallInvoker _callInvoker;
									
			public EchoServiceProxy(IClientCallInvoker callInvoker) {
				_callInvoker = callInvoker;
			}						
			
			public IUnaryMethodCall<global::Plexus.Interop.Testing.Generated.EchoRequest> Unary(global::Plexus.Interop.Testing.Generated.EchoRequest request) {
				return _callInvoker.Call(Descriptor.UnaryMethod, request);
			}
			
			public IServerStreamingMethodCall<global::Plexus.Interop.Testing.Generated.EchoRequest> ServerStreaming(global::Plexus.Interop.Testing.Generated.EchoRequest request) {
				return _callInvoker.Call(Descriptor.ServerStreamingMethod, request);
			}
			
			public IClientStreamingMethodCall<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> ClientStreaming() {
				return _callInvoker.Call(Descriptor.ClientStreamingMethod);
			}
			
			public IDuplexStreamingMethodCall<global::Plexus.Interop.Testing.Generated.EchoRequest, global::Plexus.Interop.Testing.Generated.EchoRequest> DuplexStreaming() {
				return _callInvoker.Call(Descriptor.DuplexStreamingMethod);
			}
		}
		
		public IEchoServiceProxy EchoService { get; private set; }
		
		public partial interface IGreetingServiceProxy:
			global::Plexus.Interop.Testing.Generated.GreetingService.IHelloProxy
		{ }
		
		public sealed partial class GreetingServiceProxy: IGreetingServiceProxy {
			
			public static global::Plexus.Interop.Testing.Generated.GreetingService.Descriptor Descriptor = global::Plexus.Interop.Testing.Generated.GreetingService.DefaultDescriptor;
			
			private readonly IClientCallInvoker _callInvoker;
									
			public GreetingServiceProxy(IClientCallInvoker callInvoker) {
				_callInvoker = callInvoker;
			}						
			
			public IUnaryMethodCall<global::Plexus.Interop.Testing.Generated.GreetingResponse> Hello(global::Plexus.Interop.Testing.Generated.GreetingRequest request) {
				return _callInvoker.Call(Descriptor.HelloMethod, request);
			}
		}
		
		public IGreetingServiceProxy GreetingService { get; private set; }
	}
}
#endregion Designer generated code
