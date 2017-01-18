<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="c095c90b-898d-4728-8b96-ab354e4b36f4" Description="Description for BotFrameworkDsl.BotFrameworkDsl" Name="BotFrameworkDsl" DisplayName="BotFrameworkDsl" Namespace="BotFrameworkDsl" ProductName="BotFrameworkDsl" CompanyName="James Mann" PackageGuid="b11c2986-8b42-4fa1-8f44-3dd353bca3e0" PackageNamespace="BotFrameworkDsl" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="5173e501-07c6-402a-ac38-aed9072ff8da" Description="The root in which all other elements are embedded. Appears as a diagram." Name="BotFrameworkModel" DisplayName="Bot Framework Model" Namespace="BotFrameworkDsl">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="Node" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>BotFrameworkModelHasElements.Elements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="3aa3b9cf-4307-4ef7-b3b2-9f0d5f80959b" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="Node" DisplayName="Node" InheritanceModifier="Abstract" Namespace="BotFrameworkDsl" />
    <DomainClass Id="6e9695db-637f-4c50-9a6b-46c6aa300ef1" Description="Description for BotFrameworkDsl.Start" Name="Start" DisplayName="Start" Namespace="BotFrameworkDsl">
      <BaseClass>
        <DomainClassMoniker Name="Node" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="a53459fa-3e00-497f-a42e-b47fab5d7bad" Description="Description for BotFrameworkDsl.Start.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="643a56d9-60cf-4ddf-8ea5-d92b585768f6" Description="Description for BotFrameworkDsl.Speak" Name="Speak" DisplayName="Speak" Namespace="BotFrameworkDsl">
      <BaseClass>
        <DomainClassMoniker Name="Node" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="c8234a11-4f23-4caf-84e9-5f19d8539b31" Description="Description for BotFrameworkDsl.Speak.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="ae7a8935-0d81-4360-b52b-d3277093a204" Description="Description for BotFrameworkDsl.Listen" Name="Listen" DisplayName="Listen" Namespace="BotFrameworkDsl">
      <BaseClass>
        <DomainClassMoniker Name="Node" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="3f958f4e-5721-4ee0-b4bc-5d0eb61b7e4b" Description="Description for BotFrameworkDsl.Listen.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="819f7208-a421-47b7-a363-2cb27f2979f3" Description="Description for BotFrameworkDsl.End" Name="End" DisplayName="End" Namespace="BotFrameworkDsl">
      <BaseClass>
        <DomainClassMoniker Name="Node" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="6b7a724c-0529-428c-8b53-00979a1c6eb7" Description="Description for BotFrameworkDsl.End.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="0d8feee7-826c-4774-83ac-61642a338bf0" Description="Embedding relationship between the Model and Elements" Name="BotFrameworkModelHasElements" DisplayName="Bot Framework Model Has Elements" Namespace="BotFrameworkDsl" IsEmbedding="true">
      <Source>
        <DomainRole Id="0a50e422-e318-4fb6-8955-f118918d899d" Description="" Name="BotFrameworkModel" DisplayName="Bot Framework Model" PropertyName="Elements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Elements">
          <RolePlayer>
            <DomainClassMoniker Name="BotFrameworkModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="daa2a83b-8434-4c3b-a79a-929ea49c6e9c" Description="" Name="Element" DisplayName="Element" PropertyName="BotFrameworkModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Bot Framework Model">
          <RolePlayer>
            <DomainClassMoniker Name="Node" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="9f4ec840-7741-417f-9352-4f4514347312" Description="Reference relationship between Elements." Name="NodeReferencesTargets" DisplayName="Node References Targets" Namespace="BotFrameworkDsl">
      <Source>
        <DomainRole Id="bb4de6d5-b01b-4fd7-bb18-e10655fddcaa" Description="Description for BotFrameworkDsl.ExampleRelationship.Target" Name="Source" DisplayName="Source" PropertyName="Targets" PropertyDisplayName="Targets">
          <RolePlayer>
            <DomainClassMoniker Name="Node" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="d7528946-07ed-43a8-94be-631a5c69dc4d" Description="Description for BotFrameworkDsl.ExampleRelationship.Source" Name="Target" DisplayName="Target" PropertyName="Sources" PropertyDisplayName="Sources">
          <RolePlayer>
            <DomainClassMoniker Name="Node" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <Shapes>
    <GeometryShape Id="a8826606-f000-4679-b574-560c0105cdc4" Description="Description for BotFrameworkDsl.StartShape" Name="StartShape" DisplayName="Start Shape" Namespace="BotFrameworkDsl" FixedTooltipText="Start Shape" InitialWidth="1" InitialHeight="1" FillGradientMode="None" Geometry="Circle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="be22d7b9-c915-471b-beee-09f71a03883b" Description="Description for BotFrameworkDsl.SpeakShape" Name="SpeakShape" DisplayName="Speak Shape" Namespace="BotFrameworkDsl" FixedTooltipText="Speak Shape" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="44f8a929-cc8c-41e1-a294-770b41441b2a" Description="Description for BotFrameworkDsl.ListenShape" Name="ListenShape" DisplayName="Listen Shape" Namespace="BotFrameworkDsl" FixedTooltipText="Listen Shape" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="332b3e0e-4023-45d6-bf72-bffa71154dfc" Description="Description for BotFrameworkDsl.EndShape" Name="EndShape" DisplayName="End Shape" Namespace="BotFrameworkDsl" FixedTooltipText="End Shape" TextColor="White" FillColor="Black" InitialHeight="1" Geometry="Circle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="92096b43-932e-4755-a98d-1d051a887ee3" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="ConversationFlow" DisplayName="Conversation Flow" Namespace="BotFrameworkDsl" FixedTooltipText="Conversation Flow" Color="113, 111, 110" TargetEndStyle="EmptyArrow" Thickness="0.01" />
  </Connectors>
  <XmlSerializationBehavior Name="BotFrameworkDslSerializationBehavior" Namespace="BotFrameworkDsl">
    <ClassData>
      <XmlClassData TypeName="BotFrameworkModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="botFrameworkModelMoniker" ElementName="botFrameworkModel" MonikerTypeName="BotFrameworkModelMoniker">
        <DomainClassMoniker Name="BotFrameworkModel" />
        <ElementData>
          <XmlRelationshipData RoleElementName="elements">
            <DomainRelationshipMoniker Name="BotFrameworkModelHasElements" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Node" MonikerAttributeName="" SerializeId="true" MonikerElementName="nodeMoniker" ElementName="node" MonikerTypeName="NodeMoniker">
        <DomainClassMoniker Name="Node" />
        <ElementData>
          <XmlRelationshipData RoleElementName="targets">
            <DomainRelationshipMoniker Name="NodeReferencesTargets" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="BotFrameworkModelHasElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="botFrameworkModelHasElementsMoniker" ElementName="botFrameworkModelHasElements" MonikerTypeName="BotFrameworkModelHasElementsMoniker">
        <DomainRelationshipMoniker Name="BotFrameworkModelHasElements" />
      </XmlClassData>
      <XmlClassData TypeName="NodeReferencesTargets" MonikerAttributeName="" SerializeId="true" MonikerElementName="nodeReferencesTargetsMoniker" ElementName="nodeReferencesTargets" MonikerTypeName="NodeReferencesTargetsMoniker">
        <DomainRelationshipMoniker Name="NodeReferencesTargets" />
      </XmlClassData>
      <XmlClassData TypeName="ConversationFlow" MonikerAttributeName="" SerializeId="true" MonikerElementName="conversationFlowMoniker" ElementName="conversationFlow" MonikerTypeName="ConversationFlowMoniker">
        <ConnectorMoniker Name="ConversationFlow" />
      </XmlClassData>
      <XmlClassData TypeName="BotFrameworkDslDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="botFrameworkDslDiagramMoniker" ElementName="botFrameworkDslDiagram" MonikerTypeName="BotFrameworkDslDiagramMoniker">
        <DiagramMoniker Name="BotFrameworkDslDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Start" MonikerAttributeName="" SerializeId="true" MonikerElementName="startMoniker" ElementName="start" MonikerTypeName="StartMoniker">
        <DomainClassMoniker Name="Start" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Start/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="StartShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="startShapeMoniker" ElementName="startShape" MonikerTypeName="StartShapeMoniker">
        <GeometryShapeMoniker Name="StartShape" />
      </XmlClassData>
      <XmlClassData TypeName="Speak" MonikerAttributeName="" SerializeId="true" MonikerElementName="speakMoniker" ElementName="speak" MonikerTypeName="SpeakMoniker">
        <DomainClassMoniker Name="Speak" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Speak/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="SpeakShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="speakShapeMoniker" ElementName="speakShape" MonikerTypeName="SpeakShapeMoniker">
        <GeometryShapeMoniker Name="SpeakShape" />
      </XmlClassData>
      <XmlClassData TypeName="Listen" MonikerAttributeName="name" SerializeId="true" MonikerElementName="listenMoniker" ElementName="listen" MonikerTypeName="ListenMoniker">
        <DomainClassMoniker Name="Listen" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="Listen/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ListenShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="listenShapeMoniker" ElementName="listenShape" MonikerTypeName="ListenShapeMoniker">
        <GeometryShapeMoniker Name="ListenShape" />
      </XmlClassData>
      <XmlClassData TypeName="End" MonikerAttributeName="name" SerializeId="true" MonikerElementName="endMoniker" ElementName="end" MonikerTypeName="EndMoniker">
        <DomainClassMoniker Name="End" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="End/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="EndShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="endShapeMoniker" ElementName="endShape" MonikerTypeName="EndShapeMoniker">
        <GeometryShapeMoniker Name="EndShape" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="BotFrameworkDslExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="NodeReferencesTargetsBuilder">
      <Notes>Provides for the creation of an ExampleRelationship by pointing at two ExampleElements.</Notes>
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="NodeReferencesTargets" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Node" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Node" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="8d40aa7b-f71d-4256-aa63-2f51c17b6350" Description="Description for BotFrameworkDsl.BotFrameworkDslDiagram" Name="BotFrameworkDslDiagram" DisplayName="Minimal Language Diagram" Namespace="BotFrameworkDsl">
    <Class>
      <DomainClassMoniker Name="BotFrameworkModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Start" />
        <ParentElementPath>
          <DomainPath>BotFrameworkModelHasElements.BotFrameworkModel/!BotFrameworkModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="StartShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Start/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="ListenShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Start/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="StartShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Speak" />
        <ParentElementPath>
          <DomainPath>BotFrameworkModelHasElements.BotFrameworkModel/!BotFrameworkModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="SpeakShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Speak/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="ListenShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Speak/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="StartShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Speak/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="SpeakShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="End" />
        <ParentElementPath>
          <DomainPath>BotFrameworkModelHasElements.BotFrameworkModel/!BotFrameworkModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="EndShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="End/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="StartShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="End/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="EndShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Listen" />
        <ParentElementPath>
          <DomainPath>BotFrameworkModelHasElements.BotFrameworkModel/!BotFrameworkModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="ListenShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Listen/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="StartShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Listen/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="ListenShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="ConversationFlow" />
        <DomainRelationshipMoniker Name="NodeReferencesTargets" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="botframeworkmodel" EditorGuid="12ab00b0-40fb-4c17-96e5-3c0a51bc9117">
    <RootClass>
      <DomainClassMoniker Name="BotFrameworkModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="BotFrameworkDslSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="BotFrameworkDsl">
      <ConnectionTool Name="ConversationFlow" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="ConversationFlow" Tooltip="Drag between ExampleElements to create an ExampleRelationship" HelpKeyword="ConnectExampleRelationF1Keyword">
        <ConnectionBuilderMoniker Name="BotFrameworkDsl/NodeReferencesTargetsBuilder" />
      </ConnectionTool>
      <ElementTool Name="Start" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Start" Tooltip="Start" HelpKeyword="Start">
        <DomainClassMoniker Name="Start" />
      </ElementTool>
      <ElementTool Name="End" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="End" Tooltip="End" HelpKeyword="End">
        <DomainClassMoniker Name="End" />
      </ElementTool>
      <ElementTool Name="Speak" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Speak" Tooltip="Speak" HelpKeyword="Speak">
        <DomainClassMoniker Name="Speak" />
      </ElementTool>
      <ElementTool Name="Listen" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Listen" Tooltip="Listen" HelpKeyword="Listen">
        <DomainClassMoniker Name="Listen" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="BotFrameworkDslDiagram" />
  </Designer>
  <Explorer ExplorerGuid="6149a85b-b05e-444c-99c2-d463c7c3455e" Title="BotFrameworkDsl Explorer">
    <ExplorerBehaviorMoniker Name="BotFrameworkDsl/BotFrameworkDslExplorer" />
  </Explorer>
</Dsl>