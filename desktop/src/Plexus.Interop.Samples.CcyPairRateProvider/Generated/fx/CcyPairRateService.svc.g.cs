/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// <auto-generated>
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: fx\ccy_pair_rate_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Samples.CcyPairRateProvider.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
	public static partial class CcyPairRateService {
		
		public const string Id = "fx.CcyPairRateService";			
		public const string GetRateMethodId = "GetRate";
		
		public static readonly CcyPairRateService.Descriptor DefaultDescriptor = CreateDescriptor();
		
		public static CcyPairRateService.Descriptor CreateDescriptor() {
			return new CcyPairRateService.Descriptor();
		} 
		
		public static CcyPairRateService.Descriptor CreateDescriptor(string alias) {
			return new CcyPairRateService.Descriptor(alias);
		}				
	
		public partial interface IGetRateProxy {
			IUnaryMethodCall<global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate> GetRate(global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair request);
		}
		
		public partial interface IGetRateImpl {
			Task<global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate> GetRate(global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair request, MethodCallContext context);
		}
		
		public sealed partial class Descriptor {
		
			public UnaryMethod<global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair, global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate> GetRateMethod {get; private set; }
			
			public Descriptor() {				
				GetRateMethod = Method.Unary<global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair, global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate>(Id, GetRateMethodId);
			}
		
			public Descriptor(string alias) {
				GetRateMethod = Method.Unary<global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair, global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate>(Id, alias, GetRateMethodId);
			}
		}
	}
					
}
#endregion Designer generated code
