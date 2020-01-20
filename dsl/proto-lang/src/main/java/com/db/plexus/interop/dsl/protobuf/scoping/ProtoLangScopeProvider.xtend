/**
 * Copyright 2017-2020 Plexus Interop Deutsche Bank AG
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
/*
 * generated by Xtext 2.12.0
 */
package com.db.plexus.interop.dsl.protobuf.scoping

import com.db.plexus.interop.dsl.protobuf.ComplexFieldType
import com.db.plexus.interop.dsl.protobuf.DefaultFieldValue
import com.db.plexus.interop.dsl.protobuf.Enum
import com.db.plexus.interop.dsl.protobuf.EnumConstant
import com.db.plexus.interop.dsl.protobuf.EnumValue
import com.db.plexus.interop.dsl.protobuf.Extend
import com.db.plexus.interop.dsl.protobuf.Field
import com.db.plexus.interop.dsl.protobuf.Option
import com.db.plexus.interop.dsl.protobuf.ProtoLangImportResolver
import com.db.plexus.interop.dsl.protobuf.ProtoLangUtils
import com.db.plexus.interop.dsl.protobuf.ProtobufPackage
import com.google.inject.Inject
import org.eclipse.emf.ecore.EObject
import org.eclipse.emf.ecore.EReference
import org.eclipse.xtext.naming.IQualifiedNameProvider
import org.eclipse.xtext.naming.QualifiedName
import org.eclipse.xtext.resource.IResourceDescriptionsProvider
import org.eclipse.xtext.scoping.IScope
import org.eclipse.xtext.scoping.Scopes
import org.eclipse.xtext.scoping.impl.SimpleScope

/**
 * This class contains custom scoping description.
 * 
 * See https://www.eclipse.org/Xtext/documentation/303_runtime_concepts.html#scoping
 * on how and when to use it.
 */
class ProtoLangScopeProvider extends AbstractProtoLangScopeProvider {

	@Inject
	protected IResourceDescriptionsProvider resourceDescriptionsProvider

	@Inject
	protected ProtoLangImportResolver importResolver
	
	@Inject
	protected ProtoLangUtils utils
	
	@Inject
	protected IQualifiedNameProvider qualifiedNameProvider
	
	override getScope(EObject context, EReference reference) {

		if (context instanceof Option && reference == ProtobufPackage.Literals.OPTION__DESCRIPTOR) {
			val option = context as Option
			val optionDescriptorContainer = utils.getDescriptorsContainer(option)
			if (optionDescriptorContainer !== null) {
				if (option.isCustom) {
					val superScope = super.getScope(context, reference).allElements
					val extendFields = 
						superScope
							.filter[x | x.EClass.equals(ProtobufPackage.Literals.FIELD)]
							.filter[x | x.EObjectOrProxy.eContainer instanceof Extend]
							.filter[x | (x.EObjectOrProxy.eContainer as Extend).message.equals(optionDescriptorContainer)]
					return new SimpleScope(extendFields)
				} else {
					val optionDescriptors = optionDescriptorContainer.elements.filter(typeof(Field))
					return Scopes.scopeFor(optionDescriptors, [x|QualifiedName.create(x.name)], IScope.NULLSCOPE)
				}			
			}
		}

		if (context instanceof EnumConstant && reference == ProtobufPackage.Literals.ENUM_CONSTANT__VALUE) {
			val container = context.eContainer
			var descriptor = switch (container) {
				Option: container.descriptor
				DefaultFieldValue: container.eContainer as Field
			}
			if (descriptor.typeReference instanceof ComplexFieldType) {
				val typeRef = descriptor.typeReference as ComplexFieldType
				val type = typeRef.value
				if (type instanceof Enum) {
					val values = type.elements.filter(typeof(EnumValue))
					return Scopes.scopeFor(values, [x|QualifiedName.create(x.name)], IScope.NULLSCOPE)
				}
			}
		}
		
		return super.getScope(context, reference)
	}
}
