// ts2fable 0.0.0
module rec OfficeReact
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser


module __common_DirectionalHint =

    type [<RequireQualifiedAccess>] DirectionalHint =
        | TopLeftEdge = 0
        | TopCenter = 1
        | TopRightEdge = 2
        | TopAutoEdge = 3
        | BottomLeftEdge = 4
        | BottomCenter = 5
        | BottomRightEdge = 6
        | BottomAutoEdge = 7
        | LeftTopEdge = 8
        | LeftCenter = 9
        | LeftBottomEdge = 10
        | RightTopEdge = 11
        | RightCenter = 12
        | RightBottomEdge = 13

module __common_IAccessiblePopupProps =

    type [<AllowNullLiteral>] IAccessiblePopupProps =
        /// Sets the HTMLElement to focus on when exiting the FocusTrapZone.
        abstract elementToFocusOnDismiss: HTMLElement option with get, set
        /// Indicates if this dialog will ignore keeping track of HTMLElement that activated the Zone.
        abstract ignoreExternalFocusing: bool option with get, set
        /// Indicates whether dialog should force focus inside the focus trap zone
        abstract forceFocusInsideTrap: bool option with get, set
        /// Indicates the selector for first focusable item
        abstract firstFocusableSelector: U2<string, (unit -> string)> option with get, set
        /// Aria label on close button
        abstract closeButtonAriaLabel: string option with get, set
        /// Indicates if this dialog will allow clicks outside the FocusTrapZone
        abstract isClickableOutsideFocusTrap: bool option with get, set

module __common_shallowUntilTarget =
    type ShallowWrapper = Enzyme.ShallowWrapper

    type [<AllowNullLiteral>] IExports =
        /// An extention of enzyme's shallow function which will fail to work
        /// with decorated components and/or components using the styled() function.
        /// This function allows you to pass a 'target' component (e.g. ComponentBase)
        /// and keep running shallow on each child component till a match is found.
        abstract shallowUntilTarget: componentInstance: React.ReactElement<'P> * TargetComponent: string * ?options: IShallowUntilTarget -> ShallowWrapper

    /// Duplicated enzyme's ShallowRendererProps
    type [<AllowNullLiteral>] IShallowRendererProps =
        abstract lifecycleExperimental: bool option with get, set
        abstract disableLifecycleMethods: bool option with get, set

    /// ShallowUntilTarget Interface
    type [<AllowNullLiteral>] IShallowUntilTarget =
        abstract maxTries: float with get, set
        abstract shallowOptions: IShallowRendererProps with get, set

module __common_TestImages =

    type [<AllowNullLiteral>] IExports =
        abstract TestImages: obj

module __common_testUtilities =
    type ReactWrapper = Enzyme.ReactWrapper

    type [<AllowNullLiteral>] IExports =
        abstract findNodes: (ReactWrapper<obj option, obj option> -> string -> ReactWrapper<obj option, obj option>)
        abstract expectNodes: (ReactWrapper<obj option, obj option> -> string -> float -> unit)
        abstract expectOne: (ReactWrapper<obj option, obj option> -> string -> unit)
        abstract expectMissing: (ReactWrapper<obj option, obj option> -> string -> unit)

module __common__exampleStyles_scss =

    type [<AllowNullLiteral>] IExports =
        abstract exampleCheckbox: obj
        abstract exampleLabel: obj

module __demo_AppDefinition =
    type IAppDefinition = __demo_@uifabric_example_app_base.IAppDefinition
    type IAppProps = __demo_@uifabric_example_app_base.IAppProps

    type [<AllowNullLiteral>] IExports =
        abstract AppDefinition: IAppDefinition
        abstract App: (IAppProps -> JSX.Element)

module __demo_GettingStartedPage =

    type [<AllowNullLiteral>] IExports =
        abstract GettingStartedPage: GettingStartedPageStatic

    type [<AllowNullLiteral>] GettingStartedPage =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _getEditButton: unit -> unit

    type [<AllowNullLiteral>] GettingStartedPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GettingStartedPage

module __components_ActivityItem_ActivityItem_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ActivityItemStatus: obj

module __components_ActivityItem_ActivityItem_classNames =
    type IActivityItemStyles = __components_ActivityItem_ActivityItem_types.IActivityItemStyles
    type IPersonaProps = Persona.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract getClassNames: (IActivityItemStyles -> string -> ResizeArray<IPersonaProps> -> bool -> IActivityItemClassNames)

    type [<AllowNullLiteral>] IActivityItemClassNames =
        abstract root: string option with get, set
        abstract activityContent: string option with get, set
        abstract activityText: string option with get, set
        abstract personaContainer: string option with get, set
        abstract activityPersona: string option with get, set
        abstract activityTypeIcon: string option with get, set
        abstract commentText: string option with get, set
        abstract timeStamp: string option with get, set
        abstract pulsingBeacon: string option with get, set

module __components_ActivityItem_ActivityItem =
    type BaseComponent = Utilities.BaseComponent
    type IActivityItemProps = __components_ActivityItem_ActivityItem_types.IActivityItemProps

    type [<AllowNullLiteral>] IExports =
        abstract ActivityItem: ActivityItemStatic

    type [<AllowNullLiteral>] ActivityItem =
        inherit BaseComponent<IActivityItemProps, obj>
        abstract render: unit -> JSX.Element
        abstract _onRenderIcon: obj with get, set
        abstract _onRenderActivityDescription: obj with get, set
        abstract _onRenderComments: obj with get, set
        abstract _onRenderTimeStamp: obj with get, set
        abstract _onRenderPersonaArray: obj with get, set
        abstract _getClassNames: props: obj -> unit

    type [<AllowNullLiteral>] ActivityItemStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IActivityItemProps -> ActivityItem

module __components_ActivityItem_ActivityItem_styles =
    type ITheme = Styling.ITheme
    type IActivityItemStyles = __components_ActivityItem_ActivityItem_types.IActivityItemStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IActivityItemStyles option -> bool option -> string option -> string option -> bool option -> IActivityItemStyles)

module __components_ActivityItem_ActivityItem_types =
    type IStyle = Styling.IStyle
    type IRenderFunction = Utilities.IRenderFunction
    type IPersonaSharedProps = Persona.IPersonaSharedProps

    type [<AllowNullLiteral>] IActivityItemProps =
        inherit React.AllHTMLAttributes<HTMLElement>
        /// An element describing the activity that took place. If no activityDescription, activityDescriptionText, or onRenderActivityDescription are included, no description of the activity is shown.
        abstract activityDescription: U2<ResizeArray<React.ReactNode>, React.ReactNode> option with get, set
        /// Text describing the activity that occurred and naming the people involved in it. Deprecated, use activityDescription instead.
        abstract activityDescriptionText: string option with get, set
        /// An element containing an icon shown next to the activity item.
        abstract activityIcon: React.ReactNode option with get, set
        /// If activityIcon is not set, then the persona props in this array will be used as the icon for the this activity item.
        abstract activityPersonas: Array<IPersonaSharedProps> option with get, set
        /// An element containing the text of comments or @mention messages. If no comments, commentText, or onRenderComments are included, no comments are shown.
        abstract comments: U2<ResizeArray<React.ReactNode>, React.ReactNode> option with get, set
        /// Text of comments or @mention messages. Deprecated, use comments instead.
        abstract commentText: string option with get, set
        /// Gets ref to component interface.
        abstract componentRef: (unit -> unit) option with get, set
        /// Indicated if the compact styling should be used.
        abstract isCompact: bool option with get, set
        /// A renderer for the description of the current activity.
        abstract onRenderActivityDescription: IRenderFunction<IActivityItemProps> option with get, set
        /// A renderer that adds the text of a comment below the activity description.
        abstract onRenderComments: IRenderFunction<IActivityItemProps> option with get, set
        /// A renderer to create the icon next to the activity item.
        abstract onRenderIcon: IRenderFunction<IActivityItemProps> option with get, set
        /// A renderer adds a time stamp. If not included, timeStamp is shown as plain text below the activity.
        abstract onRenderTimeStamp: IRenderFunction<IActivityItemProps> option with get, set
        /// Optional styling for the elements within the Activity Item.
        abstract styles: IActivityItemStyles option with get, set
        /// Element shown as a timestamp on this activity. If not included, no timestamp is shown.
        abstract timeStamp: U3<string, ResizeArray<React.ReactNode>, React.ReactNode> option with get, set
        /// Beacon color one
        abstract beaconColorOne: string option with get, set
        /// Beacon color two
        abstract beaconColorTwo: string option with get, set
        /// Enables/Disables the beacon that radiates
        /// from the center of the center of the activity icon. Signals an activity has started.
        abstract animateBeaconSignal: bool option with get, set

    type [<AllowNullLiteral>] IActivityItemStyles =
        /// Styles applied to the root activity item container.
        abstract root: IStyle option with get, set
        /// Styles applied to the root activity item container.
        abstract pulsingBeacon: IStyle option with get, set
        /// Styles applied to the main container of the activity's description.
        abstract activityContent: IStyle option with get, set
        /// Styles applied to the persona of the user that did this activity.
        abstract activityPersona: IStyle option with get, set
        /// Styles applied to the activity's description.
        abstract activityText: IStyle option with get, set
        /// Styles applied to the icon indicating the type of the activity. Only shown when personas are unavailable.
        abstract activityTypeIcon: IStyle option with get, set
        /// Styles applied to the text of comments.
        abstract commentText: IStyle option with get, set
        /// Styles applied to personas when two users are involved in a single activity.
        abstract doublePersona: IStyle option with get, set
        /// Styles applied to root in the compact variant.
        abstract isCompactRoot: IStyle option with get, set
        /// Styles applied to personas and icons in the compact variant.
        abstract isCompactIcon: IStyle option with get, set
        /// Styles applied to main text container in the compact variant.
        abstract isCompactContent: IStyle option with get, set
        /// Styles applied to personas in the compact variant.
        abstract isCompactPersona: IStyle option with get, set
        /// Styles applied to a wrapper around personas in the compact variant.
        abstract isCompactPersonaContainer: IStyle option with get, set
        /// Styles applied to the container of the persona image or activity type icon.
        abstract personaContainer: IStyle option with get, set
        /// Styles applied to the timestamp at the end of each activity item.
        abstract timeStamp: IStyle option with get, set
        /// Styles applied to the timestamp in compact mode.
        /// This can occur if a host overrides the render behavior to force the timestamp to render.
        abstract isCompactTimeStamp: IStyle option with get, set

module __components_ActivityItem_ActivityItemPage =
    type IComponentDemoPageProps = __components_ActivityItem_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ActivityItemPage: ActivityItemPageStatic

    type [<AllowNullLiteral>] ActivityItemPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityItemPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ActivityItemPage

module __components_Autofill_Autofill =
    type IAutofillProps = __components_Autofill_Autofill_types.IAutofillProps
    type IAutofill = __components_Autofill_Autofill_types.IAutofill
    type BaseComponent = Utilities.BaseComponent
    type KeyCodes = Utilities.KeyCodes

    type [<AllowNullLiteral>] IExports =
        abstract Autofill: AutofillStatic
        abstract BaseAutoFill: BaseAutoFillStatic

    type [<AllowNullLiteral>] IAutofillState =
        abstract displayValue: string option with get, set

    type [<AllowNullLiteral>] Autofill =
        inherit BaseComponent<IAutofillProps, IAutofillState>
        inherit IAutofill
        abstract defaultProps: obj with get, set
        abstract _inputElement: obj with get, set
        abstract _autoFillEnabled: obj with get, set
        abstract _value: obj with get, set
        abstract cursorLocation: float option
        abstract isValueSelected: bool
        abstract value: string
        abstract selectionStart: float option
        abstract selectionEnd: float option
        abstract inputElement: HTMLInputElement option
        abstract componentWillReceiveProps: nextProps: IAutofillProps -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract clear: unit -> unit
        abstract _onCompositionStart: obj with get, set
        abstract _onCompositionEnd: obj with get, set
        abstract _onClick: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onInputChanged: obj with get, set
        abstract _onChanged: obj with get, set
        abstract _getCurrentInputValue: ?ev: obj -> unit
        /// <summary>Attempts to enable autofill. Whether or not autofill is enabled depends on the input value,
        /// whether or not any text is selected, and only if the new input value is longer than the old input value.
        /// Autofill should never be set to true if the value is composing. Once compositionEnd is called, then
        /// it should be completed.
        /// See https://developer.mozilla.org/en-US/docs/Web/API/CompositionEvent for more information on composition.</summary>
        /// <param name="newValue"></param>
        /// <param name="oldValue"></param>
        /// <param name="isComposing">if true then the text is actively being composed and it has not completed.</param>
        /// <param name="isComposed">if the text is a composed text value.</param>
        abstract _tryEnableAutofill: newValue: obj * oldValue: obj * ?isComposing: obj * ?isComposed: obj -> unit
        abstract _notifyInputChange: newValue: obj -> unit
        /// Updates the current input value as well as getting a new display value.
        abstract _updateValue: obj with get, set
        /// <summary>Returns a string that should be used as the display value.
        /// It evaluates this based on whether or not the suggested value starts with the input value
        /// and whether or not autofill is enabled.</summary>
        /// <param name="inputValue">the value that the input currently has.</param>
        /// <param name="suggestedDisplayValue">the possible full value</param>
        abstract _getDisplayValue: inputValue: obj * ?suggestedDisplayValue: obj -> unit
        abstract _doesTextStartWith: text: obj * startWith: obj -> unit

    type [<AllowNullLiteral>] AutofillStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IAutofillProps -> Autofill

    /// Legacy, @deprecated, do not use.
    type [<AllowNullLiteral>] BaseAutoFill =
        inherit Autofill

    /// Legacy, @deprecated, do not use.
    type [<AllowNullLiteral>] BaseAutoFillStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BaseAutoFill

module __components_Autofill_Autofill_types =
    type Autofill = __components_Autofill_Autofill.Autofill
    type KeyCodes = Utilities.KeyCodes

    type [<AllowNullLiteral>] IAutofill =
        /// The current index of the cursor in the input area. Returns -1 if the input element
        /// is not ready.
        abstract cursorLocation: float option with get, set
        /// A boolean for whether or not there is a value selected in the input area.
        abstract isValueSelected: bool with get, set
        /// The current text value that the user has entered.
        abstract value: string with get, set
        /// The current index of where the selection starts. Returns -1 if the input element
        /// is not ready.
        abstract selectionStart: float option with get, set
        /// the current index of where the selection ends. Returns -1 if the input element
        /// is not ready.
        abstract selectionEnd: float option with get, set
        /// The current input element.
        abstract inputElement: HTMLInputElement option with get, set
        /// Focus the input element.
        abstract focus: unit -> unit
        /// Clear all text in the input. Sets value to '';
        abstract clear: unit -> unit

    type [<AllowNullLiteral>] IAutofillProps =
        inherit React.InputHTMLAttributes<U2<HTMLInputElement, Autofill>>
        /// Gets the compoonent ref.
        abstract componentRef: (IAutofill option -> unit) option with get, set
        /// The suggested autofill value that will display.
        abstract suggestedDisplayValue: string option with get, set
        /// A callback for when the current input value changes.
        abstract onInputValueChange: (string -> unit) option with get, set
        /// When the user uses left arrow, right arrow, clicks, or deletes text autofill is disabled
        /// Since the user has taken control. It is automatically reenabled when the user enters text and the
        /// cursor is at the end of the text in the input box. This specifies other key presses that will reenabled
        /// autofill.
        abstract enableAutofillOnKeyPress: ResizeArray<KeyCodes> option with get, set
        /// The default value to be visible. This is different from placeholder
        /// because it actually sets the current value of the picker
        /// Note: This will only be set upon component creation
        /// and will not update with subsequent prop updates.
        abstract defaultVisibleValue: string option with get, set
        /// Handler for checking and updating the value if needed
        /// in componentWillReceiveProps
        abstract updateValueInWillReceiveProps: (unit -> string option) option with get, set
        /// Handler for checking if the full value of the input should
        /// be seleced in componentDidUpdate
        abstract shouldSelectFullInputValueInComponentDidUpdate: (unit -> bool) option with get, set
        /// A callback used to modify the input string.
        abstract onInputChange: (string -> string) option with get, set

    type [<AllowNullLiteral>] IBaseAutoFill =
        inherit IAutofill

    type [<AllowNullLiteral>] IBaseAutoFillProps =
        inherit IAutofillProps

module __components_Breadcrumb_Breadcrumb_base =
    type BaseComponent = Utilities.BaseComponent
    type IBreadcrumbProps = __components_Breadcrumb_Breadcrumb_types.IBreadcrumbProps
    type IBreadcrumbItem = __components_Breadcrumb_Breadcrumb_types.IBreadcrumbItem

    type [<AllowNullLiteral>] IExports =
        abstract BreadcrumbBase: BreadcrumbBaseStatic

    type [<AllowNullLiteral>] IBreadCrumbData =
        abstract props: IBreadcrumbProps with get, set
        abstract renderedItems: ResizeArray<IBreadcrumbItem> with get, set
        abstract renderedOverflowItems: ResizeArray<IBreadcrumbItem> with get, set

    type [<AllowNullLiteral>] BreadcrumbBase =
        inherit BaseComponent<IBreadcrumbProps, obj option>
        abstract defaultProps: IBreadcrumbProps with get, set
        abstract _classNames: obj with get, set
        abstract _focusZone: obj with get, set
        /// Sets focus to the first breadcrumb link.
        abstract focus: unit -> unit
        abstract render: unit -> JSX.Element
        abstract componentWillReceiveProps: nextProps: IBreadcrumbProps -> unit
        abstract _onReduceData: obj with get, set
        abstract _onRenderBreadcrumb: obj with get, set
        abstract _onRenderItem: obj with get, set
        abstract _onBreadcrumbClicked: obj with get, set
        /// <summary>Validate incoming props</summary>
        /// <param name="props">Props to validate</param>
        abstract _validateProps: props: obj -> unit

    type [<AllowNullLiteral>] BreadcrumbBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IBreadcrumbProps -> BreadcrumbBase

module __components_Breadcrumb_Breadcrumb_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract BreadcrumbStatus: obj

module __components_Breadcrumb_Breadcrumb =
    type IBreadcrumbProps = __components_Breadcrumb_Breadcrumb_types.IBreadcrumbProps

    type [<AllowNullLiteral>] IExports =
        abstract Breadcrumb: (IBreadcrumbProps -> JSX.Element)

module __components_Breadcrumb_Breadcrumb_styles =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IBreadcrumbStyleProps -> IBreadcrumbStyles)

    type [<AllowNullLiteral>] IBreadcrumbStyleProps =
        abstract className: string option with get, set
        abstract theme: ITheme with get, set

    type [<AllowNullLiteral>] IBreadcrumbStyles =
        abstract root: IStyle with get, set
        abstract list: IStyle with get, set
        abstract listItem: IStyle with get, set
        abstract chevron: IStyle with get, set
        abstract overflow: IStyle with get, set
        abstract overflowButton: IStyle with get, set
        abstract itemLink: IStyle with get, set
        abstract item: IStyle with get, set

module __components_Breadcrumb_Breadcrumb_types =
    type BreadcrumbBase = __components_Breadcrumb_Breadcrumb_base.BreadcrumbBase
    type IBreadCrumbData = __components_Breadcrumb_Breadcrumb_base.IBreadCrumbData
    type IIconProps = __components_Icon.IIconProps
    type IRenderFunction = Utilities.IRenderFunction
    type IStyleFunction = Utilities.IStyleFunction
    type IComponentAs = Utilities.IComponentAs
    type IBreadcrumbStyleProps = __components_Breadcrumb_Breadcrumb_styles.IBreadcrumbStyleProps
    type IBreadcrumbStyles = __components_Breadcrumb_Breadcrumb_styles.IBreadcrumbStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IBreadcrumb =
        /// Sets focus to the first breadcrumb link.
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] IBreadcrumbProps =
        inherit React.Props<BreadcrumbBase>
        /// Optional callback to access the IBreadcrumb interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IBreadcrumb option -> unit) option with get, set
        /// Collection of breadcrumbs to render
        abstract items: ResizeArray<IBreadcrumbItem> with get, set
        /// Optional root classname for the root breadcrumb element.
        abstract className: string option with get, set
        /// Render a custom divider in place of the default chevron '>'
        abstract dividerAs: IComponentAs<IDividerAsProps> option with get, set
        /// The maximum number of breadcrumbs to display before coalescing.
        /// If not specified, all breadcrumbs will be rendered.
        abstract maxDisplayedItems: float option with get, set
        /// Method to call when trying to render an item. 
        abstract onRenderItem: IRenderFunction<IBreadcrumbItem> option with get, set
        /// Method to call when reducing the length of the breadcrumb.
        /// Return undefined to never reduce breadcrumb length
        abstract onReduceData: (IBreadCrumbData -> IBreadCrumbData option) option with get, set
        /// Aria label to place on the navigation landmark for breadcrumb
        abstract ariaLabel: string option with get, set
        /// Optional name to use for aria label on overflow button.
        abstract overflowAriaLabel: string option with get, set
        /// Optional index where overflow items will be collapsed. Defaults to 0.
        abstract overflowIndex: float option with get, set
        abstract getStyles: IStyleFunction<IBreadcrumbStyleProps, IBreadcrumbStyles> option with get, set
        abstract theme: ITheme option with get, set

    type [<AllowNullLiteral>] IBreadcrumbItem =
        /// Text to display to the user for the breadcrumb
        abstract text: string with get, set
        /// Arbitrary unique string associated with the breadcrumb
        abstract key: string with get, set
        /// Callback issued when the breadcrumb is selected.
        abstract onClick: (React.MouseEvent<HTMLElement> -> IBreadcrumbItem -> unit) option with get, set
        /// Url to navigate to when this breadcrumb is clicked.
        abstract href: string option with get, set
        /// If this breadcrumb item is the item the user is currently on, if set to true, aria-current="page" will be applied to this breadcrumb link
        abstract isCurrentItem: bool option with get, set

    type [<AllowNullLiteral>] IDividerAsProps =
        inherit IIconProps
        /// Optional breadcrumb item corresponds to left of the divider to be passed for custom rendering.
        /// For overflowed items, it will be last item in the list
        abstract item: IBreadcrumbItem option with get, set

module __components_Breadcrumb_BreadcrumbPage =
    type IComponentDemoPageProps = __components_Breadcrumb_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract BreadcrumbPage: BreadcrumbPageStatic

    type [<AllowNullLiteral>] BreadcrumbPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] BreadcrumbPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BreadcrumbPage

module __components_Button_BaseButton_classNames =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles

    type [<AllowNullLiteral>] IExports =
        abstract getBaseButtonClassNames: (IButtonStyles -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames)

    type [<AllowNullLiteral>] IButtonClassNames =
        abstract root: string option with get, set
        abstract flexContainer: string option with get, set
        abstract textContainer: string option with get, set
        abstract icon: string option with get, set
        abstract label: string option with get, set
        abstract menuIcon: string option with get, set
        abstract description: string option with get, set
        abstract screenReaderText: string option with get, set

module __components_Button_BaseButton =
    type BaseComponent = Utilities.BaseComponent
    type IContextualMenuProps = ContextualMenu.IContextualMenuProps
    type IButtonProps = __components_Button_Button_types.IButtonProps
    type IButton = __components_Button_Button_types.IButton

    type [<AllowNullLiteral>] IExports =
        abstract BaseButton: BaseButtonStatic

    type [<AllowNullLiteral>] IBaseButtonProps =
        inherit IButtonProps
        abstract baseClassName: string option with get, set
        abstract variantClassName: string option with get, set

    type [<AllowNullLiteral>] IBaseButtonState =
        abstract menuProps: IContextualMenuProps option with get, set

    type [<AllowNullLiteral>] BaseButton =
        inherit BaseComponent<IBaseButtonProps, IBaseButtonState>
        inherit IButton
        abstract _isSplitButton: obj
        abstract _isExpanded: obj
        abstract defaultProps: obj with get, set
        abstract _buttonElement: obj with get, set
        abstract _splitButtonContainer: obj with get, set
        abstract _labelId: obj with get, set
        abstract _descriptionId: obj with get, set
        abstract _ariaDescriptionId: obj with get, set
        abstract _classNames: obj with get, set
        abstract _processingTouch: obj with get, set
        abstract _lastTouchTimeoutId: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: prevProps: IBaseButtonProps * prevState: IBaseButtonState -> unit
        abstract focus: unit -> unit
        abstract dismissMenu: unit -> unit
        abstract openMenu: unit -> unit
        abstract _onRenderContent: tag: obj * buttonProps: obj -> unit
        abstract _onRenderIcon: obj with get, set
        abstract _onRenderTextContents: obj with get, set
        abstract _onRenderText: obj with get, set
        abstract _hasText: unit -> unit
        abstract _onRenderChildren: obj with get, set
        abstract _onRenderDescription: obj with get, set
        abstract _onRenderAriaDescription: obj with get, set
        abstract _onRenderMenuIcon: obj with get, set
        abstract _onRenderMenu: obj with get, set
        abstract _dismissMenu: obj with get, set
        abstract _openMenu: obj with get, set
        abstract _onToggleMenu: obj with get, set
        abstract _onRenderSplitButtonContent: tag: obj * buttonProps: obj -> unit
        abstract _onSplitButtonPrimaryClick: obj with get, set
        abstract _onRenderSplitButtonDivider: classNames: obj -> unit
        abstract _onRenderSplitButtonMenuButton: classNames: obj * keytipAttributes: obj -> unit
        abstract _onMouseDown: obj with get, set
        abstract _onSplitButtonContainerKeyDown: obj with get, set
        abstract _onMenuKeyDown: obj with get, set
        abstract _onTouchStart: obj with get, set
        abstract _onPointerDown: ev: obj -> unit
        abstract _handleTouchAndPointerEvent: unit -> unit
        /// <summary>Returns if the user hits a valid keyboard key to open the menu</summary>
        /// <param name="ev">- the keyboard event</param>
        abstract _isValidMenuOpenKey: ev: obj -> unit
        abstract _onMenuClick: obj with get, set

    type [<AllowNullLiteral>] BaseButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IBaseButtonProps * rootClassName: string -> BaseButton

module __components_Button_BaseButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles)

module __components_Button_Button_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ButtonStatus: obj

module __components_Button_Button =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract Button: ButtonStatic

    /// This class is deprecated. Use the individual *Button components instead.
    type [<AllowNullLiteral>] Button =
        inherit BaseComponent<IButtonProps, obj>
        /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    /// This class is deprecated. Use the individual *Button components instead.
    type [<AllowNullLiteral>] ButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> Button

module __components_Button_Button_types =
    type BaseButton = __components_Button_BaseButton.BaseButton
    type Button = __components_Button_Button.Button
    type IButtonClassNames = __components_Button_BaseButton_classNames.IButtonClassNames
    type ISplitButtonClassNames = __components_Button_SplitButton_SplitButton_classNames.ISplitButtonClassNames
    type IRenderFunction = Utilities.IRenderFunction
    type KeyCodes = Utilities.KeyCodes
    type IContextualMenuProps = ContextualMenu.IContextualMenuProps
    type IIconProps = Icon.IIconProps
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IButton =
        /// Sets focus to the button.
        abstract focus: (unit -> unit) with get, set
        /// If there is a menu associated with this button and it is visible, this will dismiss the menu
        abstract dismissMenu: (unit -> unit) with get, set
        /// If there is a menu associated with this button and it is visible, this will open the menu
        abstract openMenu: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IButtonProps =
        inherit React.AllHTMLAttributes<U5<HTMLAnchorElement, HTMLButtonElement, HTMLDivElement, BaseButton, Button>>
        /// Optional callback to access the IButton interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IButton option -> unit) option with get, set
        /// If provided, this component will be rendered as an anchor.
        abstract href: string option with get, set
        /// Changes the visual presentation of the button to be emphasized (if defined)
        abstract primary: bool option with get, set
        /// Unique id to identify the item. Typically a duplicate of key value.
        abstract uniqueId: U2<string, float> option with get, set
        /// Whether the button is disabled
        abstract disabled: bool option with get, set
        /// If set to true and if this is a splitButton (split == true) then the primary action of a split button is disabled.
        abstract primaryDisabled: bool option with get, set
        /// Custom styling for individual elements within the button DOM.
        abstract styles: IButtonStyles option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Whether the button is checked
        abstract ``checked``: bool option with get, set
        /// If provided, additional class name to provide on the root element.
        abstract className: string option with get, set
        /// The aria label of the button for the benefit of screen readers.
        abstract ariaLabel: string option with get, set
        /// Detailed description of the button for the benefit of screen readers.
        /// 
        /// Besides the compound button, other button types will need more information provided to screen reader.
        abstract ariaDescription: string option with get, set
        /// If provided and is true it adds an 'aria-hidden' attribute instructing screen readers to ignore the element.
        abstract ariaHidden: bool option with get, set
        /// Text to render button label. If text is supplied, it will override any string in button children. Other children components will be passed through after the text.
        abstract text: string option with get, set
        /// The props for the icon shown in the button.
        abstract iconProps: IIconProps option with get, set
        /// Props for button menu. Providing this will default to showing the menu icon. See menuIconProps for overriding
        /// how the default icon looks. Providing this in addition of onClick and setting the split property to true will render a SplitButton.
        abstract menuProps: IContextualMenuProps option with get, set
        /// Callback that runs after Button's contextualmenu was closed (removed from the DOM)
        abstract onAfterMenuDismiss: (unit -> unit) option with get, set
        /// If set to true, and if menuProps and onClick are provided, the button will render as a SplitButton. Defaults to false.
        abstract split: bool option with get, set
        /// The props for the icon shown when providing a menu dropdown.
        abstract menuIconProps: IIconProps option with get, set
        /// Accessible label for the dropdown chevron button if this button is split.
        abstract splitButtonAriaLabel: string option with get, set
        /// Optional callback when menu is clicked.
        abstract onMenuClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IButtonProps -> unit) option with get, set
        /// Custom render function for the icon
        abstract onRenderIcon: IRenderFunction<IButtonProps> option with get, set
        /// Custom render function for the label text.
        abstract onRenderText: IRenderFunction<IButtonProps> option with get, set
        /// Custom render function for the desciption text.
        abstract onRenderDescription: IRenderFunction<IButtonProps> option with get, set
        /// Custom render function for the aria description element.
        abstract onRenderAriaDescription: IRenderFunction<IButtonProps> option with get, set
        /// Custom render function for rendering the button children.
        abstract onRenderChildren: IRenderFunction<IButtonProps> option with get, set
        /// Custom render function for button menu icon
        abstract onRenderMenuIcon: IRenderFunction<IButtonProps> option with get, set
        /// Custom render function for button menu
        abstract onRenderMenu: IRenderFunction<IContextualMenuProps> option with get, set
        /// Description of the action this button takes.
        /// Only used for compound buttons
        abstract secondaryText: string option with get, set
        /// Deprecated at v1.2.3, to be removed at >= v2.0.0. Use specific button component instead
        abstract buttonType: ButtonType option with get, set
        /// Deprecated at v0.56.2, to be removed at >= v1.0.0. Just pass in button props instead;
        /// they will be mixed into the button/anchor element rendered by the component.
        abstract rootProps: U2<React.ButtonHTMLAttributes<HTMLButtonElement>, React.AnchorHTMLAttributes<HTMLAnchorElement>> option with get, set
        /// Any custom data the developer wishes to associate with the menu item.
        abstract toggled: bool option with get, set
        /// Any custom data the developer wishes to associate with the menu item.
        abstract data: obj option with get, set
        /// Method to provide the classnames to style a button.
        /// The default value for this prop is the getClassnames func
        /// defined in BaseButton.classnames.
        abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
        /// Method to provide the classnames to style a button.
        /// The default value for this prop is the getClassnames func
        /// defined in BaseButton.classnames.
        abstract getSplitButtonClassNames: (bool -> bool -> bool -> ISplitButtonClassNames) option with get, set
        /// Provides a custom KeyCode that can be used to open the button menu.
        /// The default KeyCode is the down arrow. A value of null can be provided to disable the key codes for opening the button menu.
        abstract menuTriggerKeyCode: KeyCodes option with get, set
        /// Optional keytip for this button
        abstract keytipProps: IKeytipProps option with get, set
        /// Menu will not be created or destroyed when opened or closed, instead it
        /// will be hidden. This will improve perf of the menu opening but could potentially
        /// impact overall perf by having more elemnts in the dom. Should only be used
        /// when perf is important.
        /// Note: This may increase the amount of time it takes for the button itself to mount.
        abstract persistMenu: bool option with get, set
        /// Style for the description text if applicable (for compound buttons.)
        abstract description: IStyle option with get, set

    type [<RequireQualifiedAccess>] ElementType =
        | Button = 0
        | Anchor = 1

    type [<RequireQualifiedAccess>] ButtonType =
        | Normal = 0
        | Primary = 1
        | Hero = 2
        | Compound = 3
        | Command = 4
        | Icon = 5
        | Default = 6

    type [<AllowNullLiteral>] IButtonStyles =
        /// Style for the root element in the default enabled, non-toggled state.
        abstract root: IStyle option with get, set
        /// Style override for the root element in a checked state, layered on top of the root style.
        abstract rootChecked: IStyle option with get, set
        /// Style override for the root element in a disabled state, layered on top of the root style.
        abstract rootDisabled: IStyle option with get, set
        /// Style override applied to the root on hover in the default, enabled, non-toggled state.
        abstract rootHovered: IStyle option with get, set
        /// Style override applied to the root on hover in the default, enabled, non-toggled state.
        abstract rootFocused: IStyle option with get, set
        /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
        abstract rootPressed: IStyle option with get, set
        /// Style override applied to the root on when menu is expanded in the default, enabled, non-toggled state.
        abstract rootExpanded: IStyle option with get, set
        /// Style override applied to the root on hover in a checked, enabled state
        abstract rootCheckedHovered: IStyle option with get, set
        /// Style override applied to the root on pressed in a checked, enabled state
        abstract rootCheckedPressed: IStyle option with get, set
        /// Style override applied to the root on hover in a checked, disabled state
        abstract rootCheckedDisabled: IStyle option with get, set
        /// Style override applied to the root on hover in a expanded state on hover
        abstract rootExpandedHovered: IStyle option with get, set
        /// Style for the flexbox container within the root element.
        abstract flexContainer: IStyle option with get, set
        /// Style for the text container within the flexbox container element (and contains the text and description).
        abstract textContainer: IStyle option with get, set
        /// Style for the icon on the near side of the label.
        abstract icon: IStyle option with get, set
        /// Style for the icon on the near side of the label on hover.
        abstract iconHovered: IStyle option with get, set
        /// Style for the icon on the near side of the label when pressed.
        abstract iconPressed: IStyle option with get, set
        /// Style for the icon on the near side of the label when expanded.
        abstract iconExpanded: IStyle option with get, set
        /// Style for the icon on the near side of the label when expanded and hovered.
        abstract iconExpandedHovered: IStyle option with get, set
        /// Style override for the icon when the button is disabled.
        abstract iconDisabled: IStyle option with get, set
        /// Style override for the icon when the button is checked.
        abstract iconChecked: IStyle option with get, set
        /// Style for the text content of the button.
        abstract label: IStyle option with get, set
        /// Style override for the text content when the button is disabled.
        abstract labelDisabled: IStyle option with get, set
        /// Style override for the text content when the button is checked.
        abstract labelChecked: IStyle option with get, set
        /// Style for the menu chevron.
        abstract menuIcon: IStyle option with get, set
        /// Style for the menu chevron on hover.
        abstract menuIconHovered: IStyle option with get, set
        /// Style for the menu chevron when pressed.
        abstract menuIconPressed: IStyle option with get, set
        /// Style for the menu chevron when expanded.
        abstract menuIconExpanded: IStyle option with get, set
        /// Style for the menu chevron when expanded and hovered.
        abstract menuIconExpandedHovered: IStyle option with get, set
        /// Style override for the menu chevron when the button is disabled.
        abstract menuIconDisabled: IStyle option with get, set
        /// Style override for the menu chevron when the button is checked.
        abstract menuIconChecked: IStyle option with get, set
        /// Style for the description text if applicable (for compound buttons.)
        abstract description: IStyle option with get, set
        /// Style for the description text if applicable (for compound buttons.)
        abstract secondaryText: IStyle option with get, set
        /// Style override for the description text when the button is hovered.
        abstract descriptionHovered: IStyle option with get, set
        /// Style for the description text when the button is pressed.
        abstract descriptionPressed: IStyle option with get, set
        /// Style override for the description text when the button is disabled.
        abstract descriptionDisabled: IStyle option with get, set
        /// Style override for the description text when the button is checked.
        abstract descriptionChecked: IStyle option with get, set
        /// Style override for the screen reader text.
        abstract screenReaderText: IStyle option with get, set
        /// Style override for the container div around a SplitButton element
        abstract splitButtonContainer: IStyle option with get, set
        /// Style for container div around a SplitButton element when the button is hovered.
        abstract splitButtonContainerHovered: IStyle option with get, set
        /// Style for container div around a SplitButton element when the button is focused.
        abstract splitButtonContainerFocused: IStyle option with get, set
        /// Style for container div around a SplitButton element when the button is checked.
        abstract splitButtonContainerChecked: IStyle option with get, set
        /// Style for container div around a SplitButton element when the button is checked and hovered.
        abstract splitButtonContainerCheckedHovered: IStyle option with get, set
        /// Style override for the container div around a SplitButton element in a disabled state
        abstract splitButtonContainerDisabled: IStyle option with get, set
        /// Style override for the divider element that appears between the button and menu button
        /// for a split button.
        abstract splitButtonDivider: IStyle option with get, set
        /// Style override for the SplitButton menu button
        abstract splitButtonMenuButton: IStyle option with get, set
        /// Style override for the SplitButton menu button element in a disabled state.
        abstract splitButtonMenuButtonDisabled: IStyle option with get, set
        /// Style override for the SplitButton menu button element in a checked state
        abstract splitButtonMenuButtonChecked: IStyle option with get, set
        /// Style override for the SplitButton menu button element in an expanded state
        abstract splitButtonMenuButtonExpanded: IStyle option with get, set
        /// Style override for the SplitButton menu icon element
        abstract splitButtonMenuIcon: IStyle option with get, set
        /// Style override for the SplitButton menu icon element in a disabled state
        abstract splitButtonMenuIconDisabled: IStyle option with get, set
        /// Style override for the SplitButton FlexContainer.
        abstract splitButtonFlexContainer: IStyle option with get, set

module __components_Button_ButtonPage =
    type IComponentDemoPageProps = __components_Button_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonPage: ButtonPageStatic

    type [<AllowNullLiteral>] IButtonDemoPageState =
        abstract areButtonsDisabled: bool option with get, set
        abstract areButtonsChecked: bool option with get, set

    type [<AllowNullLiteral>] ButtonPage =
        inherit React.Component<IComponentDemoPageProps, IButtonDemoPageState>
        abstract render: unit -> JSX.Element
        abstract _onDisabledChanged: ev: obj * disabled: obj -> unit
        abstract _onToggledChanged: ev: obj * toggled: obj -> unit

    type [<AllowNullLiteral>] ButtonPageStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IComponentDemoPageProps -> ButtonPage

module __components_Button_ButtonThemes =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract standardStyles: theme: ITheme -> IButtonStyles
        abstract primaryStyles: theme: ITheme -> IButtonStyles

module __components_Calendar_Calendar_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract CalendarStatus: obj

module __components_Calendar_Calendar =
    type ICalendar = __components_Calendar_Calendar_types.ICalendar
    type ICalendarProps = __components_Calendar_Calendar_types.ICalendarProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract Calendar: CalendarStatic

    type [<AllowNullLiteral>] ICalendarState =
        /// The currently focused date in the day picker, but not necessarily selected 
        abstract navigatedDayDate: DateTime option with get, set
        /// The currently focused date in the month picker, but not necessarily selected 
        abstract navigatedMonthDate: DateTime option with get, set
        /// The currently selected date in the calendar 
        abstract selectedDate: DateTime option with get, set
        /// State used to show/hide month picker 
        abstract isMonthPickerVisible: bool option with get, set
        /// State used to show/hide day picker 
        abstract isDayPickerVisible: bool option with get, set

    type [<AllowNullLiteral>] Calendar =
        inherit BaseComponent<ICalendarProps, ICalendarState>
        inherit ICalendar
        abstract defaultProps: ICalendarProps with get, set
        abstract _dayPicker: obj with get, set
        abstract _monthPicker: obj with get, set
        abstract _focusOnUpdate: obj with get, set
        abstract componentWillReceiveProps: nextProps: ICalendarProps -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _navigateDayPickerDay: obj with get, set
        abstract _navigateMonthPickerDay: obj with get, set
        abstract _onNavigateDayDate: obj with get, set
        abstract _onNavigateMonthDate: obj with get, set
        abstract _onSelectDate: obj with get, set
        abstract _onHeaderSelect: obj with get, set
        abstract _onGotoToday: obj with get, set
        abstract _onGotoTodayKeyDown: obj with get, set
        abstract _onDatePickerPopupKeyDown: obj with get, set
        abstract _handleEscKey: obj with get, set

    type [<AllowNullLiteral>] CalendarStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalendarProps -> Calendar

module __components_Calendar_Calendar_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract picker: obj
        abstract holder: obj
        abstract pickerIsOpened: obj
        abstract frame: obj
        abstract wrap: obj
        abstract goTodaySpacing: obj
        abstract dayPicker: obj
        abstract header: obj
        abstract divider: obj
        abstract monthAndYear: obj
        abstract year: obj
        abstract currentYear: obj
        abstract table: obj
        abstract dayWrapper: obj
        abstract weekday: obj
        abstract day: obj
        abstract dayIsToday: obj
        abstract dayIsDisabled: obj
        abstract dayIsUnfocused: obj
        abstract dayIsFocused: obj
        abstract dayIsHighlighted: obj
        abstract pickerIsFocused: obj
        abstract dayDisabled: obj
        abstract dayBackground: obj
        abstract dayHover: obj
        abstract dayPress: obj
        abstract weekBackground: obj
        abstract showWeekNumbers: obj
        abstract weekNumbers: obj
        abstract weekIsHighlighted: obj
        abstract showWeekNumbersRTL: obj
        abstract monthComponents: obj
        abstract yearComponents: obj
        abstract decadeComponents: obj
        abstract prevMonth: obj
        abstract nextMonth: obj
        abstract prevYear: obj
        abstract nextYear: obj
        abstract prevDecade: obj
        abstract nextDecade: obj
        abstract prevMonthIsDisabled: obj
        abstract nextMonthIsDisabled: obj
        abstract prevYearIsDisabled: obj
        abstract nextYearIsDisabled: obj
        abstract prevDecadeIsDisabled: obj
        abstract nextDecadeIsDisabled: obj
        abstract headerToggleView: obj
        abstract currentDecade: obj
        abstract optionGrid: obj
        abstract monthOption: obj
        abstract yearOption: obj
        abstract isHighlighted: obj
        abstract monthOptionIsDisabled: obj
        abstract yearOptionIsDisabled: obj
        abstract goToday: obj
        abstract goTodayInlineMonth: obj
        abstract isPickingYears: obj
        abstract monthPicker: obj
        abstract yearPicker: obj
        abstract monthPickerVisible: obj
        abstract toggleMonthView: obj
        abstract calendarsInline: obj
        abstract monthPickerOnly: obj
        abstract monthPickerAsOverlay: obj
        abstract holderWithButton: obj
        abstract monthIsHighlighted: obj
        abstract monthIsCurrentMonth: obj
        abstract topLeftCornerDate: obj
        abstract topRightCornerDate: obj
        abstract bottomLeftCornerDate: obj
        abstract bottomRightCornerDate: obj

module __components_Calendar_Calendar_types =
    type Calendar = __components_Calendar_Calendar.Calendar
    type DayOfWeek = __utilities_dateValues_DateValues.DayOfWeek
    type FirstWeekOfYear = __utilities_dateValues_DateValues.FirstWeekOfYear
    type DateRangeType = __utilities_dateValues_DateValues.DateRangeType

    type [<AllowNullLiteral>] ICalendar =
        /// Sets focus to the selected date. 
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] ICalendarProps =
        inherit React.Props<Calendar>
        /// Optional callback to access the ICalendar interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ICalendar option -> unit) option with get, set
        /// Optional class name to add to the root element.
        abstract className: string option with get, set
        /// Callback issued when a date is selected
        abstract onSelectDate: (DateTime -> ResizeArray<DateTime> -> unit) option with get, set
        /// Callback issued when calendar is closed
        abstract onDismiss: (unit -> unit) option with get, set
        /// Whether the month picker is shown beside the day picker or hidden.
        abstract isMonthPickerVisible: bool option with get, set
        /// Whether the day picker is shown beside the month picker or hidden.
        abstract isDayPickerVisible: bool option with get, set
        /// Show month picker on top of date picker when visible.
        abstract showMonthPickerAsOverlay: bool option with get, set
        /// Value of today. If null, current time in client machine will be used.
        abstract today: DateTime option with get, set
        /// Default value of the Calendar, if any
        abstract value: DateTime option with get, set
        /// The first day of the week for your locale.
        abstract firstDayOfWeek: DayOfWeek option with get, set
        /// The date range type indicating how  many days should be selected as the user
        /// selects days
        abstract dateRangeType: DateRangeType option with get, set
        /// Whether the month view should automatically navigate to the next or previous date range
        /// depending on the selected date. If this property is set to true and the currently displayed
        /// month is March 2017, if the user clicks on a day outside the month, i.e., April 1st, the
        /// picker will automatically navigate to the month of April.
        abstract autoNavigateOnSelection: bool option with get, set
        /// Whether the "Go to today" link should be shown or not
        abstract showGoToToday: bool option with get, set
        /// This property has been removed at 0.80.0 in place of the focus method, to be removed @ 1.0.0.
        abstract shouldFocusOnMount: bool option with get, set
        /// Localized strings to use in the Calendar
        abstract strings: ICalendarStrings option with get, set
        /// Whether the month picker should highlight the current month
        abstract highlightCurrentMonth: bool option with get, set
        /// Whether the month picker should highlight the selected month
        abstract highlightSelectedMonth: bool option with get, set
        /// Customize navigation icons using ICalendarIconStrings
        abstract navigationIcons: ICalendarIconStrings option with get, set
        /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
        abstract showWeekNumbers: bool option with get, set
        /// Defines when the first week of the year should start, FirstWeekOfYear.FirstDay,
        /// FirstWeekOfYear.FirstFullWeek or FirstWeekOfYear.FirstFourDayWeek are the possible values
        abstract firstWeekOfYear: FirstWeekOfYear option with get, set
        /// Apply additional formating to dates, for example localized date formatting.
        abstract dateTimeFormatter: ICalendarFormatDateCallbacks option with get, set
        /// If set the Calendar will not allow navigation to or selection of a date earlier than this value.
        abstract minDate: DateTime option with get, set
        /// If set the Calendar will not allow navigation to or selection of a date later than this value.
        abstract maxDate: DateTime option with get, set
        /// Whether the calendar should show 6 weeks by default.
        abstract showSixWeeksByDefault: bool option with get, set
        /// The days that are selectable when dateRangeType is WorkWeek. If dateRangeType is not WorkWeek this property does nothing.
        abstract workWeekDays: ResizeArray<DayOfWeek> option with get, set

    type [<AllowNullLiteral>] ICalendarStrings =
        /// An array of strings for the full names of months.
        /// The array is 0-based, so months[0] should be the full name of January.
        abstract months: ResizeArray<string> with get, set
        /// An array of strings for the short names of months.
        /// The array is 0-based, so shortMonths[0] should be the short name of January.
        abstract shortMonths: ResizeArray<string> with get, set
        /// An array of strings for the full names of days of the week.
        /// The array is 0-based, so days[0] should be the full name of Sunday.
        abstract days: ResizeArray<string> with get, set
        /// An array of strings for the initials of the days of the week.
        /// The array is 0-based, so days[0] should be the initial of Sunday.
        abstract shortDays: ResizeArray<string> with get, set
        /// String to render for button to direct the user to today's date.
        abstract goToToday: string with get, set
        /// Aria-label for the "previous month" button.
        abstract prevMonthAriaLabel: string option with get, set
        /// Aria-label for the "next month" button.
        abstract nextMonthAriaLabel: string option with get, set
        /// Aria-label for the "previous year" button.
        abstract prevYearAriaLabel: string option with get, set
        /// Aria-label for the "next year" button.
        abstract nextYearAriaLabel: string option with get, set
        /// Aria-label format string for the week number header. Should have 1 string param e.g. "week number {0}"
        abstract weekNumberFormatString: string option with get, set

    type [<AllowNullLiteral>] ICalendarIconStrings =
        /// FabricMDL2Icons name for the left navigation icon.  Previous default: ChevronLeft.
        abstract leftNavigation: string option with get, set
        /// FabricMDL2Icons name for the right navigation icon.  Previous default: ChevronRight.
        abstract rightNavigation: string option with get, set

    type [<AllowNullLiteral>] ICalendarFormatDateCallbacks =
        /// Callback to apply formatting to mmmm d, yyyy formated dates
        abstract formatMonthDayYear: (DateTime -> ICalendarStrings -> string) with get, set
        /// Callback to apply formatting to the month and year in the Day Picker header
        abstract formatMonthYear: (DateTime -> ICalendarStrings -> string) with get, set
        /// Callback to apply formatting to the days in the Day Picker calendar
        abstract formatDay: (DateTime -> string) with get, set
        /// Callback to apply formatting to the year in the Month Picker header
        abstract formatYear: (DateTime -> string) with get, set

module __components_Calendar_CalendarDay =
    type BaseComponent = Utilities.BaseComponent
    type ICalendarStrings = __components_Calendar_Calendar_types.ICalendarStrings
    type ICalendarIconStrings = __components_Calendar_Calendar_types.ICalendarIconStrings
    type ICalendarFormatDateCallbacks = __components_Calendar_Calendar_types.ICalendarFormatDateCallbacks
    type DayOfWeek = __utilities_dateValues_DateValues.DayOfWeek
    type FirstWeekOfYear = __utilities_dateValues_DateValues.FirstWeekOfYear
    type DateRangeType = __utilities_dateValues_DateValues.DateRangeType

    type [<AllowNullLiteral>] IExports =
        abstract CalendarDay: CalendarDayStatic

    type [<AllowNullLiteral>] IDayInfo =
        abstract key: string with get, set
        abstract date: string with get, set
        abstract originalDate: DateTime with get, set
        abstract isInMonth: bool with get, set
        abstract isToday: bool with get, set
        abstract isSelected: bool with get, set
        abstract isInBounds: bool with get, set
        abstract onSelected: (unit -> unit) with get, set

    type [<AllowNullLiteral>] ICalendarDay =
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ICalendarDayProps =
        inherit React.Props<CalendarDay>
        abstract componentRef: (ICalendarDay -> unit) option with get, set
        abstract strings: ICalendarStrings with get, set
        abstract selectedDate: DateTime with get, set
        abstract navigatedDate: DateTime with get, set
        abstract onSelectDate: (DateTime -> ResizeArray<DateTime> -> unit) with get, set
        abstract onNavigateDate: (DateTime -> bool -> unit) with get, set
        abstract onDismiss: (unit -> unit) option with get, set
        abstract firstDayOfWeek: DayOfWeek with get, set
        abstract dateRangeType: DateRangeType with get, set
        abstract autoNavigateOnSelection: bool with get, set
        abstract navigationIcons: ICalendarIconStrings with get, set
        abstract today: DateTime option with get, set
        abstract onHeaderSelect: (bool -> unit) option with get, set
        abstract showWeekNumbers: bool option with get, set
        abstract firstWeekOfYear: FirstWeekOfYear with get, set
        abstract dateTimeFormatter: ICalendarFormatDateCallbacks with get, set
        abstract showSixWeeksByDefault: bool option with get, set
        abstract minDate: DateTime option with get, set
        abstract maxDate: DateTime option with get, set
        abstract workWeekDays: ResizeArray<DayOfWeek> option with get, set

    type [<AllowNullLiteral>] ICalendarDayState =
        abstract activeDescendantId: string option with get, set
        abstract weeks: ResizeArray<ResizeArray<IDayInfo>> option with get, set

    type [<AllowNullLiteral>] CalendarDay =
        inherit BaseComponent<ICalendarDayProps, ICalendarDayState>
        abstract navigatedDay: obj with get, set
        abstract days: obj with get, set
        abstract componentWillReceiveProps: nextProps: ICalendarDayProps -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _setDayRef: element: obj * day: obj * isNavigatedDate: obj -> unit
        abstract _setDayCellRef: element: obj * day: obj * isNavigatedDate: obj -> unit
        abstract _getWeekCornerStyles: weeks: obj * dateRangeType: obj -> unit
        abstract _getHighlightedCornerStyle: weekCorners: obj * dayIndex: obj * weekIndex: obj -> unit
        abstract _navigateMonthEdge: ev: obj * date: obj * weekIndex: obj * dayIndex: obj -> unit
        abstract _onKeyDown: obj with get, set
        abstract _onDayKeyDown: obj with get, set
        abstract _onDayMouseDown: obj with get, set
        abstract _onDayMouseUp: obj with get, set
        abstract _onDayMouseOver: obj with get, set
        abstract _onDayMouseLeave: obj with get, set
        abstract _onTableMouseLeave: obj with get, set
        abstract _onTableMouseUp: obj with get, set
        abstract _applyFunctionToDayRefs: func: obj -> unit
        abstract _onSelectDate: obj with get, set
        abstract _onSelectNextMonth: obj with get, set
        abstract _onSelectPrevMonth: obj with get, set
        abstract _onHeaderSelect: obj with get, set
        abstract _onHeaderKeyDown: obj with get, set
        abstract _onPrevMonthKeyDown: obj with get, set
        abstract _onNextMonthKeyDown: obj with get, set
        abstract _getWeeks: propsToUse: obj -> unit
        abstract _getBoundedDateRange: dateRange: obj * ?minDate: obj * ?maxDate: obj -> unit

    type [<AllowNullLiteral>] CalendarDayStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalendarDayProps -> CalendarDay

module __components_Calendar_CalendarMonth =
    type BaseComponent = Utilities.BaseComponent
    type ICalendarStrings = __components_Calendar_Calendar_types.ICalendarStrings
    type ICalendarIconStrings = __components_Calendar_Calendar_types.ICalendarIconStrings
    type ICalendarFormatDateCallbacks = __components_Calendar_Calendar_types.ICalendarFormatDateCallbacks

    type [<AllowNullLiteral>] IExports =
        abstract CalendarMonth: CalendarMonthStatic

    type [<AllowNullLiteral>] ICalendarMonth =
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ICalendarMonthProps =
        inherit React.Props<CalendarMonth>
        abstract componentRef: (ICalendarMonth -> unit) option with get, set
        abstract navigatedDate: DateTime with get, set
        abstract selectedDate: DateTime with get, set
        abstract strings: ICalendarStrings with get, set
        abstract onNavigateDate: (DateTime -> bool -> unit) with get, set
        abstract today: DateTime option with get, set
        abstract highlightCurrentMonth: bool with get, set
        abstract highlightSelectedMonth: bool with get, set
        abstract onHeaderSelect: (bool -> unit) option with get, set
        abstract navigationIcons: ICalendarIconStrings with get, set
        abstract dateTimeFormatter: ICalendarFormatDateCallbacks with get, set
        abstract minDate: DateTime option with get, set
        abstract maxDate: DateTime option with get, set

    type [<AllowNullLiteral>] CalendarMonth =
        inherit BaseComponent<ICalendarMonthProps, obj>
        abstract refs: obj with get, set
        abstract _selectMonthCallbacks: obj with get, set
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _isCurrentMonth: month: obj * year: obj * today: obj -> unit
        abstract _onKeyDown: obj with get, set
        abstract _onSelectNextYear: obj with get, set
        abstract _onSelectNextYearKeyDown: obj with get, set
        abstract _onSelectPrevYear: obj with get, set
        abstract _onSelectPrevYearKeyDown: obj with get, set
        abstract _onSelectMonthKeyDown: obj with get, set
        abstract _onSelectMonth: obj with get, set
        abstract _onHeaderSelect: obj with get, set
        abstract _onHeaderKeyDown: obj with get, set

    type [<AllowNullLiteral>] CalendarMonthStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalendarMonthProps -> CalendarMonth

module __components_Calendar_CalendarPage =
    type IComponentDemoPageProps = __components_Calendar_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract CalendarPage: CalendarPageStatic

    type [<AllowNullLiteral>] CalendarPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CalendarPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CalendarPage

module __components_Callout_Callout_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract CalloutStatus: obj

module __components_Callout_Callout =
    type BaseComponent = Utilities.BaseComponent
    type ICalloutProps = __components_Callout_Callout_types.ICalloutProps
    type ICalloutState = __components_Callout_CalloutContent_base.ICalloutState

    type [<AllowNullLiteral>] IExports =
        abstract Callout: CalloutStatic

    type [<AllowNullLiteral>] Callout =
        inherit BaseComponent<ICalloutProps, ICalloutState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CalloutStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalloutProps -> Callout

module __components_Callout_Callout_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type IPoint = Utilities.IPoint
    type IRectangle = Utilities.IRectangle
    type ICalloutPositionedInfo = __utilities_positioning.ICalloutPositionedInfo
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] ICallout =
        interface end

    type [<AllowNullLiteral>] ICalloutProps =
        /// Optional callback to access the ICallout interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ICallout option -> unit) option with get, set
        /// The target that the Callout should try to position itself based on.
        /// It can be either an Element a querySelector string of a valid Element
        /// or a MouseEvent. If MouseEvent is given then the origin point of the event will be used.
        abstract target: U4<Element, string, MouseEvent, IPoint> option with get, set
        /// How the element should be positioned
        abstract directionalHint: DirectionalHint option with get, set
        /// How the element should be positioned in RTL layouts.
        /// If not specified, a mirror of `directionalHint` will be used instead
        abstract directionalHintForRTL: DirectionalHint option with get, set
        /// The gap between the Callout and the target
        abstract gapSpace: float option with get, set
        /// The width of the beak.
        abstract beakWidth: float option with get, set
        /// Custom width for callout including borders. If value is 0, no width is applied.
        abstract calloutWidth: float option with get, set
        /// The background color of the Callout in hex format ie. #ffffff.
        abstract backgroundColor: string option with get, set
        /// The bounding rectangle for which  the contextual menu can appear in.
        abstract bounds: IRectangle option with get, set
        /// The minimum distance the callout will be away from the edge of the screen.
        ///   
        abstract minPagePadding: float option with get, set
        /// If true use a point rather than rectangle to position the Callout.
        /// For example it can be used to position based on a click.
        abstract useTargetPoint: bool option with get, set
        /// Point used to position the Callout
        abstract targetPoint: IPoint option with get, set
        /// If true then the beak is visible. If false it will not be shown.
        abstract isBeakVisible: bool option with get, set
        /// If true then the onClose will not not dismiss on scroll
        abstract preventDismissOnScroll: bool option with get, set
        /// If true the position returned will have the menu element cover the target.
        /// If false then it will position next to the target;
        abstract coverTarget: bool option with get, set
        /// Aria role assigned to the callout (Eg. dialog, alertdialog).
        abstract role: string option with get, set
        /// Accessible label text for callout.
        abstract ariaLabel: string option with get, set
        /// Defines the element id referencing the element containing label text for callout.
        abstract ariaLabelledBy: string option with get, set
        /// Defines the element id referencing the element containing the description for the callout.
        abstract ariaDescribedBy: string option with get, set
        /// CSS class to apply to the callout.
        abstract className: string option with get, set
        /// Optional callback when the layer content has mounted.
        abstract onLayerMounted: (unit -> unit) option with get, set
        /// Optional callback that is called once the callout has been correctly positioned.
        abstract onPositioned: (ICalloutPositionedInfo -> unit) option with get, set
        /// Callback when the Callout tries to close.
        abstract onDismiss: (obj option -> unit) option with get, set
        /// If true do not render on a new layer. If false render on a new layer.
        abstract doNotLayer: bool option with get, set
        /// If true the position will not change sides in an attempt to fit the callout within bounds.
        /// It will still attempt to align it to whatever bounds are given.
        abstract directionalHintFixed: bool option with get, set
        /// Specify the final height of the content.
        /// To be used when expanding the content dynamically so that callout can adjust its position.
        abstract finalHeight: float option with get, set
        /// If true then the callout will attempt to focus the first focusable element that it contains.
        /// If it doesn't find an element, no focus will be set and the method will return false.
        /// This means that it's the contents responsibility to either set focus or have
        /// focusable items.
        abstract setInitialFocus: bool option with get, set
        /// Deprecated at v0.59.1, to be removed at >= v1.0.0. Pass in a beakWidth to dictate size.
        abstract beakStyle: string option with get, set
        /// Set max height of callout
        /// When not set the callout will expand with contents up to the bottom of the screen
        abstract calloutMaxHeight: float option with get, set
        /// Callback when the Callout body is scrolled.
        abstract onScroll: (unit -> unit) option with get, set
        /// Optional theme for component
        abstract theme: ITheme option with get, set
        /// Optional styles for the component.
        abstract getStyles: IStyleFunction<ICalloutContentStyleProps, ICalloutContentStyles> option with get, set
        /// If specified, renders the Callout in a hidden state.
        /// Use this flag, rather than rendering a callout conditionally based on visibility,
        /// to improve rendering performance when it becomes visible.
        /// Note: When callout is hidden its content will not be rendered. It will only render
        /// once the callout is visible.
        abstract hidden: bool option with get, set

    type [<AllowNullLiteral>] ICalloutContentStyleProps =
        /// Theme to apply to the calloutContent.
        abstract theme: ITheme with get, set
        /// Width for callout including borders.
        abstract calloutWidth: float option with get, set
        /// CSS class to apply to the callout.
        abstract className: string option with get, set
        /// Callout positioning data
        abstract positions: ICalloutPositionedInfo option with get, set
        /// Whether or not to clip content of the callout,
        /// if it overflows vertically.
        abstract overflowYHidden: bool option with get, set
        abstract contentMaxHeight: float option with get, set
        /// Background color for the beak and callout.
        abstract backgroundColor: string option with get, set
        /// Width of Callout beak
        abstract beakWidth: float option with get, set
        /// Deprecated at v0.59.1, to be removed at >= v1.0.0. Pass in a beakWidth to dictate size.
        abstract beakStyle: string option with get, set

    type [<AllowNullLiteral>] ICalloutContentStyles =
        /// Style for wrapper of Callout component.
        abstract container: IStyle with get, set
        /// Style for callout container root element.
        abstract root: IStyle with get, set
        /// Style for callout beak.
        abstract beak: IStyle with get, set
        /// Style for callout beak curtain.
        abstract beakCurtain: IStyle with get, set
        /// Style for content component of the callout.
        abstract calloutMain: IStyle with get, set

module __components_Callout_CalloutContent_base =
    type ICalloutProps = __components_Callout_Callout_types.ICalloutProps
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type BaseComponent = Utilities.BaseComponent
    type ICalloutPositionedInfo = __utilities_positioning.ICalloutPositionedInfo

    type [<AllowNullLiteral>] IExports =
        abstract CalloutContentBase: CalloutContentBaseStatic

    type [<AllowNullLiteral>] ICalloutState =
        abstract positions: ICalloutPositionedInfo option with get, set
        abstract slideDirectionalClassName: string option with get, set
        abstract calloutElementRect: ClientRect option with get, set
        abstract heightOffset: float option with get, set

    type [<AllowNullLiteral>] CalloutContentBase =
        inherit BaseComponent<ICalloutProps, ICalloutState>
        abstract defaultProps: obj with get, set
        abstract _classNames: obj with get, set
        abstract _didSetInitialFocus: obj with get, set
        abstract _hostElement: obj with get, set
        abstract _calloutElement: obj with get, set
        abstract _targetWindow: obj with get, set
        abstract _bounds: obj with get, set
        abstract _positionAttempts: obj with get, set
        abstract _target: obj with get, set
        abstract _setHeightOffsetTimer: obj with get, set
        abstract _hasListeners: obj with get, set
        abstract _maxHeight: obj with get, set
        abstract componentDidUpdate: unit -> unit
        abstract componentWillMount: unit -> unit
        abstract componentWillUpdate: newProps: ICalloutProps -> unit
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element option
        abstract dismiss: (U3<Event, React.KeyboardEvent<HTMLElement>, React.MouseEvent<HTMLElement>> option -> unit) with get, set
        abstract _dismissOnScroll: ev: Event -> unit
        abstract _dismissOnLostFocus: ev: Event -> unit
        abstract _setInitialFocus: (unit -> unit) with get, set
        abstract _onComponentDidMount: (unit -> unit) with get, set
        abstract _addListeners: unit -> unit
        abstract _removeListeners: unit -> unit
        abstract _updateAsyncPosition: unit -> unit
        abstract _getBeakPosition: unit -> unit
        abstract _updatePosition: unit -> unit
        abstract _getBounds: unit -> unit
        abstract _getMaxHeight: unit -> unit
        abstract _arePositionsEqual: positions: obj * newPosition: obj -> unit
        abstract _comparePositions: oldPositions: obj * newPositions: obj -> unit
        abstract _setTargetWindowAndElement: target: obj -> unit
        abstract _setHeightOffsetEveryFrame: unit -> unit
        abstract _getTarget: ?props: obj -> unit

    type [<AllowNullLiteral>] CalloutContentBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalloutProps -> CalloutContentBase

module __components_Callout_CalloutContent =
    type ICalloutProps = __components_Callout_Callout_types.ICalloutProps

    type [<AllowNullLiteral>] IExports =
        abstract CalloutContent: (ICalloutProps -> JSX.Element)

module __components_Callout_CalloutContent_styles =
    type ICalloutContentStyleProps = __components_Callout_Callout_types.ICalloutContentStyleProps
    type ICalloutContentStyles = __components_Callout_Callout_types.ICalloutContentStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ICalloutContentStyleProps -> ICalloutContentStyles)

module __components_Callout_CalloutPage =
    type IComponentDemoPageProps = __components_Callout_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract CalloutPage: CalloutPageStatic

    type [<AllowNullLiteral>] CalloutPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CalloutPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CalloutPage

module __components_Check_Check_base =
    type BaseComponent = Utilities.BaseComponent
    type ICheckProps = __components_Check_Check_types.ICheckProps

    type [<AllowNullLiteral>] IExports =
        abstract CheckBase: CheckBaseStatic

    type [<AllowNullLiteral>] CheckBase =
        inherit BaseComponent<ICheckProps, obj>
        abstract defaultProps: ICheckProps with get, set
        abstract shouldComponentUpdate: newProps: ICheckProps -> bool
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CheckBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CheckBase

module __components_Check_Check =
    type ICheckProps = __components_Check_Check_types.ICheckProps

    type [<AllowNullLiteral>] IExports =
        abstract Check: (ICheckProps -> JSX.Element)

module __components_Check_Check_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract rootIsChecked: obj
        abstract check: obj
        abstract checkHost: obj
        abstract circle: obj

module __components_Check_Check_styles =
    type ICheckStyleProps = __components_Check_Check_types.ICheckStyleProps
    type ICheckStyles = __components_Check_Check_types.ICheckStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ICheckStyleProps -> ICheckStyles)

module __components_Check_Check_types =
    type CheckBase = __components_Check_Check_base.CheckBase
    type IStyle = __components_Check_@uifabric_styling.IStyle
    type ITheme = __components_Check_@uifabric_styling.ITheme
    type IStyleFunction = __components_Check_@uifabric_utilities.IStyleFunction

    type [<AllowNullLiteral>] ICheckProps =
        inherit React.Props<CheckBase>
        /// Gets the component ref.
        abstract componentRef: (ICheckProps option -> unit) option with get, set
        /// Whether or not this menu item is currently checked.
        abstract ``checked``: bool option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<ICheckStyleProps, ICheckStyles> option with get, set
        /// Flag to always show the check icon. Not currently working.
        abstract alwaysShowCheck: bool option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Check
        abstract className: string option with get, set

    type [<AllowNullLiteral>] ICheckStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// Accept custom checkBox size in pixels.
        abstract checkBoxHeight: string option with get, set
        abstract ``checked``: bool option with get, set

    type [<AllowNullLiteral>] ICheckStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set
        /// The 'check' icon styles.
        abstract check: IStyle with get, set
        /// The 'circle' icon styles.
        abstract circle: IStyle with get, set

module __components_Checkbox_Checkbox_base =
    type BaseComponent = Utilities.BaseComponent
    type ICheckbox = __components_Checkbox_Checkbox_types.ICheckbox
    type ICheckboxProps = __components_Checkbox_Checkbox_types.ICheckboxProps

    type [<AllowNullLiteral>] IExports =
        abstract Checkbox: CheckboxStatic

    type [<AllowNullLiteral>] ICheckboxState =
        /// Is true when Uncontrolled control is checked. 
        abstract isChecked: bool option with get, set

    type [<AllowNullLiteral>] Checkbox =
        inherit BaseComponent<ICheckboxProps, ICheckboxState>
        inherit ICheckbox
        abstract defaultProps: ICheckboxProps with get, set
        abstract _checkBox: obj with get, set
        abstract _id: obj with get, set
        abstract _classNames: obj with get, set
        abstract componentWillReceiveProps: newProps: ICheckboxProps -> unit
        /// Render the Checkbox based on passed props
        abstract render: unit -> JSX.Element
        abstract ``checked``: bool
        abstract focus: unit -> unit
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onClick: obj with get, set
        abstract _onRenderLabel: obj with get, set

    type [<AllowNullLiteral>] CheckboxStatic =
        /// <summary>Initialize a new instance of the TopHeaderV2</summary>
        /// <param name="props">Props for the component</param>
        /// <param name="context">Context or initial state for the base component.</param>
        [<Emit "new $0($1...)">] abstract Create: props: ICheckboxProps * ?context: obj option -> Checkbox

module __components_Checkbox_Checkbox_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract CheckboxStatus: obj

module __components_Checkbox_Checkbox_classNames =
    type ICheckboxStyles = __components_Checkbox_Checkbox_types.ICheckboxStyles

    type [<AllowNullLiteral>] IExports =
        abstract getClassNames: (ICheckboxStyles -> bool -> bool -> bool -> string option -> ICheckboxClassNames)

    type [<AllowNullLiteral>] ICheckboxClassNames =
        abstract root: string with get, set
        abstract label: string with get, set
        abstract checkbox: string with get, set
        abstract checkmark: string with get, set
        abstract text: string with get, set

module __components_Checkbox_Checkbox_styles =
    type ICheckboxStyles = __components_Checkbox_Checkbox_types.ICheckboxStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> ICheckboxStyles option -> ICheckboxStyles)

module __components_Checkbox_Checkbox_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IRenderFunction = Utilities.IRenderFunction
    type IIconProps = __components_Icon_Icon_types.IIconProps
    type ICheckboxClassNames = __components_Checkbox_Checkbox_classNames.ICheckboxClassNames
    type IKeytipProps = Keytip.IKeytipProps

    /// Checkbox class interface.
    type [<AllowNullLiteral>] ICheckbox =
        /// Gets the current checked state. 
        abstract ``checked``: bool with get, set
        /// Sets focus to the checkbox. 
        abstract focus: (unit -> unit) with get, set

    /// Checkbox properties.
    type [<AllowNullLiteral>] ICheckboxProps =
        inherit React.ButtonHTMLAttributes<U2<HTMLElement, HTMLInputElement>>
        /// Optional callback to access the ICheckbox interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ICheckbox option -> unit) option with get, set
        /// Additional class name to provide on the root element, in addition to the ms-Checkbox class.
        abstract className: string option with get, set
        /// Checked state. Mutually exclusive to "defaultChecked". Use this if you control the checked state at a higher
        /// level and plan to pass in the correct value based on handling onChange events and re-rendering.
        abstract ``checked``: bool option with get, set
        /// Default checked state. Mutually exclusive to "checked". Use this if you want an uncontrolled component, and
        /// want the Checkbox instance to maintain its own state.
        abstract defaultChecked: bool option with get, set
        /// Label to display next to the checkbox.
        abstract label: string option with get, set
        /// Disabled state of the checkbox.
        abstract disabled: bool option with get, set
        /// Callback that is called when the checked value has changed.
        abstract onChange: (React.FormEvent<U2<HTMLElement, HTMLInputElement>> -> bool -> unit) option with get, set
        /// Optional input props that will be mixed into the input element, *before* other props are applied. This allows
        /// you to extend the input element with additional attributes, such as data-automation-id needed for automation.
        /// Note that if you provide, for example, "disabled" as well as "inputProps.disabled", the former will take
        /// precedence over the later.
        abstract inputProps: React.ButtonHTMLAttributes<U2<HTMLElement, HTMLButtonElement>> option with get, set
        /// Allows you to set the checkbox to be at the before (start) or after (end) the label.
        abstract boxSide: U2<string, string> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Accessible label for the checkbox.
        abstract ariaLabel: string option with get, set
        /// ID for element that contains label information for the checkbox.
        abstract ariaLabelledBy: string option with get, set
        /// ID for element that provides extended information for the checkbox.
        abstract ariaDescribedBy: string option with get, set
        /// The position in the parent set (if in a set) for aria-posinset.
        abstract ariaPositionInSet: float option with get, set
        /// The total size of the parent set (if in a set) for aria-setsize.
        abstract ariaSetSize: float option with get, set
        /// Custom styles for this component
        abstract styles: ICheckboxStyles option with get, set
        /// Custom function for providing the classNames for the checkbox. Can be used to provide
        /// all styles for the component instead of applying them on top of the default styles.
        abstract getClassNames: (ITheme -> bool -> bool -> bool -> string -> ICheckboxClassNames) option with get, set
        /// Custom render function for the label.
        abstract onRenderLabel: IRenderFunction<ICheckboxProps> option with get, set
        /// Custom icon props for the check mark rendered by the checkbox
        abstract checkmarkIconProps: IIconProps option with get, set
        /// Optional keytip for this checkbox
        abstract keytipProps: IKeytipProps option with get, set

    type [<AllowNullLiteral>] ICheckboxStyles =
        /// Style for the root element (a button) of the checkbox component in the default enabled/unchecked state.
        abstract root: IStyle option with get, set
        /// Style for the label part (contains the customized checkbox + text) when enabled.
        abstract label: IStyle option with get, set
        /// Style for the label when reversed
        abstract labelReversed: IStyle option with get, set
        /// Style override for the label part when disabled.
        abstract labelDisabled: IStyle option with get, set
        /// Style for checkbox in its default unchecked/enabled state.
        abstract checkbox: IStyle option with get, set
        /// Style override for checkbox when enabled/unchecked/hovered.
        abstract checkboxHovered: IStyle option with get, set
        /// Style override for checkbox when enabled/unchecked/focused.
        abstract checkboxFocused: IStyle option with get, set
        /// Style override for checkbox when enabled/checked.
        abstract checkboxChecked: IStyle option with get, set
        /// Style override for checkbox when enabled/checked/hovered.
        abstract checkboxCheckedHovered: IStyle option with get, set
        /// Style override for checkbox when enabled/checked/focused.
        abstract checkboxCheckedFocused: IStyle option with get, set
        /// Style override for checkbox when disabled/unchecked.
        abstract checkboxDisabled: IStyle option with get, set
        /// Style override for checkbox when disabled/checked.
        abstract checkboxCheckedDisabled: IStyle option with get, set
        /// Style for the checkmark in the default enabled/unchecked state.
        abstract checkmark: IStyle option with get, set
        /// Style override for the checkmark when enabled/checked.
        abstract checkmarkChecked: IStyle option with get, set
        /// Style override for checkmark when disabled/unchecked.
        abstract checkmarkDisabled: IStyle option with get, set
        /// Style override for checkmark when disabled/checked.
        abstract checkmarkCheckedDisabled: IStyle option with get, set
        /// Style for text appearing with the checkbox in its default enabled state.
        abstract text: IStyle option with get, set
        /// Style override for text appearing with the checkbox when enabled/hovered.
        abstract textHovered: IStyle option with get, set
        /// Style override for text appearing with the checkbox when enabled/focused.
        abstract textFocused: IStyle option with get, set
        /// Style override for text appearing with the checkbox when disabled.
        abstract textDisabled: IStyle option with get, set

module __components_Checkbox_CheckboxPage =
    type IComponentDemoPageProps = __components_Checkbox_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract CheckboxPage: CheckboxPageStatic

    type [<AllowNullLiteral>] CheckboxPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CheckboxPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CheckboxPage

module __components_ChoiceGroup_ChoiceGroup_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroupStatus: obj

module __components_ChoiceGroup_ChoiceGroup =
    type IChoiceGroupProps = __components_ChoiceGroup_ChoiceGroup_types.IChoiceGroupProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroup: ChoiceGroupStatic

    type [<AllowNullLiteral>] IChoiceGroupState =
        abstract keyChecked: U2<string, float> with get, set
        /// Is true when the control has focus. 
        abstract keyFocused: U2<string, float> option with get, set

    type [<AllowNullLiteral>] ChoiceGroup =
        inherit BaseComponent<IChoiceGroupProps, IChoiceGroupState>
        abstract defaultProps: IChoiceGroupProps with get, set
        abstract _id: obj with get, set
        abstract _labelId: obj with get, set
        abstract _inputElement: obj with get, set
        abstract componentWillReceiveProps: newProps: IChoiceGroupProps -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _onFocus: option: obj * ev: obj -> unit
        abstract _onBlur: option: obj * ev: obj -> unit
        abstract _onRenderField: option: obj -> unit
        abstract _onRenderLabel: option: obj -> unit
        abstract _onChange: option: obj * evt: obj -> unit
        /// If all the isChecked property of options are falsy values, return undefined;
        /// Else return the key of the first option with the truthy isChecked property.
        abstract _getKeyChecked: props: obj -> unit

    type [<AllowNullLiteral>] ChoiceGroupStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IChoiceGroupProps -> ChoiceGroup

module __components_ChoiceGroup_ChoiceGroup_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract optionsContainIconOrImage: obj
        abstract choiceField: obj
        abstract input: obj
        abstract field: obj
        abstract fieldIsChecked: obj
        abstract fieldIsDisabled: obj
        abstract choiceFieldIsImage: obj
        abstract choiceFieldIsIcon: obj
        abstract fieldIsImage: obj
        abstract fieldIsIcon: obj
        abstract innerField: obj
        abstract imageIsLarge: obj
        abstract imageWrapper: obj
        abstract imageWrapperIsHidden: obj
        abstract labelWrapper: obj
        abstract inputHasImage: obj
        abstract inputHasIcon: obj
        abstract iconWrapper: obj
        abstract choiceFieldIsInFocus: obj
        abstract choiceFieldWrapper: obj

module __components_ChoiceGroup_ChoiceGroup_types =
    type IIconProps = Icon.IIconProps
    type IRenderFunction = Utilities.IRenderFunction

    type [<AllowNullLiteral>] IChoiceGroup =
        interface end

    type [<AllowNullLiteral>] IChoiceGroupProps =
        inherit React.InputHTMLAttributes<U2<HTMLElement, HTMLInputElement>>
        /// Optional callback to access the IChoiceGroup interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IChoiceGroup option -> unit) option with get, set
        /// The options for the choice group.
        abstract options: ResizeArray<IChoiceGroupOption> option with get, set
        /// The key of the option that will be initially checked.
        abstract defaultSelectedKey: U2<string, float> option with get, set
        /// The key of the selected option. If you provide this, you must maintain selection
        /// state by observing onChange events and passing a new value in when changed.
        abstract selectedKey: U2<string, float> option with get, set
        /// A callback for receiving a notification when the choice has been changed.
        abstract onChange: (React.FormEvent<U2<HTMLElement, HTMLInputElement>> -> IChoiceGroupOption -> unit) option with get, set
        /// Descriptive label for the choice group.
        abstract label: string option with get, set
        /// Deprecated and will be removed by 07/17/2017 Use 'onChange' instead.
        abstract onChanged: (IChoiceGroupOption -> React.FormEvent<U2<HTMLElement, HTMLInputElement>> -> unit) option with get, set

    type [<AllowNullLiteral>] IChoiceGroupOption =
        inherit React.HTMLAttributes<U2<HTMLElement, HTMLInputElement>>
        /// A required key to uniquely identify the option.
        abstract key: string with get, set
        /// The text string for the option.
        abstract text: string with get, set
        /// Optional override of option render
        abstract onRenderField: IRenderFunction<IChoiceGroupOption> option with get, set
        /// Optional override of option render
        abstract onRenderLabel: (IChoiceGroupOption -> JSX.Element) option with get, set
        /// The Icon component props for choice field
        abstract iconProps: IIconProps option with get, set
        /// The src of image for choice field.
        abstract imageSrc: string option with get, set
        /// The alt of image for choice field. Defaults to '' if not set.
        abstract imageAlt: string option with get, set
        /// The src of image for choice field which is selected.
        abstract selectedImageSrc: string option with get, set
        /// The width and height of the image in px for choice field.
        abstract imageSize: obj option with get, set
        /// Whether or not the option is disabled.
        abstract disabled: bool option with get, set
        /// This value is maintained by the component and is accessible during onRenderField
        abstract ``checked``: bool option with get, set
        /// This value is maintained by the component and is accessible during onRenderField
        abstract id: string option with get, set
        /// This value is maintained by the component and is accessible during onRenderField
        abstract labelId: string option with get, set

module __components_ChoiceGroup_ChoiceGroupPage =
    type IComponentDemoPageProps = __components_ChoiceGroup_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroupPage: ChoiceGroupPageStatic

    type [<AllowNullLiteral>] ChoiceGroupPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ChoiceGroupPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ChoiceGroupPage

module __components_Coachmark_Coachmark =
    type BaseComponent = Utilities.BaseComponent
    type ICoachmarkTypes = __components_Coachmark_Coachmark_types.ICoachmarkTypes

    type [<AllowNullLiteral>] IExports =
        abstract Coachmark: CoachmarkStatic

    /// An interface for the cached dimensions of entity inner host.
    type [<AllowNullLiteral>] IEntityRect =
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] ICoachmarkState =
        /// Is the Coachmark currently collapsed into
        /// a tear drop shape
        abstract collapsed: bool with get, set
        /// Enables/Disables the beacon that radiates
        /// from the center of the coachmark.
        abstract isBeaconAnimating: bool with get, set
        /// Is the teaching bubble currently retreiving the
        /// original dimensions of the hosted entity.
        abstract isMeasuring: bool with get, set
        /// Cached width and height of _entityInnerHostElement
        abstract entityInnerHostRect: IEntityRect with get, set
        /// Is the mouse in proximity of the default target element
        abstract isMouseInProximity: bool with get, set
        /// The left position of the beak
        abstract beakLeft: string option with get, set
        /// The right position of the beak
        abstract beakTop: string option with get, set

    type [<AllowNullLiteral>] Coachmark =
        inherit BaseComponent<ICoachmarkTypes, ICoachmarkState>
        abstract defaultProps: obj with get, set
        /// The cached HTMLElement reference to the Entity Inner Host
        /// element.
        abstract _entityInnerHostElement: obj with get, set
        abstract _translateAnimationContainer: obj with get, set
        abstract _positioningContainer: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentWillReceiveProps: newProps: ICoachmarkTypes -> unit
        abstract componentDidMount: unit -> unit
        abstract _onFocusHandler: obj with get, set
        abstract _openCoachmark: obj with get, set
        abstract _addProximityHandler: ?mouseProximityOffset: obj -> unit
        abstract _isInsideElement: mouseX: obj * mouseY: obj * elementRect: obj * ?mouseProximityOffset: obj -> unit

    type [<AllowNullLiteral>] CoachmarkStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICoachmarkTypes -> Coachmark

module __components_Coachmark_Coachmark_styles =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract translateOne: string
        abstract scaleOne: string
        abstract rotateOne: string
        abstract getStyles: props: ICoachmarkStyleProps * ?theme: ITheme -> ICoachmarkStyles

    type [<AllowNullLiteral>] ICoachmarkStyleProps =
        /// Is the Coachmark collapsed
        abstract collapsed: bool with get, set
        /// Is the beacon currently animating.
        abstract isBeaconAnimating: bool with get, set
        /// Is the component taking measurements
        abstract isMeasuring: bool with get, set
        /// The height measured before the component has been mounted
        /// in pixels
        abstract entityHostHeight: string option with get, set
        /// The width measured in pixels
        abstract entityHostWidth: string option with get, set
        /// Width of the coachmark
        abstract width: string option with get, set
        /// Height of the coachmark
        abstract height: string option with get, set
        /// Color
        abstract color: string option with get, set
        /// Beacon color one
        abstract beaconColorOne: string option with get, set
        /// Beacon color two
        abstract beaconColorTwo: string option with get, set

    type [<AllowNullLiteral>] ICoachmarkStyles =
        /// Style for the root element in the default enabled/unchecked state.
        abstract root: IStyle option with get, set
        /// The pulsing beacon that animates when the coachmark
        /// is collapsed.
        abstract pulsingBeacon: IStyle option with get, set
        /// The layer, or div, that the translate animation will be applied to.
        abstract translateAnimationContainer: IStyle option with get, set
        /// The layer the Scale animation will be applied to.
        abstract scaleAnimationLayer: IStyle option with get, set
        /// The layer the Rotate animation will be applied to.
        abstract rotateAnimationLayer: IStyle option with get, set
        /// The layer that content/components/elments will be hosted in.
        abstract entityHost: IStyle option with get, set
        /// The inner layer that components will be hosted in
        /// and primary purpose is scaling the layer down while the
        /// Coachmark collapsed.
        abstract entityInnerHost: IStyle with get, set
        /// The styles applied when the coachmark has collapsed.
        abstract collapsed: IStyle option with get, set

module __components_Coachmark_Coachmark_types =
    type Coachmark = __components_Coachmark_Coachmark.Coachmark
    type ICoachmarkStyles = __components_Coachmark_Coachmark_styles.ICoachmarkStyles
    type ICoachmarkStyleProps = __components_Coachmark_Coachmark_styles.ICoachmarkStyleProps
    type IPositioningContainerTypes = __components_Coachmark_PositioningContainer_PositioningContainer_types.IPositioningContainerTypes
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] ICoachmark =
        interface end

    type [<AllowNullLiteral>] ICoachmarkTypes =
        inherit React.Props<Coachmark>
        abstract componentRef: (ICoachmark option -> unit) option with get, set
        /// Get styles method.
        abstract getStyles: IStyleFunction<ICoachmarkStyleProps, ICoachmarkStyles> option with get, set
        /// The target that the TeachingBubble should try to position itself based on.
        abstract target: HTMLElement option with get, set
        abstract positioningContainerProps: IPositioningContainerTypes option with get, set
        /// The starting collapsed state for the Coachmark?
        abstract collapsed: bool option with get, set
        /// The distance in pixels the mouse is located
        /// before opening up the coachmark.
        abstract mouseProximityOffset: float option with get, set
        /// Callback when the opening animation begins.
        abstract onAnimationOpenStart: (unit -> unit) option with get, set
        /// Callback when the opening animation completes.
        abstract onAnimationOpenEnd: (unit -> unit) option with get, set
        /// The width of the beak component.
        abstract beakWidth: float option with get, set
        /// The height of the beak component
        abstract beakHeight: float option with get, set
        /// Delay before allowing mouse movements to open
        /// the Coachmark
        abstract delayBeforeMouseOpen: float option with get, set
        /// Runs every time the mouse moves
        abstract onMouseMove: (MouseEvent -> unit) option with get, set
        /// The width of the coachmark
        abstract width: float option with get, set
        /// The height of the coachmark
        abstract height: float option with get, set
        /// Color
        abstract color: string option with get, set
        /// Beacon color one
        abstract beaconColorOne: string option with get, set
        /// Beacon color two
        abstract beaconColorTwo: string option with get, set

module __components_Coachmark_CoachmarkPage =
    type IComponentDemoPageProps = __components_Coachmark_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract CoachmarkPage: CoachmarkPageStatic

    type [<AllowNullLiteral>] CoachmarkPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CoachmarkPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CoachmarkPage

module __components_ColorPicker_ColorPicker_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ColorPickerStatus: obj

module __components_ColorPicker_ColorPicker =
    type BaseComponent = Utilities.BaseComponent
    type IColorPickerProps = __components_ColorPicker_ColorPicker_types.IColorPickerProps
    type IColor = __utilities_color_colors.IColor

    type [<AllowNullLiteral>] IExports =
        abstract ColorPicker: ColorPickerStatic

    type [<AllowNullLiteral>] IColorPickerState =
        abstract isOpen: bool with get, set
        abstract color: IColor with get, set

    type [<AllowNullLiteral>] ColorPicker =
        inherit BaseComponent<IColorPickerProps, IColorPickerState>
        abstract defaultProps: obj with get, set
        abstract hexText: obj with get, set
        abstract rText: obj with get, set
        abstract gText: obj with get, set
        abstract bText: obj with get, set
        abstract aText: obj with get, set
        abstract componentWillReceiveProps: newProps: IColorPickerProps -> unit
        abstract render: unit -> JSX.Element
        abstract _onSVChanged: obj with get, set
        abstract _onHChanged: obj with get, set
        abstract _onAChanged: obj with get, set
        abstract _onHexChanged: obj with get, set
        abstract _onRGBAChanged: obj with get, set
        abstract _updateColor: ?newColor: obj -> unit

    type [<AllowNullLiteral>] ColorPickerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IColorPickerProps -> ColorPicker

module __components_ColorPicker_ColorPicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract panel: obj
        abstract colorRect: obj
        abstract rectContainer: obj
        abstract capture: obj
        abstract rectContainerIsAdjusting: obj
        abstract table: obj
        abstract tableHexCell: obj
        abstract thumb: obj
        abstract thumbIsSlider: obj
        abstract light: obj
        abstract dark: obj
        abstract slider: obj
        abstract colorSliderIsHue: obj
        abstract colorSliderIsAlpha: obj
        abstract sliderOverlay: obj
        abstract input: obj

module __components_ColorPicker_ColorPicker_types =

    type [<AllowNullLiteral>] IColorPickerProps =
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// The CSS-compatible string to describe the initial color
        abstract color: string with get, set
        /// Callback issued when the user changes the color
        abstract onColorChanged: (string -> unit) option with get, set
        /// The setting of whether to hide the alpha control slider.
        abstract alphaSliderHidden: bool option with get, set
        /// Label for the hex textfield.
        abstract hexLabel: string option with get, set
        /// Label for the red textfield
        abstract redLabel: string option with get, set
        /// Label for the green textfield
        abstract greenLabel: string option with get, set
        /// Label for the blue textfield
        abstract blueLabel: string option with get, set
        /// Label for the alpha textfield
        abstract alphaLabel: string option with get, set

module __components_ColorPicker_ColorPickerPage =
    type IComponentDemoPageProps = __components_ColorPicker_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ColorPickerPage: ColorPickerPageStatic

    type [<AllowNullLiteral>] ColorPickerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ColorPickerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ColorPickerPage

module __components_ColorPicker_ColorRectangle =
    type BaseComponent = Utilities.BaseComponent
    type IColor = __utilities_color_colors.IColor

    type [<AllowNullLiteral>] IExports =
        abstract ColorRectangle: ColorRectangleStatic

    type [<AllowNullLiteral>] IColorRectangleProps =
        abstract componentRef: (unit -> unit) option with get, set
        abstract color: IColor with get, set
        abstract minSize: float option with get, set
        abstract onSVChanged: s: float * v: float -> unit

    type [<AllowNullLiteral>] IColorPickerState =
        abstract isAdjusting: bool option with get, set
        abstract origin: obj option with get, set
        abstract color: IColor option with get, set
        abstract fullColorString: string option with get, set

    type [<AllowNullLiteral>] ColorRectangle =
        inherit BaseComponent<IColorRectangleProps, IColorPickerState>
        abstract defaultProps: obj with get, set
        abstract _root: obj with get, set
        abstract componentWillUnmount: unit -> unit
        abstract componentWillReceiveProps: newProps: IColorRectangleProps -> unit
        abstract render: unit -> JSX.Element
        abstract _onMouseDown: obj with get, set
        abstract _onMouseMove: obj with get, set
        abstract _onMouseUp: obj with get, set

    type [<AllowNullLiteral>] ColorRectangleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IColorRectangleProps -> ColorRectangle

module __components_ColorPicker_ColorSlider =
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract ColorSlider: ColorSliderStatic

    type [<AllowNullLiteral>] IColorSliderProps =
        abstract componentRef: (unit -> unit) option with get, set
        abstract minValue: float option with get, set
        abstract maxValue: float option with get, set
        abstract value: float option with get, set
        abstract thumbColor: string option with get, set
        abstract overlayStyle: obj option with get, set
        abstract onChanged: (float -> unit) option with get, set
        abstract className: string option with get, set
        abstract style: obj option with get, set

    type [<AllowNullLiteral>] IColorSliderState =
        abstract isAdjusting: bool option with get, set
        abstract origin: obj option with get, set
        abstract currentValue: float option with get, set

    type [<AllowNullLiteral>] ColorSlider =
        inherit BaseComponent<IColorSliderProps, IColorSliderState>
        abstract defaultProps: obj with get, set
        abstract _root: obj with get, set
        abstract componentWillReceiveProps: newProps: IColorSliderProps -> unit
        abstract render: unit -> JSX.Element
        abstract _onMouseDown: obj with get, set
        abstract _onMouseMove: obj with get, set
        abstract _onMouseUp: obj with get, set

    type [<AllowNullLiteral>] ColorSliderStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IColorSliderProps -> ColorSlider

module __components_ComboBox_ComboBox_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ComboBoxStatus: obj

module __components_ComboBox_ComboBox_classNames =
    type IComboBoxStyles = __components_ComboBox_ComboBox_types.IComboBoxStyles
    type IComboBoxOptionStyles = __components_ComboBox_ComboBox_types.IComboBoxOptionStyles

    type [<AllowNullLiteral>] IExports =
        abstract getClassNames: (obj -> string -> bool -> bool -> bool -> bool -> bool -> bool -> IComboBoxClassNames)
        abstract getComboBoxOptionClassNames: (obj -> IComboBoxOptionClassNames)

    type [<AllowNullLiteral>] IComboBoxClassNames =
        abstract container: string with get, set
        abstract label: string with get, set
        abstract root: string with get, set
        abstract input: string with get, set
        abstract errorMessage: string with get, set
        abstract callout: string with get, set
        abstract optionsContainer: string with get, set
        abstract header: string with get, set
        abstract divider: string with get, set
        abstract optionsContainerWrapper: string with get, set

    type [<AllowNullLiteral>] IComboBoxOptionClassNames =
        abstract optionText: string with get, set
        abstract root: string with get, set

module __components_ComboBox_ComboBox =
    type BaseComponent = Utilities.BaseComponent
    type IComboBoxOption = __components_ComboBox_ComboBox_types.IComboBoxOption
    type IComboBoxProps = __components_ComboBox_ComboBox_types.IComboBoxProps

    type [<AllowNullLiteral>] IExports =
        abstract ComboBox: ComboBoxStatic

    type [<AllowNullLiteral>] IComboBoxState =
        abstract isOpen: bool option with get, set
        abstract selectedIndices: ResizeArray<float> option with get, set
        abstract focused: bool option with get, set
        abstract suggestedDisplayValue: string option with get, set
        abstract currentOptions: ResizeArray<IComboBoxOption> with get, set
        abstract currentPendingValueValidIndex: float with get, set
        abstract currentPendingValueValidIndexOnHover: float with get, set
        abstract currentPendingValue: string with get, set

    type [<AllowNullLiteral>] ComboBox =
        inherit BaseComponent<IComboBoxProps, IComboBoxState>
        abstract defaultProps: IComboBoxProps with get, set
        abstract _root: obj with get, set
        abstract _autofill: obj with get, set
        abstract _comboBoxWrapper: obj with get, set
        abstract _comboBoxMenu: obj with get, set
        abstract _selectedElement: obj with get, set
        abstract _id: obj with get, set
        abstract _lastReadOnlyAutoCompleteChangeTimeoutId: obj with get, set
        abstract _currentPromise: obj with get, set
        abstract _currentVisibleValue: obj with get, set
        abstract _classNames: obj with get, set
        abstract _isScrollIdle: obj with get, set
        abstract _hasPendingValue: obj with get, set
        abstract _scrollIdleTimeoutId: obj with get, set
        abstract _processingTouch: obj with get, set
        abstract _lastTouchTimeoutId: obj with get, set
        abstract _focusInputAfterClose: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: IComboBoxProps -> unit
        abstract componentDidUpdate: prevProps: IComboBoxProps * prevState: IComboBoxState -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        /// Set focus on the input
        abstract focus: (bool option -> unit) with get, set
        /// Close menu callout if it is open
        abstract dismissMenu: (unit -> unit) with get, set
        /// componentWillReceiveProps handler for the auto fill component
        /// Checks/updates the iput value to set, if needed
        abstract _onUpdateValueInAutofillWillReceiveProps: obj with get, set
        /// componentDidUpdate handler for the auto fill component
        abstract _onShouldSelectFullInputValueInAutofillComponentDidUpdate: obj with get, set
        /// Get the correct value to pass to the input
        /// to show to the user based off of the current props and state
        abstract _getVisibleValue: obj with get, set
        /// <summary>Is the index within the bounds of the array?</summary>
        /// <param name="options">- options to check if the index is valid for</param>
        /// <param name="index">- the index to check</param>
        abstract _indexWithinBounds: options: obj * index: obj -> unit
        /// Handler for typing changes on the input
        abstract _onInputChange: obj with get, set
        /// <summary>Process the new input's new value when the comboBox
        /// allows freeform entry</summary>
        /// <param name="updatedValue">- the input's newly changed value</param>
        abstract _processInputChangeWithFreeform: updatedValue: obj -> unit
        /// <summary>Process the new input's new value when the comboBox
        /// does not allow freeform entry</summary>
        /// <param name="updatedValue">- the input's newly changed value</param>
        abstract _processInputChangeWithoutFreeform: updatedValue: obj -> unit
        abstract _getFirstSelectedIndex: unit -> unit
        /// <summary>Walk along the options starting at the index, stepping by the delta (positive or negative)
        /// looking for the next valid selectable index (e.g. skipping headings and dividers)</summary>
        /// <param name="index">- the index to get the next selectable index from</param>
        abstract _getNextSelectableIndex: index: obj * searchDirection: obj -> unit
        /// <summary>Set the selected index. Note, this is
        /// the "real" selected index, not the pending selected index</summary>
        /// <param name="index">- the index to set (or the index to set from if a search direction is provided)</param>
        /// <param name="searchDirection">- the direction to search along the options from the given index</param>
        abstract _setSelectedIndex: index: obj * submitPendingValueEvent: obj * ?searchDirection: obj -> unit
        /// Focus (and select) the content of the input
        /// and set the focused state
        abstract _select: obj with get, set
        /// Callback issued when the options should be resolved, if they have been updated or
        /// if they need to be passed in the first time. This only does work if an onResolveOptions
        /// callback was passed in
        abstract _onResolveOptions: obj with get, set
        /// OnBlur handler. Set the focused state to false
        /// and submit any pending value
        abstract _onBlur: obj with get, set
        /// Submit a pending value if there is one
        abstract _submitPendingValue: submitPendingValueEvent: obj -> unit
        abstract _onRenderContainer: obj with get, set
        abstract _onRenderList: obj with get, set
        abstract _onRenderItem: obj with get, set
        abstract _onRenderLowerContent: obj with get, set
        abstract _renderSeparator: item: obj -> unit
        abstract _renderHeader: item: obj -> unit
        abstract _renderOption: obj with get, set
        /// If we are coming from a mouseOut:
        /// there is no visible selected option.
        /// 
        /// Else if We are hovering over an item:
        /// that gets the selected look.
        /// 
        /// Else:
        /// Use the current valid pending index if it exists OR
        /// we do not have a valid index and we currently have a pending input value,
        /// otherwise use the selected index
        abstract _isOptionSelected: index: obj -> unit
        /// <summary>Gets the pending selected index taking into account hover, valueValidIndex, and selectedIndex</summary>
        /// <param name="includeCurrentPendingValue">- Should we include the currentPendingValue when
        /// finding the index</param>
        abstract _getPendingSelectedIndex: includeCurrentPendingValue: obj -> unit
        /// Scroll handler for the callout to make sure the mouse events
        /// for updating focus are not interacting during scroll
        abstract _onScroll: obj with get, set
        /// Scroll the selected element into view
        abstract _scrollIntoView: unit -> unit
        abstract _onRenderOptionContent: obj with get, set
        /// <summary>Click handler for the menu items
        /// to select the item and also close the menu</summary>
        /// <param name="index">- the index of the item that was clicked</param>
        abstract _onItemClick: index: obj -> unit
        /// Handles dismissing (cancelling) the menu
        abstract _onDismiss: obj with get, set
        /// <summary>Get the index of the option that is marked as selected</summary>
        /// <param name="options">- the comboBox options</param>
        /// <param name="selectedKeys">- the known selected key to find</param>
        abstract _getSelectedIndices: options: obj * selectedKeys: obj -> unit
        /// Reset the selected index by clearing the
        /// input (of any pending text), clearing the pending state,
        /// and setting the suggested display value to the last
        /// selected state text
        abstract _resetSelectedIndex: unit -> unit
        /// Clears the pending info state
        abstract _clearPendingInfo: unit -> unit
        /// <summary>Set the pending info</summary>
        /// <param name="currentPendingValue">- new pending value to set</param>
        /// <param name="currentPendingValueValidIndex">- new pending value index to set</param>
        /// <param name="suggestedDisplayValue">- new suggest display value to set</param>
        abstract _setPendingInfo: currentPendingValue: obj * currentPendingValueValidIndex: obj * suggestedDisplayValue: obj -> unit
        /// <summary>Set the pending info from the given index</summary>
        /// <param name="index">- the index to set the pending info from</param>
        abstract _setPendingInfoFromIndex: index: obj -> unit
        /// <summary>Sets the pending info for the comboBox</summary>
        /// <param name="index">- the index to search from</param>
        /// <param name="searchDirection">- the direction to search</param>
        abstract _setPendingInfoFromIndexAndDirection: index: obj * searchDirection: obj -> unit
        abstract _notifyPendingValueChanged: prevState: obj -> unit
        /// Sets the isOpen state and updates focusInputAfterClose
        abstract _setOpenStateAndFocusOnClose: isOpen: obj * focusInputAfterClose: obj -> unit
        /// Handle keydown on the input
        abstract _onInputKeyDown: obj with get, set
        /// Handle keyup on the input
        abstract _onInputKeyUp: obj with get, set
        abstract _onOptionMouseEnter: index: obj -> unit
        abstract _onOptionMouseMove: index: obj -> unit
        abstract _onOptionMouseLeave: obj with get, set
        /// <summary>Handle dismissing the menu and
        /// eating the required key event when disabled</summary>
        /// <param name="ev">- the keyboard event that was fired</param>
        abstract _handleInputWhenDisabled: ev: obj -> unit
        /// Click handler for the button of the comboBox
        /// and the input when not allowing freeform. This
        /// toggles the expand/collapse state of the comboBox (if enbled)
        abstract _onComboBoxClick: obj with get, set
        /// Click handler for the autofill.
        abstract _onAutofillClick: obj with get, set
        abstract _onTouchStart: obj with get, set
        abstract _onPointerDown: obj with get, set
        abstract _handleTouchAndPointerEvent: unit -> unit
        /// Get the styles for the current option.
        abstract _getCaretButtonStyles: unit -> unit
        /// <summary>Get the styles for the current option.</summary>
        /// <param name="item">Item props for the current option</param>
        abstract _getCurrentOptionStyles: item: obj -> unit
        /// Get the aria-activedescendant value for the comboxbox.
        abstract _getAriaActiveDescentValue: unit -> unit
        /// Get the aria autocomplete value for the Combobox
        abstract _getAriaAutoCompleteValue: unit -> unit
        abstract _isPendingOption: item: obj -> unit
        /// Given default selected key(s) and selected key(s), return the selected keys(s).
        /// When default selected key(s) are available, they take precedence and return them instead of selected key(s).
        abstract _getSelectedKeys: defaultSelectedKey: obj * selectedKey: obj -> unit
        abstract _getPreviewText: item: obj -> unit

    type [<AllowNullLiteral>] ComboBoxStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IComboBoxProps -> ComboBox

module __components_ComboBox_ComboBox_styles =
    type ITheme = Styling.ITheme
    type IComboBoxOptionStyles = __components_ComboBox_ComboBox_types.IComboBoxOptionStyles
    type IComboBoxStyles = __components_ComboBox_ComboBox_types.IComboBoxStyles
    type IButtonStyles = Button.IButtonStyles

    type [<AllowNullLiteral>] IExports =
        abstract getOptionStyles: (ITheme -> obj option -> obj option -> bool option -> obj)
        abstract getCaretDownButtonStyles: (ITheme -> obj option -> IButtonStyles)
        abstract getStyles: (ITheme -> obj option -> string option -> obj)

module __components_ComboBox_ComboBox_types =
    type IIconProps = Icon.IIconProps
    type ISelectableOption = __utilities_selectableOption_SelectableOption_types.ISelectableOption
    type ISelectableDroppableTextProps = __utilities_selectableOption_SelectableDroppableText_types.ISelectableDroppableTextProps
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IButtonStyles = Button.IButtonStyles
    type IRenderFunction = Utilities.IRenderFunction
    type IComboBoxClassNames = __components_ComboBox_ComboBox_classNames.IComboBoxClassNames
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IComboBox =
        /// If there is a menu open this will dismiss the menu
        abstract dismissMenu: (unit -> unit) with get, set
        /// Sets focus to the input in the comboBox
        abstract focus: ?shouldOpenOnFocus: bool -> bool

    type [<AllowNullLiteral>] IComboBoxOption =
        inherit ISelectableOption
        /// Specific styles for each comboBox option. If you intend to give
        /// common styles to all comboBox option please use
        /// the prop comboBoxOptionStyles
        abstract styles: obj option with get, set
        /// In scenarios where embedded data is used at the text prop, we will use the ariaLabel prop
        /// to set the aria-label and preview text. Default to false
        abstract useAriaLabelAsText: bool option with get, set

    type [<AllowNullLiteral>] IComboBoxProps =
        inherit ISelectableDroppableTextProps<IComboBox>
        /// Optional callback to access the IComboBox interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IComboBox option -> unit) option with get, set
        /// Collection of options for this ComboBox
        abstract options: ResizeArray<IComboBoxOption> with get, set
        /// Callback issues when either:
        /// 1) the selected option changes
        /// 2) a manually edited value is submitted. In this case there may not be a matched option if allowFreeform is also true
        ///     (and hence only value would be true, the other parameter would be null in this case)
        abstract onChanged: (IComboBoxOption -> float -> string -> obj option -> unit) option with get, set
        /// Callback issued when the user changes the pending value in ComboBox
        abstract onPendingValueChanged: (IComboBoxOption -> float -> string -> unit) option with get, set
        /// Function that gets invoked when the ComboBox menu is launched
        abstract onMenuOpen: (unit -> unit) option with get, set
        /// Function that gets invoked when the ComboBox menu is dismissed
        abstract onMenuDismissed: (unit -> unit) option with get, set
        /// Callback issued when the options should be resolved, if they have been updated or
        /// if they need to be passed in the first time
        abstract onResolveOptions: (ResizeArray<IComboBoxOption> -> U2<ResizeArray<IComboBoxOption>, PromiseLike<ResizeArray<IComboBoxOption>>>) option with get, set
        /// Callback issued when the ComboBox requests the list to scroll to a specific element
        abstract onScrollToItem: (float -> unit) option with get, set
        /// Whether the ComboBox is free form, meaning that the user input is not bound to provided options. Defaults to false.
        abstract allowFreeform: bool option with get, set
        /// Whether the ComboBox auto completes. As the user is inputing text, it will be suggested potential matches from the list of options. If
        /// the combo box is expanded, this will also scroll to the suggested option, and give it a selected style.
        abstract autoComplete: U2<string, string> option with get, set
        /// Value to show in the input, does not have to map to a combobox option
        abstract text: string option with get, set
        /// The IconProps to use for the button aspect of the combobox
        abstract buttonIconProps: IIconProps option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Custom styles for this component
        abstract styles: obj option with get, set
        /// Custom function for providing the classNames for the ComboBox. Can be used to provide
        /// all styles for the component instead of applying them on top of the default styles.
        abstract getClassNames: (ITheme -> bool -> bool -> bool -> bool -> bool -> bool -> string -> IComboBoxClassNames) option with get, set
        /// Styles for the caret down button.
        abstract caretDownButtonStyles: obj option with get, set
        /// Default styles that should be applied to ComboBox options,
        /// in case an option does not come with user-defined custom styles
        abstract comboBoxOptionStyles: obj option with get, set
        /// When options are scrollable the selected option is positioned at the top of the callout when it is opened (unless it has reached the end of the scrollbar).
        abstract scrollSelectedToTop: bool option with get, set
        /// Add additional content below the callout list.
        abstract onRenderLowerContent: IRenderFunction<IComboBoxProps> option with get, set
        /// Custom width for dropdown (unless useComboBoxAsMenuWidth is undefined or false)
        abstract dropdownWidth: float option with get, set
        /// Whether to use the ComboBoxes width as the menu's width
        abstract useComboBoxAsMenuWidth: bool option with get, set
        /// Optional mode indicates if multi-choice selections is allowed.  Default to false
        abstract multiSelect: bool option with get, set
        /// Sets the 'aria-hidden' attribute on the ComboBox's button element instructing screen readers how to handle the element. This element is hidden by default because all functionality is handled by the input element and the arrow button is only meant to be decorative.
        abstract isButtonAriaHidden: bool option with get, set
        /// Optional keytip for this combo box
        abstract keytipProps: IKeytipProps option with get, set
        /// Value to show in the input, does not have to map to a combobox option
        abstract value: string option with get, set

    type [<AllowNullLiteral>] IComboBoxStyles =
        /// Style for the container which has the ComboBox and the label
        abstract container: IStyle with get, set
        /// Style for the label element of the ComboBox.
        abstract label: IStyle with get, set
        /// Style for the label element of the ComboBox in the disabled state.
        abstract labelDisabled: IStyle with get, set
        /// Base styles for the root element of all ComboBoxes.
        abstract root: IStyle with get, set
        /// Styles for the root element for variant of ComboBox with an errorMessage in the props.
        abstract rootError: IStyle with get, set
        /// Styles for variant of ComboBox where allowFreeForm is false in the props.
        abstract rootDisallowFreeForm: IStyle with get, set
        /// Styles for when the ComboBox is hovered. These styles are applied for all comboBoxes except when
        /// the comboBox is disabled.
        abstract rootHovered: IStyle with get, set
        /// Styles for when the ComboBox is active. These styles are applied for all comboBoxes except when
        /// the comboBox is disabled.
        abstract rootPressed: IStyle with get, set
        /// Styles for when the ComboBox is focused. These styles are applied for all comboBoxes except when
        /// the comboBox is disabled.
        abstract rootFocused: IStyle with get, set
        /// Styles for when the comboBox is disabled. These styles override all the other styles.
        /// NOTE : Hover (or) Focused (or) active styles are not applied for disabled comboBoxes.
        abstract rootDisabled: IStyle with get, set
        /// Base styles for the input element - which contains the currently selected
        /// option.
        abstract input: IStyle with get, set
        /// Style override for the input element when comboBox is disabled.
        abstract inputDisabled: IStyle with get, set
        /// Styles for the error Message text of the comboBox.
        abstract errorMessage: IStyle with get, set
        /// Styles for the callout.
        abstract callout: IStyle with get, set
        /// Styles for the optionsContainerWrapper.
        abstract optionsContainerWrapper: IStyle with get, set
        /// Styles for the container of all the Combobox options
        /// Includes the headers and dividers.
        abstract optionsContainer: IStyle with get, set
        /// Styles for a header in the options.
        abstract header: IStyle with get, set
        /// Styles for a divider in the options.
        abstract divider: IStyle with get, set

    type [<AllowNullLiteral>] IComboBoxOptionStyles =
        inherit IButtonStyles
        /// Styles for the text inside the comboBox option.
        /// This should be used instead of the description
        /// inside IButtonStyles because we custom render the text
        /// in the comboBox options.
        abstract optionText: IStyle with get, set

module __components_ComboBox_ComboBoxPage =
    type IComponentDemoPageProps = __components_ComboBox_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ComboBoxPage: ComboBoxPageStatic

    type [<AllowNullLiteral>] ComboBoxPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ComboBoxPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ComboBoxPage

module __components_ComboBox_VirtualizedComboBox =
    type BaseComponent = Utilities.BaseComponent
    type IComboBoxProps = __components_ComboBox_ComboBox_types.IComboBoxProps
    type IComboBox = __components_ComboBox_ComboBox_types.IComboBox

    type [<AllowNullLiteral>] IExports =
        abstract VirtualizedComboBox: VirtualizedComboBoxStatic

    type [<AllowNullLiteral>] VirtualizedComboBox =
        inherit BaseComponent<IComboBoxProps, obj>
        inherit IComboBox
        /// The combo box element 
        abstract _comboBox: obj with get, set
        /// The virtualized list element 
        abstract _list: obj with get, set
        abstract dismissMenu: unit -> unit
        abstract focus: unit -> bool
        abstract render: unit -> JSX.Element
        abstract _onRenderList: (IComboBoxProps -> JSX.Element) with get, set
        abstract _onScrollToItem: (float -> unit) with get, set

    type [<AllowNullLiteral>] VirtualizedComboBoxStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> VirtualizedComboBox

module __components_CommandBar_CommandBar_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract CommandBarStatus: obj

module __components_CommandBar_CommandBar =
    type BaseComponent = Utilities.BaseComponent
    type ICommandBar = __components_CommandBar_CommandBar_types.ICommandBar
    type ICommandBarProps = __components_CommandBar_CommandBar_types.ICommandBarProps
    type IContextualMenuProps = ContextualMenu.IContextualMenuProps
    type IContextualMenuItem = ContextualMenu.IContextualMenuItem

    type [<AllowNullLiteral>] IExports =
        abstract CommandBar: CommandBarStatic

    type [<AllowNullLiteral>] ICommandBarState =
        abstract renderedItems: ResizeArray<IContextualMenuItem> option with get, set
        abstract renderedOverflowItems: ResizeArray<IContextualMenuItem> option with get, set
        abstract expandedMenuItemKey: string option with get, set
        abstract expandedMenuId: string option with get, set
        abstract contextualMenuProps: IContextualMenuProps option with get, set
        abstract contextualMenuTarget: HTMLElement option with get, set
        abstract renderedFarItems: ResizeArray<IContextualMenuItem> option with get, set

    type [<AllowNullLiteral>] CommandBar =
        inherit BaseComponent<ICommandBarProps, ICommandBarState>
        inherit ICommandBar
        abstract defaultProps: ICommandBarProps with get, set
        abstract refs: obj with get, set
        abstract _searchSurface: obj with get, set
        abstract _commandSurface: obj with get, set
        abstract _commandBarRegion: obj with get, set
        abstract _farCommandSurface: obj with get, set
        abstract _focusZone: obj with get, set
        abstract _overflow: obj with get, set
        abstract _id: obj with get, set
        abstract _overflowWidth: obj with get, set
        abstract _commandItemWidths: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: nextProps: ICommandBarProps -> unit
        abstract componentDidUpdate: prevProps: ICommandBarProps * prevStates: ICommandBarState -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _renderItemInCommandBar: item: obj * posInSet: obj * setSize: obj * expandedMenuItemKey: obj * ?isFarItem: obj -> unit
        abstract _renderIcon: item: obj -> unit
        abstract _asyncMeasure: unit -> unit
        abstract _updateItemMeasurements: unit -> unit
        abstract _updateRenderedItems: unit -> unit
        abstract _onItemClick: item: obj -> unit
        abstract _onOverflowClick: obj with get, set
        abstract _onContextMenuDismiss: obj with get, set
        abstract _getStateFromProps: nextProps: obj -> unit
        abstract _getContextualMenuPropsAfterUpdate: renderedItems: obj * overflowItems: obj * overflowMenuProps: obj -> unit
        abstract _getContextualMenuPropsFromItem: item: obj -> unit

    type [<AllowNullLiteral>] CommandBarStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICommandBarProps -> CommandBar

module __components_CommandBar_CommandBar_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract container: obj
        abstract primaryCommands: obj
        abstract sideCommands: obj
        abstract item: obj
        abstract itemChevronDown: obj
        abstract itemCommandText: obj
        abstract itemText: obj
        abstract itemLinkIsNoName: obj
        abstract itemIcon: obj
        abstract itemLink: obj
        abstract itemLinkIsExpanded: obj
        abstract itemOverflow: obj
        abstract inactive: obj
        abstract itemIconColor: obj
        abstract search: obj
        abstract searchInput: obj
        abstract searchIconSearchWrapper: obj
        abstract searchIconArrowWrapper: obj
        abstract searchIconClearWrapper: obj
        abstract searchIconWrapper: obj

module __components_CommandBar_CommandBar_types =
    type IContextualMenuItem = __components_ContextualMenu_index.IContextualMenuItem
    type IContextualMenuProps = __components_ContextualMenu_index.IContextualMenuProps

    type [<AllowNullLiteral>] ICommandBar =
        /// Sets focus to the active command in the list.
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ICommandBarProps =
        inherit React.HTMLAttributes<HTMLDivElement>
        /// Optional callback to access the ICommandBar interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ICommandBar option -> unit) option with get, set
        /// Whether or not the search box is visible
        abstract isSearchBoxVisible: bool option with get, set
        /// Placeholder text to display in the search box
        abstract searchPlaceholderText: string option with get, set
        /// Items to render
        abstract items: ResizeArray<IContextualMenuItem> with get, set
        /// Default items to have in the overflow menu
        abstract overflowItems: ResizeArray<IContextualMenuItem> option with get, set
        /// Menu props to be passed to overflow elipsis
        abstract overflowMenuProps: obj option with get, set
        /// Text to be read by screen readers if there are overflow items and focus is on elipsis button
        abstract elipisisAriaLabel: string option with get, set
        /// Items to render on the right side (or left, in RTL).
        abstract farItems: ResizeArray<IContextualMenuItem> option with get, set
        /// Additional css class to apply to the command bar
        abstract className: string option with get, set

    type [<AllowNullLiteral>] ICommandBarItemProps =
        inherit IContextualMenuItem
        /// Remove text when button is not in the overflow
        abstract iconOnly: bool option with get, set

module __components_CommandBar_CommandBarPage =
    type IComponentDemoPageProps = __components_CommandBar_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract CommandBarPage: CommandBarPageStatic

    type [<AllowNullLiteral>] CommandBarPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CommandBarPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarPage

module __components_ContextualMenu_ContextualMenu_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuStatus: obj

module __components_ContextualMenu_ContextualMenu_classNames =
    type ITheme = Styling.ITheme
    type IVerticalDividerClassNames = __components_Divider_VerticalDivider_types.IVerticalDividerClassNames

    type [<AllowNullLiteral>] IExports =
        abstract getSplitButtonVerticalDividerClassNames: (ITheme -> IVerticalDividerClassNames)
        abstract getContextualMenuClassNames: (ITheme -> string option -> IContextualMenuClassNames)
        abstract getItemClassNames: (ITheme -> bool -> bool -> bool -> bool -> bool -> string option -> string option -> string option -> string option -> bool option -> IMenuItemClassNames)

    type [<AllowNullLiteral>] IContextualMenuClassNames =
        abstract container: string with get, set
        abstract root: string with get, set
        abstract list: string with get, set
        abstract header: string with get, set
        abstract title: string with get, set

    type [<AllowNullLiteral>] IMenuItemClassNames =
        abstract item: string with get, set
        abstract divider: string with get, set
        abstract root: string with get, set
        abstract linkContent: string with get, set
        abstract icon: string with get, set
        abstract checkmarkIcon: string with get, set
        abstract subMenuIcon: string with get, set
        abstract label: string with get, set
        abstract secondaryText: string with get, set
        abstract splitContainer: string with get, set
        abstract splitPrimary: string with get, set
        abstract splitMenu: string with get, set
        abstract linkContentMenu: string with get, set

module __components_ContextualMenu_ContextualMenu =
    type IContextualMenuProps = __components_ContextualMenu_ContextualMenu_types.IContextualMenuProps
    type IContextualMenuItem = __components_ContextualMenu_ContextualMenu_types.IContextualMenuItem
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract getSubmenuItems: item: IContextualMenuItem -> ResizeArray<IContextualMenuItem> option
        /// Returns true if a list of menu items can contain a checkbox
        abstract canAnyMenuItemsCheck: items: ResizeArray<IContextualMenuItem> -> bool
        abstract ContextualMenu: ContextualMenuStatic

    type [<AllowNullLiteral>] IContextualMenuState =
        abstract expandedMenuItemKey: string option with get, set
        abstract expandedByMouseClick: bool option with get, set
        abstract dismissedMenuItemKey: string option with get, set
        abstract contextualMenuItems: ResizeArray<IContextualMenuItem> option with get, set
        abstract contextualMenuTarget: Element option with get, set
        abstract submenuTarget: Element option with get, set
        abstract positions: obj option with get, set
        abstract slideDirectionalClassName: string option with get, set
        abstract subMenuId: string option with get, set
        abstract submenuDirection: DirectionalHint option with get, set

    type [<AllowNullLiteral>] ContextualMenu =
        inherit BaseComponent<IContextualMenuProps, IContextualMenuState>
        abstract defaultProps: IContextualMenuProps with get, set
        abstract _host: obj with get, set
        abstract _previousActiveElement: obj with get, set
        abstract _isFocusingPreviousElement: obj with get, set
        abstract _enterTimerId: obj with get, set
        abstract _targetWindow: obj with get, set
        abstract _target: obj with get, set
        abstract _classNames: obj with get, set
        abstract _isScrollIdle: obj with get, set
        abstract _scrollIdleTimeoutId: obj with get, set
        abstract _adjustedFocusZoneProps: obj with get, set
        abstract dismiss: (obj option -> bool option -> unit) with get, set
        abstract componentWillUpdate: newProps: IContextualMenuProps -> unit
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element option
        abstract _onMenuOpened: unit -> unit
        abstract _onMenuClosed: unit -> unit
        /// Gets the focusZoneDirection by using the arrowDirection if specified,
        /// the direction specificed in the focusZoneProps, or defaults to FocusZoneDirection.vertical
        abstract _getFocusZoneDirection: unit -> unit
        abstract _onRenderSubMenu: subMenuProps: obj -> unit
        abstract _renderMenuItem: item: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * hasCheckmarks: obj * hasIcons: obj -> unit
        abstract _renderSectionItem: item: obj * menuClassNames: obj * index: obj * hasCheckmarks: obj * hasIcons: obj -> unit
        abstract _renderListItem: content: obj * key: obj * classNames: obj * ?title: obj -> unit
        abstract _renderSeparator: index: obj * classNames: obj * ?top: obj * ?fromSection: obj -> unit
        abstract _renderNormalItem: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * hasCheckmarks: obj * hasIcons: obj -> unit
        abstract _renderHeaderMenuItem: item: obj * classNames: obj * index: obj * hasCheckmarks: obj * hasIcons: obj -> unit
        abstract _renderAnchorMenuItem: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * hasCheckmarks: obj * hasIcons: obj -> unit
        abstract _renderButtonItem: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * ?hasCheckmarks: obj * ?hasIcons: obj -> unit
        abstract _renderSplitButton: item: obj * classNames: obj * index: obj * focusableElementIndex: obj * totalItemCount: obj * ?hasCheckmarks: obj * ?hasIcons: obj -> unit
        abstract _getIconProps: item: obj -> unit
        abstract _onKeyDown: obj with get, set
        /// Checks if the submenu should be closed
        abstract _shouldCloseSubMenu: obj with get, set
        abstract _onMenuKeyDown: obj with get, set
        /// Scroll handler for the callout to make sure the mouse events
        /// for updating focus are not interacting during scroll
        abstract _onScroll: obj with get, set
        abstract _onItemMouseEnterBase: obj with get, set
        abstract _onItemMouseMoveBase: obj with get, set
        abstract _onMouseItemLeave: obj with get, set
        /// Handles updating focus when mouseEnter or mouseMove fire.
        /// As part of updating focus, This function will also update
        /// the expand/collapse state accordingly.
        abstract _updateFocusOnMouseEvent: item: obj * ev: obj * ?target: obj -> unit
        abstract _onItemMouseDown: obj with get, set
        abstract _onItemClick: obj with get, set
        abstract _onItemClickBase: obj with get, set
        abstract _onAnchorClick: obj with get, set
        abstract _executeItemClick: obj with get, set
        abstract _onItemKeyDown: obj with get, set
        abstract _cancelSubMenuTimer: obj with get, set
        abstract _onItemSubMenuExpand: obj with get, set
        abstract _getSubmenuProps: unit -> unit
        abstract _findItemByKey: key: obj -> unit
        /// <summary>Returns the item that mathes a given key if any.</summary>
        /// <param name="key">The key of the item to match</param>
        /// <param name="items">The items to look for the key</param>
        abstract _findItemByKeyFromItems: key: obj * items: obj -> unit
        abstract _onSubMenuDismiss: obj with get, set
        abstract _setTargetWindowAndElement: target: obj -> unit
        abstract _getSubMenuId: obj with get, set
        abstract _onPointerAndTouchEvent: obj with get, set

    type [<AllowNullLiteral>] ContextualMenuStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IContextualMenuProps -> ContextualMenu

module __components_ContextualMenu_ContextualMenu_styles =
    type ITheme = Styling.ITheme
    type IContextualMenuStyles = __components_ContextualMenu_ContextualMenu_types.IContextualMenuStyles
    type IMenuItemStyles = __components_ContextualMenu_ContextualMenu_types.IMenuItemStyles

    type [<AllowNullLiteral>] IExports =
        abstract getMenuItemStyles: (ITheme -> IMenuItemStyles)
        abstract getStyles: (ITheme -> IContextualMenuStyles)

module __components_ContextualMenu_ContextualMenu_types =
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type FocusZoneDirection = FocusZone.FocusZoneDirection
    type IFocusZoneProps = FocusZone.IFocusZoneProps
    type IIconProps = __components_Icon_Icon_types.IIconProps
    type ICalloutProps = Callout.ICalloutProps
    type ITheme = Styling.ITheme
    type IStyle = Styling.IStyle
    type IButtonStyles = Button.IButtonStyles
    type IPoint = Utilities.IPoint
    type IRectangle = Utilities.IRectangle
    type IRenderFunction = Utilities.IRenderFunction
    type IWithResponsiveModeState = __utilities_decorators_withResponsiveMode.IWithResponsiveModeState
    type IContextualMenuClassNames = __components_ContextualMenu_ContextualMenu_classNames.IContextualMenuClassNames
    type IMenuItemClassNames = __components_ContextualMenu_ContextualMenu_classNames.IMenuItemClassNames
    type IVerticalDividerClassNames = __components_Divider_VerticalDivider_types.IVerticalDividerClassNames
    type IContextualMenuItemProps = __components_ContextualMenu_ContextualMenuItem_types.IContextualMenuItemProps
    type IContextualMenuRenderItem = __components_ContextualMenu_ContextualMenuItem_types.IContextualMenuRenderItem
    type IKeytipProps = Keytip.IKeytipProps

    type [<RequireQualifiedAccess>] ContextualMenuItemType =
        | Normal = 0
        | Divider = 1
        | Header = 2
        | Section = 3

    type [<AllowNullLiteral>] IContextualMenu =
        interface end

    /// React.Props is deprecated and we're removing it in 6.0. Usage of 'any' should go away with it.
    type [<AllowNullLiteral>] IContextualMenuProps =
        inherit React.Props<obj option>
        inherit IWithResponsiveModeState
        /// Optional callback to access the IContextualMenu interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IContextualMenu option -> unit) option with get, set
        /// The target that the ContextualMenu should try to position itself based on.
        /// It can be either an Element a querySelector string of a valid Element
        /// or a MouseEvent. If MouseEvent is given then the origin point of the event will be used.
        abstract target: U4<Element, string, MouseEvent, IPoint> option with get, set
        /// How the element should be positioned
        abstract directionalHint: DirectionalHint option with get, set
        /// How the element should be positioned in RTL layouts.
        /// If not specified, a mirror of `directionalHint` will be used instead
        abstract directionalHintForRTL: DirectionalHint option with get, set
        /// The gap between the ContextualMenu and the target
        abstract gapSpace: float option with get, set
        /// The width of the beak.
        abstract beakWidth: float option with get, set
        /// If true the context menu will render as the same width as the target element
        abstract useTargetWidth: bool option with get, set
        /// If true the context menu will have a minimum width equal to the width of the target element
        abstract useTargetAsMinWidth: bool option with get, set
        /// The bounding rectangle for which the contextual menu can appear in.
        abstract bounds: IRectangle option with get, set
        /// If true use a point rather than rectangle to position the ContextualMenu.
        /// For example it can be used to position based on a click.
        abstract useTargetPoint: bool option with get, set
        /// Point used to position the ContextualMenu
        abstract targetPoint: IPoint option with get, set
        /// If true then the beak is visible. If false it will not be shown.
        abstract isBeakVisible: bool option with get, set
        /// If true the position returned will have the menu element cover the target.
        /// If false then it will position next to the target;
        abstract coverTarget: bool option with get, set
        /// Collection of menu items.
        abstract items: ResizeArray<IContextualMenuItem> with get, set
        /// Aria Labelled by labelElementId
        abstract labelElementId: string option with get, set
        /// Whether to focus on the menu when mounted.
        abstract shouldFocusOnMount: bool option with get, set
        /// Whether to focus on the contextual menu container (as opposed to the first menu item).
        abstract shouldFocusOnContainer: bool option with get, set
        /// Callback when the ContextualMenu tries to close. If dismissAll is true then all
        /// submenus will be dismissed.
        abstract onDismiss: (obj option -> bool -> unit) option with get, set
        /// Click handler which is invoked if onClick is not passed for individual contextual
        /// menu item.
        /// Returning true will dismiss the menu even if ev.preventDefault() was called.
        abstract onItemClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IContextualMenuItem -> U2<bool, unit>) option with get, set
        /// CSS class to apply to the context menu.
        abstract className: string option with get, set
        /// Whether this menu is a submenu of another menu or not.
        abstract isSubMenu: bool option with get, set
        /// DOM id to tag the ContextualMenu with, for reference.
        /// Should be used for 'aria-owns' and other such uses, rather than direct reference for programmatic purposes.
        abstract id: string option with get, set
        /// Aria label for accessibility for the ContextualMenu.
        /// If none specified no aria label will be applied to the ContextualMenu.
        abstract ariaLabel: string option with get, set
        /// If true do not render on a new layer. If false render on a new layer.
        abstract doNotLayer: bool option with get, set
        /// Direction for arrow navigation of the ContextualMenu. Should only be specified if using custom-rendered menu items.
        abstract arrowDirection: FocusZoneDirection option with get, set
        /// If true the position will not change sides in an attempt to fit the ContextualMenu within bounds.
        /// It will still attempt to align it to whatever bounds are given.
        abstract directionalHintFixed: bool option with get, set
        /// Callback for when the contextualmenu has been opened.
        abstract onMenuOpened: (IContextualMenuProps -> unit) option with get, set
        /// Callback for when the contextualmenu is being closed (removing from the DOM)
        abstract onMenuDismissed: (IContextualMenuProps -> unit) option with get, set
        /// Pass in custom callout props
        abstract calloutProps: ICalloutProps option with get, set
        /// Optional title to be displayed on top of the menu.
        abstract title: string option with get, set
        /// Custom styling for the contextual menu.
        abstract styles: IContextualMenuStyles option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Method to provide the classnames to style the contextual menu. Default value is the getMenuClassnames func
        /// defined in ContextualMenu.classnames.
        abstract getMenuClassNames: (ITheme -> string -> IContextualMenuClassNames) option with get, set
        /// Method to call when trying to render a submenu. 
        abstract onRenderSubMenu: IRenderFunction<IContextualMenuProps> option with get, set
        /// Delay (in milliseconds) to wait before expanding / dismissing a submenu on mouseEnter or mouseLeave
        abstract subMenuHoverDelay: float option with get, set
        /// Method to override the render of the individual menu items
        abstract contextualMenuItemAs: U2<React.ComponentClass<IContextualMenuItemProps>, React.StatelessComponent<IContextualMenuItemProps>> option with get, set
        /// Props to pass down to the FocusZone.
        /// NOTE: the default FocusZoneDirection will be used unless a direction
        /// is specified in the focusZoneProps (even if other focusZoneProps are defined)
        abstract focusZoneProps: IFocusZoneProps option with get, set
        /// If specified, renders the ContextualMenu in a hidden state.
        /// Use this flag, rather than rendering a ContextualMenu conditionally based on visibility,
        /// to improve rendering performance when it becomes visible.
        /// Note: When ContextualMenu is hidden its content will not be rendered. It will only render
        /// once the ContextualMenu is visible.
        abstract hidden: bool option with get, set

    type [<AllowNullLiteral>] IContextualMenuItem =
        /// Optional callback to access the IContextualMenuRenderItem interface. This will get passed down to ContextualMenuItem.
        abstract componentRef: (IContextualMenuRenderItem option -> unit) option with get, set
        /// Unique id to identify the item
        abstract key: string with get, set
        /// Text description for the menu item to display
        abstract name: string option with get, set
        /// Seconday description for the menu item to display
        abstract secondaryText: string option with get, set
        abstract itemType: ContextualMenuItemType option with get, set
        /// Props that go to the IconComponent
        abstract iconProps: IIconProps option with get, set
        /// Custom render function for the menu item icon
        abstract onRenderIcon: IRenderFunction<IContextualMenuItemProps> option with get, set
        /// Props that go to the IconComponent used for the chevron.
        abstract submenuIconProps: IIconProps option with get, set
        /// Deprecated at v0.69.0 and will no longer exist after 1.0 use IconProps instead.
        abstract icon: string option with get, set
        /// Whether the menu item is disabled
        abstract disabled: bool option with get, set
        /// If the menu item is a split button, this prop disables purely the primary action of the button.
        abstract primaryDisabled: bool option with get, set
        /// Deprecated at v0.65.1 and will be removed by v 1.0. Use 'disabled' instead.
        abstract isDisabled: bool option with get, set
        /// [TODO] Not Yet Implemented
        abstract shortCut: string option with get, set
        /// Whether or not this menu item can be checked
        abstract canCheck: bool option with get, set
        /// Whether or not this menu item is currently checked.
        abstract ``checked``: bool option with get, set
        /// Deprecated at v.65.1 and will be removed by v 1.0. Use 'checked' instead.
        abstract isChecked: bool option with get, set
        /// Whether or not this menu item is a splitButton.
        abstract split: bool option with get, set
        /// Any custom data the developer wishes to associate with the menu item.
        abstract data: obj option with get, set
        /// Callback issued when the menu item is invoked. If ev.preventDefault() is called in onClick, click will not close menu.
        /// Returning true will dismiss the menu even if ev.preventDefault() was called.
        abstract onClick: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> IContextualMenuItem -> U2<bool, unit>) option with get, set
        /// An optional URL to navigate to upon selection
        abstract href: string option with get, set
        /// An optional target when using href
        abstract target: string option with get, set
        /// An optional rel when using href. If target is _blank rel is defaulted to a value to prevent clickjacking.
        abstract rel: string option with get, set
        /// Deprecated at v.80.0 and will be removed by v 1.0. Use 'subMenuProps' instead.
        abstract items: ResizeArray<IContextualMenuItem> option with get, set
        /// Properties to apply to a submenu to this item.
        /// The ContextualMenu will provide default values for 'target', 'onDismiss', 'isSubMenu',
        ///   'id', 'shouldFocusOnMount', 'directionalHint', 'className', and 'gapSpace', all of which
        ///   can be overridden.
        abstract subMenuProps: IContextualMenuProps option with get, set
        /// Method to provide the classnames to style the individual items inside a menu. Default value is the getItemClassnames func
        /// defined in ContextualMenu.classnames.
        abstract getItemClassNames: (ITheme -> bool -> bool -> bool -> bool -> bool -> string -> string -> string -> string -> bool -> IMenuItemClassNames) option with get, set
        /// Method to provide the classnames to style the Vertical Divider of a split button inside a menu. Default value is the getVerticalDividerClassnames func defined in ContextualMenu.classnames
        abstract getSplitButtonVerticalDividerClassNames: (ITheme -> IVerticalDividerClassNames) option with get, set
        /// Properties to apply to render this item as a section.
        /// This prop is mutually exclusive with subMenuProps.
        abstract sectionProps: IContextualMenuSection option with get, set
        /// Additional css class to apply to the menu item
        abstract className: string option with get, set
        /// Additional styles to apply to the menu item
        abstract style: React.CSSProperties option with get, set
        /// Optional accessibility label (aria-label) attribute that will be stamped on to the element.
        /// If none is specified, the aria-label attribute will contain the item name
        abstract ariaLabel: string option with get, set
        /// Optional title for displaying text when hovering over an item.
        abstract title: string option with get, set
        /// Method to custom render this menu item.
        /// For keyboard accessibility, the top-level rendered item should be a focusable element
        /// (like an anchor or a button) or have the `data-is-focusable` property set to true.
        /// 
        /// The function receives a function that can be called to dismiss the menu as a second argument.
        ///   This can be used to make sure that a custom menu item click dismisses the menu.
        abstract onRender: (obj option -> (obj option -> bool -> unit) -> React.ReactNode) option with get, set
        /// A function to be executed onMouseDown. This is executed before an onClick event and can
        /// be used to interrupt native on click events as well. The click event should still handle
        /// the commands. This should only be used in special cases when react and non-react are mixed.
        abstract onMouseDown: (IContextualMenuItem -> obj option -> unit) option with get, set
        /// Optional override for the role attribute on the menu button. If one is not provided, it will
        /// have a value of menuitem or menuitemcheckbox.
        abstract role: string option with get, set
        /// When rendering a custom component that is passed in, the component might also be a list of
        /// elements. We want to keep track of the correct index our menu is using based off of
        /// the length of the custom list. It is up to the user to increment the count for their list.
        abstract customOnRenderListLength: float option with get, set
        /// Keytip for this contextual menu item
        abstract keytipProps: IKeytipProps option with get, set
        /// Any additional properties to use when custom rendering menu items.
        [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set
        /// Optional prop to make an item readonly which is disabled but visitable by keyboard, will apply aria-readonly and some styling. Not supported by all components
        abstract inactive: bool option with get, set

    /// React.Props is deprecated and we're removing it in 6.0. Usage of 'any' should go away with it.
    type [<AllowNullLiteral>] IContextualMenuSection =
        inherit React.Props<obj option>
        /// The items to include inside the section.
        abstract items: ResizeArray<IContextualMenuItem> with get, set
        /// The optional section title.
        abstract title: string option with get, set
        /// If set to true, the section will display a divider at the top of the section.
        abstract topDivider: bool option with get, set
        /// If set to true, the section will display a divider at the bottom of the section.
        abstract bottomDivider: bool option with get, set

    type [<AllowNullLiteral>] IMenuItemStyles =
        inherit IButtonStyles
        /// Styles for a menu item that is an anchor link.
        abstract item: IStyle with get, set
        /// Styles for the content inside the button/link of the menuItem.
        abstract linkContent: IStyle with get, set
        /// Styles for a menu item that is an anchor link.
        abstract anchorLink: IStyle with get, set
        /// Default icon color style for known icons.
        abstract iconColor: IStyle with get, set
        /// Default style for checkmark icons.
        abstract checkmarkIcon: IStyle with get, set
        /// Styles for the submenu icon of a menu item.
        abstract subMenuIcon: IStyle with get, set
        /// Styles for a divider item of a ConextualMenu.
        abstract divider: IStyle with get, set
        /// Styles for a split button divider in a menu item
        abstract splitButtonSeparator: IStyle with get, set

    type [<AllowNullLiteral>] IContextualMenuStyles =
        /// Style override for the contextual menu title.
        abstract title: IStyle with get, set
        /// Style for the container which parents all menu items.
        abstract container: IStyle with get, set
        /// Base styles for the root element of all ContextualMenus.
        abstract root: IStyle with get, set
        /// Styles for the header item of a ContextualMenu
        abstract header: IStyle with get, set
        /// Styles for the list that contains all menuItems.
        abstract list: IStyle with get, set

module __components_ContextualMenu_ContextualMenuItem =
    type BaseComponent = Utilities.BaseComponent
    type IContextualMenuItemProps = __components_ContextualMenu_ContextualMenuItem_types.IContextualMenuItemProps

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuItem: ContextualMenuItemStatic

    type [<AllowNullLiteral>] ContextualMenuItem =
        inherit BaseComponent<IContextualMenuItemProps, obj>
        abstract render: unit -> JSX.Element
        abstract openSubMenu: (unit -> unit) with get, set
        abstract dismissSubMenu: (unit -> unit) with get, set
        abstract dismissMenu: (bool option -> unit) with get, set

    type [<AllowNullLiteral>] ContextualMenuItemStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuItem

module __components_ContextualMenu_ContextualMenuItem_types =
    type IContextualMenuItem = __components_ContextualMenu_ContextualMenu_types.IContextualMenuItem
    type IMenuItemClassNames = __components_ContextualMenu_ContextualMenu_classNames.IMenuItemClassNames

    type [<AllowNullLiteral>] IContextualMenuRenderItem =
        /// Function to open this item's subMenu, if present.
        abstract openSubMenu: (unit -> unit) with get, set
        /// Function to close this item's subMenu, if present.
        abstract dismissSubMenu: (unit -> unit) with get, set
        /// Dismiss the menu this item belongs to.
        abstract dismissMenu: (bool -> unit) with get, set

    type [<AllowNullLiteral>] IContextualMenuItemProps =
        inherit React.HTMLAttributes<IContextualMenuItemProps>
        /// Optional callback to access the IContextualMenuRenderItem interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IContextualMenuRenderItem option -> unit) option with get, set
        /// The item to display
        abstract item: IContextualMenuItem with get, set
        /// Classnames for different aspects of a menu item
        abstract classNames: IMenuItemClassNames with get, set
        /// Index of the item
        abstract index: float with get, set
        /// If this item has icons
        abstract hasIcons: bool option with get, set
        /// Click handler for the checkmark
        abstract onCheckmarkClick: (IContextualMenuItem -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        /// This prop will get set by ContextualMenu and can be called to open this item's subMenu, if present.
        abstract openSubMenu: (obj option -> HTMLElement -> unit) option with get, set
        /// This prop will get set by ContextualMenu and can be called to close this item's subMenu, if present.
        abstract dismissSubMenu: (unit -> unit) option with get, set
        /// This prop will get set by ContextualMenu and can be called to close the menu this item belongs to.
        /// If dismissAll is true, all menus will be closed.
        abstract dismissMenu: (obj option -> bool -> unit) option with get, set
        /// This prop will get set by the wrapping component and will return the element that wraps this ContextualMenuItem.
        /// Used for openSubMenu.
        abstract getSubmenuTarget: (unit -> HTMLElement option) option with get, set

module __components_ContextualMenu_ContextualMenuPage =
    type IComponentDemoPageProps = __components_ContextualMenu_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuPage: ContextualMenuPageStatic

    type [<AllowNullLiteral>] ContextualMenuPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuPage

module __components_DatePicker_DatePicker_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerStatus: obj

module __components_DatePicker_DatePicker =
    type IDatePicker = __components_DatePicker_DatePicker_types.IDatePicker
    type IDatePickerProps = __components_DatePicker_DatePicker_types.IDatePickerProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DatePicker: DatePickerStatic

    type [<AllowNullLiteral>] IDatePickerState =
        abstract selectedDate: DateTime option with get, set
        abstract formattedDate: string option with get, set
        abstract isDatePickerShown: bool option with get, set
        abstract errorMessage: string option with get, set

    type [<AllowNullLiteral>] DatePicker =
        inherit BaseComponent<IDatePickerProps, IDatePickerState>
        inherit IDatePicker
        abstract defaultProps: IDatePickerProps with get, set
        abstract _calendar: obj with get, set
        abstract _datePickerDiv: obj with get, set
        abstract _textField: obj with get, set
        abstract _preventFocusOpeningPicker: obj with get, set
        abstract componentWillReceiveProps: nextProps: IDatePickerProps -> unit
        abstract componentDidUpdate: prevProps: IDatePickerProps * prevState: IDatePickerState -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract reset: unit -> unit
        abstract _onSelectDate: obj with get, set
        abstract _onCalloutPositioned: obj with get, set
        abstract _onTextFieldFocus: obj with get, set
        abstract _onTextFieldBlur: obj with get, set
        abstract _onTextFieldChanged: obj with get, set
        abstract _onTextFieldKeyDown: obj with get, set
        abstract _onTextFieldClick: obj with get, set
        abstract _onIconClick: obj with get, set
        abstract _showDatePickerPopup: unit -> unit
        abstract _dismissDatePickerPopup: obj with get, set
        /// Callback for closing the calendar callout
        abstract _calendarDismissed: obj with get, set
        abstract _handleEscKey: obj with get, set
        abstract _validateTextInput: obj with get, set
        abstract _getDefaultState: ?props: obj -> unit
        abstract _isDateOutOfBounds: date: obj * ?minDate: obj * ?maxDate: obj -> unit

    type [<AllowNullLiteral>] DatePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDatePickerProps -> DatePicker

module __components_DatePicker_DatePicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract textField: obj
        abstract eventWithLabel: obj
        abstract msDatePickerDisabled: obj
        abstract eventWithoutLabel: obj

module __components_DatePicker_DatePicker_types =
    type DatePicker = __components_DatePicker_DatePicker.DatePicker
    type DayOfWeek = Calendar.DayOfWeek
    type ICalendarProps = Calendar.ICalendarProps
    type FirstWeekOfYear = __utilities_dateValues_DateValues.FirstWeekOfYear
    type ICalendarFormatDateCallbacks = __components_Calendar_Calendar_types.ICalendarFormatDateCallbacks

    type [<AllowNullLiteral>] IDatePicker =
        /// Sets focus to the text field 
        abstract focus: unit -> unit
        /// Reset the state of the picker to the default 
        abstract reset: unit -> unit

    type [<AllowNullLiteral>] IDatePickerProps =
        inherit React.Props<DatePicker>
        /// Optional callback to access the IDatePicker interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IDatePicker option -> unit) option with get, set
        /// Pass calendar props to calendar component
        abstract calendarProps: ICalendarProps option with get, set
        /// Callback issued when a date is selected
        abstract onSelectDate: (DateTime option -> unit) option with get, set
        /// Label for the DatePicker
        abstract label: string option with get, set
        /// Whether the DatePicker is a required field or not
        abstract isRequired: bool option with get, set
        /// Disabled state of the DatePicker.
        abstract disabled: bool option with get, set
        /// Aria Label for TextField of the DatePicker for screen reader users.
        abstract ariaLabel: string option with get, set
        /// Aria label for date picker popup for screen reader users.
        abstract pickerAriaLabel: string option with get, set
        /// Whether the month picker is shown beside the day picker or hidden.
        abstract isMonthPickerVisible: bool option with get, set
        /// Show month picker on top of date picker when visible.
        abstract showMonthPickerAsOverlay: bool option with get, set
        /// Whether the DatePicker allows input a date string directly or not
        abstract allowTextInput: bool option with get, set
        /// Whether the DatePicker should open automatically when the control is focused
        abstract disableAutoFocus: bool option with get, set
        /// Placeholder text for the DatePicker
        abstract placeholder: string option with get, set
        /// Value of today. If null, current time in client machine will be used.
        abstract today: DateTime option with get, set
        /// Default value of the DatePicker, if any
        abstract value: DateTime option with get, set
        /// Optional method to format the chosen date to a string to display in the DatePicker
        abstract formatDate: (DateTime -> string) option with get, set
        /// Optional method to parse the text input value to date, it is only useful when allowTextInput is set to true
        abstract parseDateFromString: (string -> DateTime option) option with get, set
        /// The first day of the week for your locale.
        abstract firstDayOfWeek: DayOfWeek option with get, set
        /// Localized strings to use in the DatePicker
        abstract strings: IDatePickerStrings option with get, set
        /// Whether the month picker should highlight the current month
        abstract highlightCurrentMonth: bool option with get, set
        /// Whether the month picker should highlight the selected month
        abstract highlightSelectedMonth: bool option with get, set
        /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
        abstract showWeekNumbers: bool option with get, set
        /// Defines when the first week of the year should start, FirstWeekOfYear.FirstDay,
        /// FirstWeekOfYear.FirstFullWeek or FirstWeekOfYear.FirstFourDayWeek are the possible values
        abstract firstWeekOfYear: FirstWeekOfYear option with get, set
        /// Whether the "Go to today" link should be shown or not
        abstract showGoToToday: bool option with get, set
        /// Determines if DatePicker has a border.
        abstract borderless: bool option with get, set
        /// Optional Classname for datepicker root element .
        abstract className: string option with get, set
        /// Apply additional formating to dates, for example localized date formatting.
        abstract dateTimeFormatter: ICalendarFormatDateCallbacks option with get, set
        /// The minimum allowable date.
        abstract minDate: DateTime option with get, set
        /// The maximum allowable date.
        abstract maxDate: DateTime option with get, set
        /// The initially highlighted date in the calendar picker
        abstract initialPickerDate: DateTime option with get, set
        /// Callback that runs after DatePicker's menu (Calendar) is closed
        abstract onAfterMenuDismiss: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] IDatePickerStrings =
        /// An array of strings for the full names of months.
        /// The array is 0-based, so months[0] should be the full name of January.
        abstract months: ResizeArray<string> with get, set
        /// An array of strings for the short names of months.
        /// The array is 0-based, so shortMonths[0] should be the short name of January.
        abstract shortMonths: ResizeArray<string> with get, set
        /// An array of strings for the full names of days of the week.
        /// The array is 0-based, so days[0] should be the full name of Sunday.
        abstract days: ResizeArray<string> with get, set
        /// An array of strings for the initials of the days of the week.
        /// The array is 0-based, so days[0] should be the initial of Sunday.
        abstract shortDays: ResizeArray<string> with get, set
        /// String to render for button to direct the user to today's date.
        abstract goToToday: string with get, set
        /// Error message to render for TextField if isRequired validation fails.
        abstract isRequiredErrorMessage: string option with get, set
        /// Error message to render for TextField if input date string parsing fails.
        abstract invalidInputErrorMessage: string option with get, set
        /// Error message to render for TextField if date boundary (minDate, maxDate) validation fails.
        abstract isOutOfBoundsErrorMessage: string option with get, set
        /// Aria-label for the "previous month" button.
        abstract prevMonthAriaLabel: string option with get, set
        /// Aria-label for the "next month" button.
        abstract nextMonthAriaLabel: string option with get, set
        /// Aria-label for the "previous year" button.
        abstract prevYearAriaLabel: string option with get, set
        /// Aria-label for the "next year" button.
        abstract nextYearAriaLabel: string option with get, set

module __components_DatePicker_DatePickerPage =
    type IComponentDemoPageProps = __components_DatePicker_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerPage: DatePickerPageStatic

    type [<AllowNullLiteral>] DatePickerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DatePickerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DatePickerPage

module __components_DetailsList_DetailsColumn =
    type BaseComponent = Utilities.BaseComponent
    type IRenderFunction = Utilities.IRenderFunction
    type IColumn = __components_DetailsList_DetailsList_types.IColumn
    type ITooltipHostProps = Tooltip.ITooltipHostProps
    type IDragDropHelper = __utilities_dragdrop_interfaces.IDragDropHelper

    type [<AllowNullLiteral>] IExports =
        abstract DetailsColumn: DetailsColumnStatic

    type [<AllowNullLiteral>] IDetailsColumnProps =
        inherit React.Props<DetailsColumn>
        abstract componentRef: (unit -> unit) option with get, set
        abstract column: IColumn with get, set
        abstract columnIndex: float with get, set
        abstract parentId: string option with get, set
        abstract onRenderColumnHeaderTooltip: IRenderFunction<ITooltipHostProps> option with get, set
        abstract onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> unit) option with get, set
        abstract onColumnContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        abstract dragDropHelper: IDragDropHelper option with get, set
        abstract isDraggable: bool option with get, set
        abstract setDraggedItemIndex: (float -> unit) option with get, set
        abstract isDropped: bool option with get, set

    type [<AllowNullLiteral>] DetailsColumn =
        inherit BaseComponent<IDetailsColumnProps>
        abstract _root: obj with get, set
        abstract _dragDropSubscription: obj with get, set
        abstract render: unit -> ResizeArray<JSX.Element option>
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract _onRenderColumnHeaderTooltip: obj with get, set
        abstract _onColumnClick: column: obj * ev: obj -> unit
        abstract _getColumnDragDropOptions: unit -> unit
        abstract _onDragStart: ?item: obj * ?itemIndex: obj * ?selectedItems: obj * ?``event``: obj -> unit
        abstract _onDragEnd: ?item: obj * ?``event``: obj -> unit
        abstract _onColumnContextMenu: column: obj * ev: obj -> unit
        abstract _onRootMouseDown: ev: obj -> unit

    type [<AllowNullLiteral>] DetailsColumnStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDetailsColumnProps -> DetailsColumn

module __components_DetailsList_DetailsHeader =
    type BaseComponent = Utilities.BaseComponent
    type IRenderFunction = Utilities.IRenderFunction
    type IColumn = __components_DetailsList_DetailsList_types.IColumn
    type DetailsListLayoutMode = __components_DetailsList_DetailsList_types.DetailsListLayoutMode
    type IColumnReorderOptions = __components_DetailsList_DetailsList_types.IColumnReorderOptions
    type CollapseAllVisibility = GroupedList.CollapseAllVisibility
    type ITooltipHostProps = Tooltip.ITooltipHostProps
    type ISelection = __utilities_selection_interfaces.ISelection
    type SelectionMode = __utilities_selection_interfaces.SelectionMode

    type [<AllowNullLiteral>] IExports =
        abstract DetailsHeader: DetailsHeaderStatic

    type [<AllowNullLiteral>] IDetailsHeader =
        abstract focus: (unit -> bool) with get, set

    type [<AllowNullLiteral>] IDetailsHeaderProps =
        inherit React.Props<DetailsHeader>
        abstract componentRef: (IDetailsHeader option -> unit) option with get, set
        abstract columns: ResizeArray<IColumn> with get, set
        abstract selection: ISelection with get, set
        abstract selectionMode: SelectionMode with get, set
        abstract layoutMode: DetailsListLayoutMode with get, set
        abstract onColumnIsSizingChanged: (IColumn -> bool -> unit) option with get, set
        abstract onColumnResized: (IColumn -> float -> float -> unit) option with get, set
        abstract onColumnAutoResized: (IColumn -> float -> unit) option with get, set
        abstract onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> unit) option with get, set
        abstract onColumnContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        abstract onRenderColumnHeaderTooltip: IRenderFunction<ITooltipHostProps> option with get, set
        abstract groupNestingDepth: float option with get, set
        abstract collapseAllVisibility: CollapseAllVisibility option with get, set
        abstract isAllCollapsed: bool option with get, set
        abstract onToggleCollapseAll: (bool -> unit) option with get, set
        /// ariaLabel for the entire header 
        abstract ariaLabel: string option with get, set
        /// ariaLabel for the header checkbox that selects or deselects everything 
        abstract ariaLabelForSelectAllCheckbox: string option with get, set
        abstract ariaLabelForSelectionColumn: string option with get, set
        abstract selectAllVisibility: SelectAllVisibility option with get, set
        abstract columnReorderOptions: IColumnReorderOptions option with get, set
        abstract minimumPixelsForDrag: float option with get, set

    type [<RequireQualifiedAccess>] SelectAllVisibility =
        | None = 0
        | Hidden = 1
        | Visible = 2

    type [<AllowNullLiteral>] IDetailsHeaderState =
        abstract columnResizeDetails: IColumnResizeDetails option with get, set
        abstract isAllSelected: bool option with get, set
        abstract isSizing: bool option with get, set
        abstract groupNestingDepth: float option with get, set
        abstract isAllCollapsed: bool option with get, set

    type [<AllowNullLiteral>] IColumnResizeDetails =
        abstract columnIndex: float with get, set
        abstract originX: float option with get, set
        abstract columnMinWidth: float with get, set

    type [<AllowNullLiteral>] IDropHintDetails =
        abstract originX: float with get, set
        abstract startX: float with get, set
        abstract endX: float with get, set
        abstract dropHintElementRef: HTMLElement with get, set

    type [<AllowNullLiteral>] DetailsHeader =
        inherit BaseComponent<IDetailsHeaderProps, IDetailsHeaderState>
        inherit IDetailsHeader
        abstract defaultProps: obj with get, set
        abstract _rootElement: obj with get, set
        abstract _rootComponent: obj with get, set
        abstract _id: obj with get, set
        abstract _draggedColumnIndex: obj with get, set
        abstract _dropHintDetails: obj with get, set
        abstract _dragDropHelper: obj with get, set
        abstract _currentDropHintIndex: obj with get, set
        abstract _subscriptionObject: obj with get, set
        abstract _onDropIndexInfo: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: prevProps: IDetailsHeaderProps -> unit
        abstract componentWillReceiveProps: newProps: IDetailsHeaderProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        /// Set focus to the active thing in the focus area. 
        abstract focus: unit -> bool
        abstract _getHeaderDragDropOptions: unit -> unit
        abstract _updateDroppingState: newValue: obj * ``event``: obj -> unit
        abstract _isValidCurrentDropHintIndex: unit -> unit
        abstract _onDragOver: item: obj * ``event``: obj -> unit
        abstract _onDrop: ?item: obj * ?``event``: obj -> unit
        abstract _setDraggedItemIndex: itemIndex: obj -> unit
        abstract _resetDropHints: unit -> unit
        abstract _updateDropHintElement: element: obj * property: obj -> unit
        abstract _getDropHintPositions: unit -> unit
        /// Based on the given cursor position, finds the nearest drop hint and updates the state to make it visible
        abstract _computeDropHintToBeShown: clientX: obj -> unit
        abstract _renderColumnSizer: columnIndex: obj -> unit
        abstract _renderDropHint: dropHintIndex: obj -> unit
        abstract _onRenderColumnHeaderTooltip: obj with get, set
        /// <summary>double click on the column sizer will auto ajust column width
        /// to fit the longest content among current rendered rows.</summary>
        /// <param name="columnIndex">(index of the column user double clicked)</param>
        /// <param name="ev">(mouse double click event)</param>
        abstract _onSizerDoubleClick: columnIndex: obj * ev: obj -> unit
        /// Called when the select all toggle is clicked.
        abstract _onSelectAllClicked: obj with get, set
        abstract _onRootMouseDown: obj with get, set
        abstract _onRootMouseMove: obj with get, set
        abstract _onRootRef: obj with get, set
        abstract _onRootKeyDown: obj with get, set
        /// mouse move event handler in the header
        /// it will set isSizing state to true when user clicked on the sizer and move the mouse.
        abstract _onSizerMouseMove: obj with get, set
        abstract _onSizerBlur: obj with get, set
        /// mouse up event handler in the header
        /// clear the resize related state.
        /// This is to ensure we can catch double click event
        abstract _onSizerMouseUp: obj with get, set
        abstract _onSelectionChanged: unit -> unit
        abstract _onToggleCollapseAll: unit -> unit

    type [<AllowNullLiteral>] DetailsHeaderStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDetailsHeaderProps -> DetailsHeader

module __components_DetailsList_DetailsHeader_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract rootIsSelectAllHidden: obj
        abstract cell: obj
        abstract cellIsCheck: obj
        abstract cellWrapperPadded: obj
        abstract cellIsActionable: obj
        abstract cellIsEmpty: obj
        abstract gripperBarVerticalStyle: obj
        abstract cellSizer: obj
        abstract cellIsResizing: obj
        abstract cellSizerStart: obj
        abstract cellSizerEnd: obj
        abstract collapseButton: obj
        abstract collapseButtonIsCollapsed: obj
        abstract iconOnlyHeader: obj
        abstract nearIcon: obj
        abstract sortIcon: obj
        abstract filterChevron: obj
        abstract cellTitle: obj
        abstract cellName: obj
        abstract checkTooltip: obj
        abstract cellTooltip: obj
        abstract sizingOverlay: obj
        abstract accessibleLabel: obj
        abstract borderWhileDragging: obj
        abstract fadeOut: obj
        abstract dropHintCircleStyle: obj
        abstract dropHintLineStyle: obj
        abstract dropHintStyle: obj
        abstract borderAfterDropping: obj

module __components_DetailsList_DetailsList_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListStatus: obj

module __components_DetailsList_DetailsList =
    type BaseComponent = Utilities.BaseComponent
    type CheckboxVisibility = __components_DetailsList_DetailsList_types.CheckboxVisibility
    type ConstrainMode = __components_DetailsList_DetailsList_types.ConstrainMode
    type DetailsListLayoutMode = __components_DetailsList_DetailsList_types.DetailsListLayoutMode
    type IColumn = __components_DetailsList_DetailsList_types.IColumn
    type IDetailsList = __components_DetailsList_DetailsList_types.IDetailsList
    type IDetailsListProps = __components_DetailsList_DetailsList_types.IDetailsListProps
    type IDetailsRowProps = __components_DetailsList_DetailsRow.IDetailsRowProps
    type SelectionMode = __utilities_selection_index.SelectionMode
    type ScrollToMode = List.ScrollToMode

    type [<AllowNullLiteral>] IExports =
        abstract DetailsList: DetailsListStatic
        abstract buildColumns: items: ResizeArray<obj option> * ?canResizeColumns: bool * ?onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> obj option) * ?sortedColumnKey: string * ?isSortedDescending: bool * ?groupedColumnKey: string * ?isMultiline: bool -> ResizeArray<IColumn>

    type [<AllowNullLiteral>] IDetailsListState =
        abstract focusedItemIndex: float with get, set
        abstract lastWidth: float option with get, set
        abstract lastSelectionMode: SelectionMode option with get, set
        abstract adjustedColumns: ResizeArray<IColumn> option with get, set
        abstract isCollapsed: bool option with get, set
        abstract isSizing: bool option with get, set
        abstract isDropping: bool option with get, set
        abstract isSomeGroupExpanded: bool option with get, set

    type [<AllowNullLiteral>] DetailsList =
        inherit BaseComponent<IDetailsListProps, IDetailsListState>
        inherit IDetailsList
        abstract defaultProps: obj with get, set
        abstract _root: obj with get, set
        abstract _header: obj with get, set
        abstract _groupedList: obj with get, set
        abstract _list: obj with get, set
        abstract _focusZone: obj with get, set
        abstract _selectionZone: obj with get, set
        abstract _selection: obj with get, set
        abstract _activeRows: obj with get, set
        abstract _dragDropHelper: obj with get, set
        abstract _initialFocusedIndex: obj with get, set
        abstract _pendingForceUpdate: obj with get, set
        abstract _columnOverrides: obj with get, set
        abstract scrollToIndex: index: float * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
        abstract focusIndex: index: float * ?forceIntoFirstElement: bool * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentDidUpdate: prevProps: obj option * prevState: obj option -> unit
        abstract componentWillReceiveProps: newProps: IDetailsListProps -> unit
        abstract componentWillUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract forceUpdate: unit -> unit
        abstract _onRenderRow: (IDetailsRowProps -> obj option -> JSX.Element) with get, set
        abstract _onRenderDetailsHeader: obj with get, set
        abstract _onRenderListCell: obj with get, set
        abstract _onRenderCell: nestingDepth: obj * item: obj * index: obj -> unit
        abstract _onGroupExpandStateChanged: isSomeGroupExpanded: obj -> unit
        abstract _onColumnIsSizingChanged: column: obj * isSizing: obj -> unit
        abstract _onHeaderKeyDown: ev: obj -> unit
        abstract _onContentKeyDown: ev: obj -> unit
        abstract _getGroupNestingDepth: unit -> unit
        abstract _onRowDidMount: row: obj -> unit
        abstract _setFocusToRowIfPending: row: obj -> unit
        abstract _setFocusToRow: row: obj * ?forceIntoFirstElement: obj -> unit
        abstract _onRowWillUnmount: row: obj -> unit
        abstract _onToggleCollapse: collapsed: obj -> unit
        abstract _forceListUpdates: unit -> unit
        abstract _adjustColumns: newProps: obj * ?forceUpdate: obj * ?resizingColumnIndex: obj -> unit
        /// Returns adjusted columns, given the viewport size and layout mode. 
        abstract _getAdjustedColumns: newProps: obj * ?forceUpdate: obj * ?resizingColumnIndex: obj -> unit
        /// Builds a set of columns based on the given columns mixed with the current overrides. 
        abstract _getFixedColumns: newColumns: obj -> unit
        abstract _getJustifiedColumnsAfterResize: newColumns: obj * viewportWidth: obj * props: obj * resizingColumnIndex: obj -> unit
        /// Builds a set of columns to fix within the viewport width. 
        abstract _getJustifiedColumns: newColumns: obj * viewportWidth: obj * props: obj * firstIndex: obj -> unit
        abstract _onColumnResized: resizingColumn: obj * newWidth: obj * resizingColumnIndex: obj -> unit
        abstract _rememberCalculatedWidth: column: obj * newCalculatedWidth: obj -> unit
        abstract _getColumnOverride: key: obj -> unit
        /// <summary>Callback function when double clicked on the details header column resizer
        /// which will measure the column cells of all the active rows and resize the
        /// column to the max cell width.</summary>
        /// <param name="column">(double clicked column definition)</param>
        /// <param name="columnIndex">(double clicked column index)</param>
        abstract _onColumnAutoResized: column: obj * columnIndex: obj -> unit
        /// Call back function when an element in FocusZone becomes active. It will transalate it into item
        /// and call onActiveItemChanged callback if specified.
        abstract _onActiveRowChanged: ?el: obj * ?ev: obj -> unit
        abstract _onBlur: ``event``: obj -> unit
        abstract _getItemKey: item: obj * itemIndex: obj -> unit

    type [<AllowNullLiteral>] DetailsListStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDetailsListProps -> DetailsList

module __components_DetailsList_DetailsList_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract focusZone: obj
        abstract rootIsHorizontalConstrained: obj
        abstract rootCompact: obj

module __components_DetailsList_DetailsList_types =
    type DetailsList = __components_DetailsList_DetailsList.DetailsList
    type ISelection = __utilities_selection_index.ISelection
    type SelectionMode = __utilities_selection_index.SelectionMode
    type ISelectionZoneProps = __utilities_selection_index.ISelectionZoneProps
    type IRenderFunction = Utilities.IRenderFunction
    type IDragDropEvents = __utilities_dragdrop_index.IDragDropEvents
    type IDragDropContext = __utilities_dragdrop_index.IDragDropContext
    type IGroup = __components_GroupedList_index.IGroup
    type IGroupRenderProps = __components_GroupedList_index.IGroupRenderProps
    type IDetailsRowProps = __components_DetailsList_DetailsRow.IDetailsRowProps
    type IDetailsHeaderProps = __components_DetailsList_DetailsHeader.IDetailsHeaderProps
    type IWithViewportProps = __utilities_decorators_withViewport.IWithViewportProps
    type IViewport = __utilities_decorators_withViewport.IViewport
    type IList = __components_List_index.IList
    type IListProps = __components_List_index.IListProps
    type ScrollToMode = __components_List_index.ScrollToMode

    type [<AllowNullLiteral>] IDetailsList =
        inherit IList
        /// Ensures that the list content is updated. Call this in cases where the list prop updates don't change, but the list
        /// still needs to be re-evaluated. For example, if a sizer bar is adjusted and causes the list width to change, you can
        /// call this to force a re-evaluation. Be aware that this can be an expensive operation and should be done sparingly.
        abstract forceUpdate: (unit -> unit) with get, set
        /// Scroll to and focus the item at the given index. focusIndex will call scrollToIndex on the specified index.
        abstract focusIndex: (float -> bool -> (float -> float) -> ScrollToMode -> unit) with get, set

    type [<AllowNullLiteral>] IDetailsListProps =
        inherit React.Props<DetailsList>
        inherit IWithViewportProps
        /// Optional callback to access the IDetailsList interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IDetailsList option -> unit) option with get, set
        /// A key that uniquely identifies the given items. If provided, the selection will be reset when the key changes. 
        abstract setKey: string option with get, set
        /// The items to render. 
        abstract items: ResizeArray<obj option> with get, set
        /// Optional properties to pass through to the list components being rendered. 
        abstract listProps: IListProps option with get, set
        /// Optional default focused index to set focus to once the items have rendered and the index exists.
        abstract initialFocusedIndex: float option with get, set
        /// Optional class name to add to the root element. 
        abstract className: string option with get, set
        /// Optional grouping instructions. The definition for IGroup can be found under the GroupedList component. 
        abstract groups: ResizeArray<IGroup> option with get, set
        /// Optional override properties to render groups. The definition for IGroupRenderProps can be found under the GroupedList component. 
        abstract groupProps: IGroupRenderProps option with get, set
        /// Optional selection model to track selection state.  
        abstract selection: ISelection option with get, set
        /// Controls how/if the details list manages selection. Options include none, single, multiple 
        abstract selectionMode: SelectionMode option with get, set
        /// By default, selection is cleared when clicking on an empty (non-focusable) section of the screen. Setting this value to true
        /// overrides that behavior and maintains selection.
        abstract selectionPreservedOnEmptyClick: bool option with get, set
        /// Addition props to pass through to the selection zone created by default.
        abstract selectionZoneProps: ISelectionZoneProps option with get, set
        /// Controls how the columns are adjusted. 
        abstract layoutMode: DetailsListLayoutMode option with get, set
        /// Controls the visibility of selection check box.
        abstract checkboxVisibility: CheckboxVisibility option with get, set
        /// Controls the visibility of the details header.
        abstract isHeaderVisible: bool option with get, set
        /// Given column defitions. If none are provided, default columns will be created based on the item's properties. 
        abstract columns: ResizeArray<IColumn> option with get, set
        /// Controls how the list contrains overflow. 
        abstract constrainMode: ConstrainMode option with get, set
        /// Event names and corresponding callbacks that will be registered to rendered row elements. 
        abstract rowElementEventMap: ResizeArray<obj> option with get, set
        /// Callback for when the details list has been updated. Useful for telemetry tracking externally. 
        abstract onDidUpdate: (DetailsList -> obj option) option with get, set
        /// Callback for when a given row has been mounted. Useful for identifying when a row has been rendered on the page. 
        abstract onRowDidMount: (obj option -> float -> unit) option with get, set
        /// Callback for when a given row has been mounted. Useful for identifying when a row has been removed from the page. 
        abstract onRowWillUnmount: (obj option -> float -> unit) option with get, set
        /// Callback for when the user clicks on the column header. 
        abstract onColumnHeaderClick: (React.MouseEvent<HTMLElement> -> IColumn -> unit) option with get, set
        /// Callback for when the user asks for a contextual menu (usually via right click) from a column header. 
        abstract onColumnHeaderContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        /// Callback fired on column resize 
        abstract onColumnResize: (IColumn -> float -> float -> unit) option with get, set
        /// Callback for when a given row has been invoked (by pressing enter while it is selected.) 
        abstract onItemInvoked: (obj option -> float -> Event -> unit) option with get, set
        /// Callback for when the context menu of an item has been accessed. If undefined or false are returned, ev.preventDefault() will be called.
        abstract onItemContextMenu: (obj option -> float -> Event -> U2<unit, bool>) option with get, set
        /// If provided, will allow the caller to override the default row rendering.
        abstract onRenderRow: IRenderFunction<IDetailsRowProps> option with get, set
        /// If provided, will be the "default" item column renderer method. This affects cells within the rows; not the rows themselves.
        /// If a column definition provides its own onRender method, that will be used instead of this.
        abstract onRenderItemColumn: (obj option -> float -> IColumn -> obj option) option with get, set
        /// Map of callback functions related to row drag and drop functionality. 
        abstract dragDropEvents: IDragDropEvents option with get, set
        /// Callback for what to render when the item is missing. 
        abstract onRenderMissingItem: (float -> IDetailsRowProps -> React.ReactNode) option with get, set
        /// If set to true and we provide an empty array, it will render 10 lines of whatever provided in onRenderMissingItem.
        abstract enableShimmer: bool option with get, set
        /// An override to render the details header.
        abstract onRenderDetailsHeader: IRenderFunction<IDetailsHeaderProps> option with get, set
        /// Viewport, provided by the withViewport decorator. 
        abstract viewport: IViewport option with get, set
        /// Callback for when an item in the list becomes active by clicking anywhere inside the row or navigating to it with keyboard. 
        abstract onActiveItemChanged: (obj option -> float -> React.FocusEvent<HTMLElement> -> unit) option with get, set
        /// The aria-label attribute to stamp out on the list header 
        abstract ariaLabelForListHeader: string option with get, set
        /// The aria-label attribute to stamp out on select all checkbox for the list 
        abstract ariaLabelForSelectAllCheckbox: string option with get, set
        /// An ARIA label for the name of the selection column, for localization.
        abstract ariaLabelForSelectionColumn: string option with get, set
        /// Optional callback to get the aria-label string for a given item. 
        abstract getRowAriaLabel: (obj option -> string) option with get, set
        /// Optional callback to get the aria-describedby IDs (space separated strings) of the elements that describe the item. 
        abstract getRowAriaDescribedBy: (obj option -> string) option with get, set
        /// Optional callback to get the item key, to be used in the selection and on render. 
        abstract getKey: (obj option -> float -> string) option with get, set
        /// A text summary of the table set via aria-label. 
        abstract ariaLabel: string option with get, set
        /// Check button aria label for details list. 
        abstract checkButtonAriaLabel: string option with get, set
        /// Aria label for grid in details list. 
        abstract ariaLabelForGrid: string option with get, set
        /// Boolean value to indicate if the role application should be applied on details list. Set to false by default 
        abstract shouldApplyApplicationRole: bool option with get, set
        /// The minimum mouse move distance to interpret the action as drag event.
        abstract minimumPixelsForDrag: float option with get, set
        /// Boolean value to indicate if the component should render in compact mode. Set to false by default 
        abstract compact: bool option with get, set
        /// Boolean value to enable render page caching. This is an experimental performance optimization
        /// that is off by default.
        abstract usePageCache: bool option with get, set
        /// Optional callback to determine whether the list should be rendered in full, or virtualized.
        /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
        /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
        /// The default implementation will virtualize when this callback is not provided.
        abstract onShouldVirtualize: (IListProps -> bool) option with get, set
        /// Optional class name to add to the cell of a checkbox
        abstract checkboxCellClassName: string option with get, set
        /// Whether or not the selection zone should enter modal state on touch.
        abstract enterModalSelectionOnTouch: bool option with get, set
        /// Options for column re-order using drag and drop
        abstract columnReorderOptions: IColumnReorderOptions option with get, set

    type [<AllowNullLiteral>] IColumn =
        /// A unique key for identifying the column.
        abstract key: string with get, set
        /// Name to render on the column header.
        abstract name: string with get, set
        /// The field to pull the text value from for the column. This can be null if a custom
        /// onRender method is provided.
        abstract fieldName: string with get, set
        /// An optional class name to stick on the column cell within each row.
        abstract className: string option with get, set
        /// Minimum width for the column.
        abstract minWidth: float with get, set
        /// Optional accessibility label (aria-label) attribute that will be stamped on to the element.
        /// If none is specified, the arai-label attribute will contain the column name
        abstract ariaLabel: string option with get, set
        /// Optional flag on whether the column is a header for the given row. There should be only one column with
        /// row header set to true.
        abstract isRowHeader: bool option with get, set
        /// Maximum width for the column, if stretching is allowed in justified scenarios.
        abstract maxWidth: float option with get, set
        /// Defines how the column's header should render.
        abstract columnActionsMode: ColumnActionsMode option with get, set
        /// Optional iconName to use for the column header.
        abstract iconName: string option with get, set
        /// Whether or not only the icon is used in the column header.
        /// Set this to true so the column name and dropdown chevron are not displayed.
        abstract isIconOnly: bool option with get, set
        /// Class name to add to the Icon component.
        abstract iconClassName: string option with get, set
        /// If specified will allow the column to be collapsed when rendered in justified layout.
        abstract isCollapsable: bool option with get, set
        /// Determines if the column is currently sorted. Renders a sort arrow in the column header.
        abstract isSorted: bool option with get, set
        /// Determines if the arrow is pointed down (descending) or up.
        abstract isSortedDescending: bool option with get, set
        /// Determines if the column can be resized.
        abstract isResizable: bool option with get, set
        /// Determines if the column can render multi-line text.
        abstract isMultiline: bool option with get, set
        /// If provided uses this method to render custom cell content, rather than the default text rendering.
        abstract onRender: (obj option -> float -> IColumn -> obj option) option with get, set
        /// Determines if the column is filtered, and if so shows a filter icon.
        abstract isFiltered: bool option with get, set
        /// If provided, will be executed when the user clicks on the column header.
        abstract onColumnClick: (React.MouseEvent<HTMLElement> -> IColumn -> obj option) option with get, set
        /// If provided, will be executed when the user accesses the contextmenu on a column header.
        abstract onColumnContextMenu: (IColumn -> React.MouseEvent<HTMLElement> -> obj option) option with get, set
        /// If set will show a grouped icon next to the column header name.
        abstract isGrouped: bool option with get, set
        /// Arbitrary data passthrough which can be used by the caller.
        abstract data: obj option with get, set
        /// Internal only value.
        abstract calculatedWidth: float option with get, set
        /// Internal only value.
        /// Remembers the actual witdh of the column on any case.
        /// On the other hand, calculatedWidth is only saved when it's defined by user, not for justified calculations.
        abstract currentWidth: float option with get, set
        /// An optional class name to stick on the column cell within each header.
        abstract headerClassName: string option with get, set
        /// If set, will add additional LTR padding-right to column and cells.
        abstract isPadded: bool option with get, set

    type [<RequireQualifiedAccess>] ColumnActionsMode =
        | Disabled = 0
        | Clickable = 1
        | HasDropdown = 2

    type [<RequireQualifiedAccess>] ConstrainMode =
        | Unconstrained = 0
        | HorizontalConstrained = 1

    type [<AllowNullLiteral>] IColumnReorderOptions =
        /// Specifies the number fixed columns from left(0th index)
        abstract frozenColumnCountFromStart: float option with get, set
        /// Specifies the number fixed columns from right
        abstract frozenColumnCountFromEnd: float option with get, set
        /// Callback to handle the column reorder
        /// draggedIndex is the source column index, that need to be placed in targetIndex
        abstract handleColumnReorder: (float -> float -> unit) with get, set

    type [<RequireQualifiedAccess>] DetailsListLayoutMode =
        | FixedColumns = 0
        | Justified = 1

    type [<RequireQualifiedAccess>] CheckboxVisibility =
        | OnHover = 0
        | Always = 1
        | Hidden = 2

module __components_DetailsList_DetailsListPage =
    type IComponentDemoPageProps = __components_DetailsList_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListPage: DetailsListPageStatic

    type [<AllowNullLiteral>] DetailsListPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DetailsListPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DetailsListPage

module __components_DetailsList_DetailsRow =
    type BaseComponent = Utilities.BaseComponent
    type IColumn = __components_DetailsList_DetailsList_types.IColumn
    type CheckboxVisibility = __components_DetailsList_DetailsList_types.CheckboxVisibility
    type IDetailsRowCheckProps = __components_DetailsList_DetailsRowCheck.IDetailsRowCheckProps
    type IDetailsRowFieldsProps = __components_DetailsList_DetailsRowFields.IDetailsRowFieldsProps
    type ISelection = __utilities_selection_interfaces.ISelection
    type SelectionMode = __utilities_selection_interfaces.SelectionMode
    type CollapseAllVisibility = GroupedList.CollapseAllVisibility
    type IDragDropHelper = __utilities_dragdrop_interfaces.IDragDropHelper
    type IDragDropEvents = __utilities_dragdrop_interfaces.IDragDropEvents
    type IViewport = __utilities_decorators_withViewport.IViewport

    type [<AllowNullLiteral>] IExports =
        abstract DetailsRow: DetailsRowStatic

    type [<AllowNullLiteral>] IDetailsRowProps =
        inherit React.Props<DetailsRow>
        abstract componentRef: (unit -> unit) option with get, set
        abstract item: obj option with get, set
        abstract itemIndex: float with get, set
        abstract columns: ResizeArray<IColumn> with get, set
        abstract compact: bool option with get, set
        abstract selectionMode: SelectionMode with get, set
        abstract selection: ISelection with get, set
        abstract eventsToRegister: ResizeArray<obj> option with get, set
        abstract onDidMount: (DetailsRow -> unit) option with get, set
        abstract onWillUnmount: (DetailsRow -> unit) option with get, set
        abstract onRenderCheck: (IDetailsRowCheckProps -> JSX.Element) option with get, set
        abstract onRenderItemColumn: (obj option -> float -> IColumn -> obj option) option with get, set
        abstract dragDropEvents: IDragDropEvents option with get, set
        abstract dragDropHelper: IDragDropHelper option with get, set
        abstract groupNestingDepth: float option with get, set
        abstract viewport: IViewport option with get, set
        abstract checkboxVisibility: CheckboxVisibility option with get, set
        abstract collapseAllVisibility: CollapseAllVisibility option with get, set
        abstract getRowAriaLabel: (obj option -> string) option with get, set
        abstract getRowAriaDescribedBy: (obj option -> string) option with get, set
        abstract checkButtonAriaLabel: string option with get, set
        abstract checkboxCellClassName: string option with get, set
        abstract rowFieldsAs: U2<React.StatelessComponent<IDetailsRowFieldsProps>, React.ComponentClass<IDetailsRowFieldsProps>> option with get, set
        abstract className: string option with get, set
        abstract shimmer: bool option with get, set

    type [<AllowNullLiteral>] IDetailsRowSelectionState =
        abstract isSelected: bool with get, set
        abstract isSelectionModal: bool with get, set

    type [<AllowNullLiteral>] IDetailsRowState =
        abstract selectionState: IDetailsRowSelectionState option with get, set
        abstract columnMeasureInfo: obj option with get, set
        abstract isDropping: bool option with get, set
        abstract groupNestingDepth: float option with get, set

    type [<AllowNullLiteral>] DetailsRow =
        inherit BaseComponent<IDetailsRowProps, IDetailsRowState>
        abstract _root: obj with get, set
        abstract _cellMeasurer: obj with get, set
        abstract _focusZone: obj with get, set
        abstract _droppingClassNames: obj with get, set
        abstract _hasMounted: obj with get, set
        abstract _dragDropSubscription: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: previousProps: IDetailsRowProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentWillReceiveProps: newProps: IDetailsRowProps -> unit
        abstract render: unit -> JSX.Element
        /// <summary>measure cell at index. and call the call back with the measured cell width when finish measure</summary>
        /// <param name="index">(the cell index)</param>
        /// <param name="onMeasureDone">(the call back function when finish measure)</param>
        abstract measureCell: index: float * onMeasureDone: (float -> unit) -> unit
        abstract focus: ?forceIntoFirstElement: bool -> bool
        abstract _onRenderCheck: props: IDetailsRowCheckProps -> JSX.Element
        abstract _getSelectionState: props: obj -> unit
        abstract _onSelectionChanged: unit -> unit
        abstract _onToggleSelection: unit -> unit
        abstract _onRootRef: obj with get, set
        abstract _getRowDragDropOptions: unit -> unit
        /// <summary>update isDropping state based on the input value, which is used to change style during drag and drop
        /// 
        /// when change to true, that means drag enter. we will add default dropping class name
        /// or the custom dropping class name (return result from onDragEnter) to the root elemet.
        /// 
        /// when change to false, that means drag leave. we will remove the dropping class name from root element.</summary>
        /// <param name="newValue">(new isDropping state value)</param>
        /// <param name="event">(the event trigger dropping state change which can be dragenter, dragleave etc)</param>
        abstract _updateDroppingState: newValue: obj * ``event``: obj -> unit

    type [<AllowNullLiteral>] DetailsRowStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDetailsRowProps -> DetailsRow

module __components_DetailsList_DetailsRow_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract cell: obj
        abstract shimmer: obj
        abstract shimmerIconPlaceholder: obj
        abstract check: obj
        abstract rootIsSelected: obj
        abstract isRowHeader: obj
        abstract rootIsContentUnselectable: obj
        abstract checkCell: obj
        abstract isPadded: obj
        abstract isMultiline: obj
        abstract fields: obj
        abstract cellMeasurer: obj
        abstract checkCover: obj
        abstract anySelected: obj
        abstract shimmerLeftBorder: obj
        abstract shimmerBottomBorder: obj

module __components_DetailsList_DetailsRowCheck =

    type [<AllowNullLiteral>] IExports =
        abstract DetailsRowCheck: (IDetailsRowCheckProps -> JSX.Element)

    type [<AllowNullLiteral>] IDetailsRowCheckProps =
        inherit React.HTMLAttributes<HTMLElement>
        abstract isHeader: bool option with get, set
        abstract selected: bool option with get, set
        /// Deprecated at v.65.1 and will be removed by v 1.0. Use 'selected' instead.
        abstract isSelected: bool option with get, set
        abstract anySelected: bool option with get, set
        abstract canSelect: bool with get, set

module __components_DetailsList_DetailsRowCheck_scss =

    type [<AllowNullLiteral>] IExports =
        abstract check: obj
        abstract isHeader: obj
        abstract owner: obj
        abstract isSelected: obj
        abstract isVisible: obj
        abstract anySelected: obj
        abstract isDisabled: obj

module __components_DetailsList_DetailsRowFields =
    type IColumn = __components_DetailsList_DetailsList_types.IColumn
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DetailsRowFields: DetailsRowFieldsStatic

    type [<AllowNullLiteral>] IDetailsRowFieldsProps =
        abstract componentRef: (unit -> unit) option with get, set
        abstract item: obj option with get, set
        abstract itemIndex: float with get, set
        abstract columnStartIndex: float with get, set
        abstract columns: ResizeArray<IColumn> with get, set
        abstract compact: bool option with get, set
        abstract onRenderItemColumn: (obj option -> float -> IColumn -> obj option) option with get, set
        abstract shimmer: bool option with get, set

    type [<AllowNullLiteral>] IDetailsRowFieldsState =
        abstract cellContent: ResizeArray<React.ReactNode> with get, set

    type [<AllowNullLiteral>] DetailsRowFields =
        inherit BaseComponent<IDetailsRowFieldsProps, IDetailsRowFieldsState>
        abstract componentWillReceiveProps: newProps: IDetailsRowFieldsProps -> unit
        abstract render: unit -> JSX.Element
        abstract _getState: props: obj -> unit
        abstract _getCellText: item: obj * column: obj -> unit

    type [<AllowNullLiteral>] DetailsRowFieldsStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDetailsRowFieldsProps -> DetailsRowFields

module __components_Dialog_Dialog_base =
    type BaseComponent = Utilities.BaseComponent
    type IDialogProps = __components_Dialog_Dialog_types.IDialogProps

    type [<AllowNullLiteral>] IExports =
        abstract DialogBase: DialogBaseStatic

    type [<AllowNullLiteral>] DialogBase =
        inherit BaseComponent<IDialogProps, obj>
        abstract defaultProps: IDialogProps with get, set
        abstract _id: obj with get, set
        abstract _defaultTitleTextId: obj with get, set
        abstract _defaultSubTextId: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getSubTextId: obj with get, set
        abstract _getTitleTextId: obj with get, set

    type [<AllowNullLiteral>] DialogBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDialogProps -> DialogBase

module __components_Dialog_Dialog_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract DialogStatus: obj

module __components_Dialog_Dialog =
    type IDialogProps = __components_Dialog_Dialog_types.IDialogProps

    type [<AllowNullLiteral>] IExports =
        abstract Dialog: (IDialogProps -> JSX.Element)

module __components_Dialog_Dialog_styles =
    type IDialogStyleProps = __components_Dialog_Dialog_types.IDialogStyleProps
    type IDialogStyles = __components_Dialog_Dialog_types.IDialogStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IDialogStyleProps -> IDialogStyles)

module __components_Dialog_Dialog_types =
    type IModalProps = Modal.IModalProps
    type DialogBase = __components_Dialog_Dialog_base.DialogBase
    type DialogType = __components_Dialog_DialogContent_types.DialogType
    type IDialogContentProps = __components_Dialog_DialogContent_types.IDialogContentProps
    type IButtonProps = __components_Button_Button_types.IButtonProps
    type IWithResponsiveModeState = __utilities_decorators_withResponsiveMode.IWithResponsiveModeState
    type IAccessiblePopupProps = __common_IAccessiblePopupProps.IAccessiblePopupProps
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IDialog =
        interface end

    type [<AllowNullLiteral>] IDialogProps =
        inherit React.Props<DialogBase>
        inherit IWithResponsiveModeState
        inherit IAccessiblePopupProps
        /// Optional callback to access the IDialog interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IDialog option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IDialogStyleProps, IDialogStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Props to be passed through to Dialog Content
        abstract dialogContentProps: IDialogContentProps option with get, set
        /// A callback function for when the Dialog is dismissed from the close button or light dismiss. Can also be specified separately in content and modal.
        abstract onDismiss: (React.MouseEvent<HTMLButtonElement> -> obj option) option with get, set
        /// Whether the dialog is hidden.
        abstract hidden: bool option with get, set
        /// Props to be passed through to Modal
        abstract modalProps: IModalProps option with get, set
        /// Whether the dialog is displayed.
        abstract isOpen: bool option with get, set
        /// Whether the overlay is dark themed.
        abstract isDarkOverlay: bool option with get, set
        /// A callback function which is called after the Dialog is dismissed and the animation is complete.
        abstract onDismissed: (unit -> obj option) option with get, set
        /// Whether the dialog can be light dismissed by clicking outside the dialog (on the overlay).
        abstract isBlocking: bool option with get, set
        /// Optional class name to be added to the root class
        abstract className: string option with get, set
        /// Optional override for container class
        abstract containerClassName: string option with get, set
        /// A callback function for when the Dialog content is mounted on the overlay layer
        abstract onLayerDidMount: (unit -> unit) option with get, set
        /// Deprecated at 0.81.2, use 'onLayerDidMount' instead.
        abstract onLayerMounted: (unit -> unit) option with get, set
        /// The type of Dialog to display.
        abstract ``type``: DialogType option with get, set
        /// The title text to display at the top of the dialog.
        abstract title: string option with get, set
        /// The subtext to display in the dialog.
        abstract subText: string option with get, set
        /// Optional override content class
        abstract contentClassName: string option with get, set
        /// Other top buttons that will show up next to the close button
        abstract topButtonsProps: ResizeArray<IButtonProps> option with get, set
        /// Optional id for aria-LabelledBy
        abstract ariaLabelledById: string option with get, set
        /// Optional id for aria-DescribedBy
        abstract ariaDescribedById: string option with get, set

    type [<AllowNullLiteral>] IDialogStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// Optional override for container class
        abstract containerClassName: string option with get, set
        /// Optional override content class
        abstract contentClassName: string option with get, set
        /// Whether the dialog is hidden.
        abstract hidden: bool option with get, set
        /// Default min-width for the dialog box.
        abstract dialogDefaultMinWidth: string option with get, set
        /// Default max-width for the dialog box.
        abstract dialogDefaultMaxWidth: string option with get, set

    type [<AllowNullLiteral>] IDialogStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set
        abstract main: IStyle with get, set

module __components_Dialog_DialogContent_base =
    type BaseComponent = Utilities.BaseComponent
    type IDialogContentProps = __components_Dialog_DialogContent_types.IDialogContentProps

    type [<AllowNullLiteral>] IExports =
        abstract DialogContentBase: DialogContentBaseStatic

    type [<AllowNullLiteral>] DialogContentBase =
        inherit BaseComponent<IDialogContentProps, obj>
        abstract defaultProps: IDialogContentProps with get, set
        abstract render: unit -> JSX.Element
        abstract _groupChildren: unit -> unit

    type [<AllowNullLiteral>] DialogContentBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDialogContentProps -> DialogContentBase

module __components_Dialog_DialogContent =
    type IDialogContentProps = __components_Dialog_DialogContent_types.IDialogContentProps

    type [<AllowNullLiteral>] IExports =
        abstract DialogContent: (IDialogContentProps -> JSX.Element)

module __components_Dialog_DialogContent_styles =
    type IDialogContentStyleProps = __components_Dialog_DialogContent_types.IDialogContentStyleProps
    type IDialogContentStyles = __components_Dialog_DialogContent_types.IDialogContentStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IDialogContentStyleProps -> IDialogContentStyles)

module __components_Dialog_DialogContent_types =
    type DialogContentBase = __components_Dialog_DialogContent_base.DialogContentBase
    type IButtonProps = __components_Button_Button_types.IButtonProps
    type ResponsiveMode = __utilities_decorators_withResponsiveMode.ResponsiveMode
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IDialogContent =
        interface end

    type [<AllowNullLiteral>] IDialogContentProps =
        inherit React.Props<DialogContentBase>
        /// Optional callback to access the IDialogContent interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IDialogContent option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IDialogContentStyleProps, IDialogContentStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Is inside a multiline wrapper
        abstract isMultiline: bool option with get, set
        /// Show an 'x' close button in the upper-right corner
        abstract showCloseButton: bool option with get, set
        /// Other top buttons that will show up next to the close button
        abstract topButtonsProps: ResizeArray<IButtonProps> option with get, set
        /// Optional override class name
        abstract className: string option with get, set
        /// A callback function for when the Dialog is dismissed from the close button or light dismiss, before the animation completes.
        abstract onDismiss: (React.MouseEvent<HTMLButtonElement> -> obj option) option with get, set
        /// The Id for subText container
        abstract subTextId: string option with get, set
        /// The subtext to display in the dialog
        abstract subText: string option with get, set
        /// The Id for title container
        abstract titleId: string option with get, set
        /// The title text to display at the top of the dialog.
        abstract title: string option with get, set
        /// Responsive mode passed in from decorator.
        abstract responsiveMode: ResponsiveMode option with get, set
        /// Label to be passed to to aria-label of close button
        abstract closeButtonAriaLabel: string option with get, set
        /// The type of Dialog to display.
        abstract ``type``: DialogType option with get, set

    type [<RequireQualifiedAccess>] DialogType =
        | Normal = 0
        | LargeHeader = 1
        | Close = 2

    type [<AllowNullLiteral>] IDialogContentStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        abstract isLargeHeader: bool option with get, set
        abstract isClose: bool option with get, set
        abstract hidden: bool option with get, set
        /// Is inside a multiline wrapper
        abstract isMultiline: bool option with get, set

    type [<AllowNullLiteral>] IDialogContentStyles =
        /// Style for the content element.
        abstract content: IStyle with get, set
        abstract subText: IStyle with get, set
        abstract header: IStyle with get, set
        abstract button: IStyle with get, set
        abstract inner: IStyle with get, set
        abstract innerContent: IStyle with get, set
        abstract title: IStyle with get, set
        abstract topButton: IStyle with get, set

module __components_Dialog_DialogFooter_base =
    type IDialogFooterProps = __components_Dialog_DialogFooter_types.IDialogFooterProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DialogFooterBase: DialogFooterBaseStatic

    type [<AllowNullLiteral>] DialogFooterBase =
        inherit BaseComponent<IDialogFooterProps, obj>
        abstract _classNames: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _renderChildrenAsActions: unit -> unit

    type [<AllowNullLiteral>] DialogFooterBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DialogFooterBase

module __components_Dialog_DialogFooter =
    type IDialogFooterProps = __components_Dialog_DialogFooter_types.IDialogFooterProps

    type [<AllowNullLiteral>] IExports =
        abstract DialogFooter: (IDialogFooterProps -> JSX.Element)

module __components_Dialog_DialogFooter_styles =
    type IDialogFooterStyleProps = __components_Dialog_DialogFooter_types.IDialogFooterStyleProps
    type IDialogFooterStyles = __components_Dialog_DialogFooter_types.IDialogFooterStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IDialogFooterStyleProps -> IDialogFooterStyles)

module __components_Dialog_DialogFooter_types =
    type DialogFooterBase = __components_Dialog_DialogFooter_base.DialogFooterBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IDialogFooterProps =
        inherit React.Props<DialogFooterBase>
        /// Gets the component ref.
        abstract componentRef: (IDialogFooterProps option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IDialogFooterStyleProps, IDialogFooterStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Optional override class name
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IDialogFooterStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Optional override class name
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IDialogFooterStyles =
        /// Style for the actions element.
        abstract actions: IStyle with get, set
        abstract actionsRight: IStyle with get, set
        abstract action: IStyle with get, set

module __components_Dialog_DialogPage =
    type IComponentDemoPageProps = __components_Dialog_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract DialogPage: DialogPageStatic

    type [<AllowNullLiteral>] DialogPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DialogPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DialogPage

module __components_Divider_Divider_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract DividerStatus: obj

module __components_Divider_DividerPage =
    type IComponentDemoPageProps = __components_Divider_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract DividerPage: DividerPageStatic

    type [<AllowNullLiteral>] DividerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DividerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DividerPage

module __components_Divider_VerticalDivider_classNames =
    type ITheme = Styling.ITheme
    type IVerticalDividerClassNames = __components_Divider_VerticalDivider_types.IVerticalDividerClassNames

    type [<AllowNullLiteral>] IExports =
        abstract getDividerClassNames: (ITheme -> IVerticalDividerClassNames)

module __components_Divider_VerticalDivider =
    type IVerticalDividerProps = __components_Divider_VerticalDivider_types.IVerticalDividerProps

    type [<AllowNullLiteral>] IExports =
        abstract VerticalDivider: (IVerticalDividerProps -> JSX.Element)

module __components_Divider_VerticalDivider_types =
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IVerticalDividerProps =
        /// Optional function to generate the class names for the divider for custom styling
        abstract getClassNames: (ITheme -> IVerticalDividerClassNames) option with get, set

    type [<AllowNullLiteral>] IVerticalDividerClassNames =
        abstract wrapper: string with get, set
        abstract divider: string with get, set

module __components_DocumentCard_DocumentCard_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardStatus: obj

module __components_DocumentCard_DocumentCard =
    type IDocumentCardProps = __components_DocumentCard_DocumentCard_types.IDocumentCardProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCard: DocumentCardStatic

    type [<AllowNullLiteral>] DocumentCard =
        inherit BaseComponent<IDocumentCardProps, obj option>
        abstract defaultProps: IDocumentCardProps with get, set
        abstract render: unit -> JSX.Element
        abstract _onClick: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onAction: obj with get, set

    type [<AllowNullLiteral>] DocumentCardStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDocumentCardProps -> DocumentCard

module __components_DocumentCard_DocumentCard_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract rootIsActionable: obj
        abstract location: obj
        abstract title: obj
        abstract rootIsCompact: obj
        abstract preview: obj
        abstract icon: obj
        abstract previewIconContainer: obj
        abstract activity: obj
        abstract actions: obj
        abstract action: obj
        abstract views: obj
        abstract activityIsMultiplePeople: obj
        abstract avatar: obj
        abstract activityDetails: obj
        abstract avatars: obj
        abstract name: obj
        abstract activityActivity: obj
        abstract previewIsFileList: obj
        abstract fileList: obj
        abstract fileListIcon: obj
        abstract fileListMore: obj
        abstract secondaryTitle: obj
        abstract logo: obj
        abstract status: obj

module __components_DocumentCard_DocumentCard_types =
    type DocumentCard = __components_DocumentCard_DocumentCard.DocumentCard
    type DocumentCardTitle = __components_DocumentCard_DocumentCardTitle.DocumentCardTitle
    type DocumentCardPreview = __components_DocumentCard_DocumentCardPreview.DocumentCardPreview
    type DocumentCardLocation = __components_DocumentCard_DocumentCardLocation.DocumentCardLocation
    type DocumentCardActivity = __components_DocumentCard_DocumentCardActivity.DocumentCardActivity
    type DocumentCardActions = __components_DocumentCard_DocumentCardActions.DocumentCardActions
    type DocumentCardLogo = __components_DocumentCard_DocumentCardLogo.DocumentCardLogo
    type DocumentCardStatus = __components_DocumentCard_DocumentCardStatus.DocumentCardStatus
    type PersonaInitialsColor = Persona.PersonaInitialsColor
    type ImageFit = Image.ImageFit
    type IButtonProps = Button.IButtonProps
    type IIconProps = Icon.IIconProps

    type [<AllowNullLiteral>] IDocumentCard =
        interface end

    type [<AllowNullLiteral>] IDocumentCardProps =
        inherit React.Props<DocumentCard>
        /// Optional callback to access the IDocumentCard interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IDocumentCard option -> unit) option with get, set
        /// The type of DocumentCard to display.
        abstract ``type``: DocumentCardType option with get, set
        /// Function to call when the card is clicked or keyboard Enter/Space is pushed.
        abstract onClick: (React.SyntheticEvent<HTMLElement> -> unit) option with get, set
        /// A URL to navigate to when the card is clicked. If a function has also been provided,
        /// it will be used instead of the URL.
        abstract onClickHref: string option with get, set
        /// Optional class for document card.
        abstract className: string option with get, set
        /// Hex color value of the line below the card, which should correspond to the document type.
        /// This should only be supplied when using the 'compact' card layout.
        /// 
        /// Deprecated at v4.17.1, to be removed at >= v5.0.0.
        abstract accentColor: string option with get, set

    type [<RequireQualifiedAccess>] DocumentCardType =
        | Normal = 0
        | Compact = 1

    type [<AllowNullLiteral>] IDocumentCardPreviewProps =
        inherit React.Props<DocumentCardPreview>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// One or more preview images to display.
        abstract previewImages: ResizeArray<IDocumentCardPreviewImage> with get, set
        /// The function return string that will describe the number of overflow documents.
        /// such as  (overflowCount: number) => `+${ overflowCount } more`,
        abstract getOverflowDocumentCountText: (float -> string) option with get, set

    type [<AllowNullLiteral>] IDocumentCardPreviewImage =
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// File name for the document this preview represents.
        abstract name: string option with get, set
        /// URL to view the file.
        abstract url: string option with get, set
        /// Path to the preview image.
        abstract previewImageSrc: string option with get, set
        /// Deprecated at v1.3.6, to be removed at >= v2.0.0.
        abstract errorImageSrc: string option with get, set
        /// Path to the icon associated with this document type.
        abstract iconSrc: string option with get, set
        /// If provided, forces the preview image to be this width.
        abstract width: float option with get, set
        /// If provided, forces the preview image to be this height.
        abstract height: float option with get, set
        /// Used to determine how to size the image to fit the dimensions of the component.
        /// If both dimensions are provided, then the image is fit using ImageFit.scale, otherwise ImageFit.none is used.
        abstract imageFit: ImageFit option with get, set
        /// Hex color value of the line below the preview, which should correspond to the document type.
        /// 
        /// Deprecated at v4.17.1, to be removed at >= v5.0.0.
        abstract accentColor: string option with get, set
        /// The props for the preview icon.
        /// If provided, icon will be rendered instead of image.
        abstract previewIconProps: IIconProps option with get, set
        /// The props for the preview icon container classname.
        /// If provided, icon container classname will be used..
        abstract previewIconContainerClass: string option with get, set

    type [<AllowNullLiteral>] IDocumentCardTitleProps =
        inherit React.Props<DocumentCardTitle>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// Title text. If the card represents more than one document, this should be the title of one document and a "+X" string. For example, a collection of four documents would have a string of "Document.docx +3".
        abstract title: string with get, set
        /// Whether we truncate the title to fit within the box. May have a performance impact.
        abstract shouldTruncate: bool option with get, set
        /// Whether show as title as secondary title style such as smaller font and lighter color.
        abstract showAsSecondaryTitle: bool option with get, set

    type [<AllowNullLiteral>] IDocumentCardLocationProps =
        inherit React.Props<DocumentCardLocation>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// Text for the location of the document.
        abstract location: string with get, set
        /// URL to navigate to for this location.
        abstract locationHref: string option with get, set
        /// Function to call when the location is clicked.
        abstract onClick: (React.MouseEvent<HTMLElement> -> unit) option with get, set
        /// Aria label for the link to the document location.
        abstract ariaLabel: string option with get, set

    type [<AllowNullLiteral>] IDocumentCardActivityProps =
        inherit React.Props<DocumentCardActivity>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// Describes the activity that has taken place, such as "Created Feb 23, 2016".
        abstract activity: string with get, set
        /// One or more people who are involved in this activity.
        abstract people: ResizeArray<IDocumentCardActivityPerson> with get, set

    type [<AllowNullLiteral>] IDocumentCardActivityPerson =
        /// The name of the person.
        abstract name: string with get, set
        /// Path to the profile photo of the person.
        abstract profileImageSrc: string with get, set
        /// The user's initials to display in the profile photo area when there is no image.
        abstract initials: string option with get, set
        /// Whether initials are calculated for phone numbers and number sequences.
        /// Example: Set property to true to get initials for project names consisting of numbers only.
        abstract allowPhoneInitials: bool option with get, set
        /// The background color when the user's initials are displayed.
        abstract initialsColor: PersonaInitialsColor option with get, set

    type [<AllowNullLiteral>] IDocumentCardActionsProps =
        inherit React.Props<DocumentCardActions>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// The actions available for this document.
        abstract actions: ResizeArray<IButtonProps> with get, set
        /// The number of views this document has received.
        abstract views: Number option with get, set

    type [<AllowNullLiteral>] IDocumentCardLogoProps =
        inherit React.Props<DocumentCardLogo>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// Describes DocumentCard Logo badge.
        abstract logoIcon: string with get, set
        /// Describe Logo name, optional.
        abstract logoName: string option with get, set

    type [<AllowNullLiteral>] IDocumentCardStatusProps =
        inherit React.Props<DocumentCardStatus>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// Describes DocumentCard status icon.
        abstract statusIcon: string option with get, set
        /// Describe status information. Required field.
        abstract status: string with get, set

module __components_DocumentCard_DocumentCardActions =
    type BaseComponent = Utilities.BaseComponent
    type IDocumentCardActionsProps = __components_DocumentCard_DocumentCard_types.IDocumentCardActionsProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardActions: DocumentCardActionsStatic

    type [<AllowNullLiteral>] DocumentCardActions =
        inherit BaseComponent<IDocumentCardActionsProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardActionsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardActions

module __components_DocumentCard_DocumentCardActivity =
    type BaseComponent = Utilities.BaseComponent
    type IDocumentCardActivityProps = __components_DocumentCard_DocumentCard_types.IDocumentCardActivityProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardActivity: DocumentCardActivityStatic

    type [<AllowNullLiteral>] DocumentCardActivity =
        inherit BaseComponent<IDocumentCardActivityProps, obj option>
        abstract render: unit -> JSX.Element option
        abstract _renderAvatars: people: obj -> unit
        abstract _renderAvatar: person: obj -> unit
        abstract _getNameString: people: obj -> unit

    type [<AllowNullLiteral>] DocumentCardActivityStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardActivity

module __components_DocumentCard_DocumentCardLocation =
    type BaseComponent = Utilities.BaseComponent
    type IDocumentCardLocationProps = __components_DocumentCard_DocumentCard_types.IDocumentCardLocationProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardLocation: DocumentCardLocationStatic

    type [<AllowNullLiteral>] DocumentCardLocation =
        inherit BaseComponent<IDocumentCardLocationProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardLocationStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardLocation

module __components_DocumentCard_DocumentCardLogo =
    type BaseComponent = Utilities.BaseComponent
    type IDocumentCardLogoProps = __components_DocumentCard_DocumentCard_types.IDocumentCardLogoProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardLogo: DocumentCardLogoStatic

    type [<AllowNullLiteral>] DocumentCardLogo =
        inherit BaseComponent<IDocumentCardLogoProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardLogoStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardLogo

module __components_DocumentCard_DocumentCardPage =
    type IComponentDemoPageProps = __components_DocumentCard_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardPage: DocumentCardPageStatic

    type [<AllowNullLiteral>] DocumentCardPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardPage

module __components_DocumentCard_DocumentCardPreview =
    type IDocumentCardPreviewProps = __components_DocumentCard_DocumentCard_types.IDocumentCardPreviewProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardPreview: DocumentCardPreviewStatic

    type [<AllowNullLiteral>] DocumentCardPreview =
        inherit BaseComponent<IDocumentCardPreviewProps, obj option>
        abstract render: unit -> JSX.Element
        abstract _renderPreviewImage: previewImage: obj -> unit
        abstract _renderPreviewList: obj with get, set

    type [<AllowNullLiteral>] DocumentCardPreviewStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardPreview

module __components_DocumentCard_DocumentCardStatus =
    type BaseComponent = Utilities.BaseComponent
    type IDocumentCardStatusProps = __components_DocumentCard_DocumentCard_types.IDocumentCardStatusProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardStatus: DocumentCardStatusStatic

    type [<AllowNullLiteral>] DocumentCardStatus =
        inherit BaseComponent<IDocumentCardStatusProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardStatusStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDocumentCardStatusProps -> DocumentCardStatus

module __components_DocumentCard_DocumentCardTitle =
    type BaseComponent = Utilities.BaseComponent
    type IDocumentCardTitleProps = __components_DocumentCard_DocumentCard_types.IDocumentCardTitleProps

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardTitle: DocumentCardTitleStatic

    type [<AllowNullLiteral>] IDocumentCardTitleState =
        abstract truncatedTitleFirstPiece: string option with get, set
        abstract truncatedTitleSecondPiece: string option with get, set

    type [<AllowNullLiteral>] DocumentCardTitle =
        inherit BaseComponent<IDocumentCardTitleProps, IDocumentCardTitleState>
        abstract _titleElement: obj with get, set
        abstract _scrollTimerId: obj with get, set
        abstract _truncatedTitleAtWidth: obj with get, set
        abstract _isTruncated: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: IDocumentCardTitleProps -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _startTruncation: obj with get, set
        abstract _shrinkTitle: unit -> unit
        abstract _doesTitleOverflow: unit -> unit
        abstract _updateTruncation: unit -> unit

    type [<AllowNullLiteral>] DocumentCardTitleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDocumentCardTitleProps -> DocumentCardTitle

module __components_Dropdown_Dropdown_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract DropdownStatus: obj

module __components_Dropdown_Dropdown =
    type IDropdownProps = __components_Dropdown_Dropdown_types.IDropdownProps
    type IWithResponsiveModeState = __utilities_decorators_withResponsiveMode.IWithResponsiveModeState
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract Dropdown: DropdownStatic

    type [<AllowNullLiteral>] IDropdownInternalProps =
        inherit IDropdownProps
        inherit IWithResponsiveModeState

    type [<AllowNullLiteral>] IDropdownState =
        abstract isOpen: bool option with get, set
        abstract selectedIndices: ResizeArray<float> option with get, set

    type [<AllowNullLiteral>] Dropdown =
        inherit BaseComponent<IDropdownInternalProps, IDropdownState>
        abstract defaultProps: obj with get, set
        abstract Option: obj with get, set
        abstract _host: obj with get, set
        abstract _focusZone: obj with get, set
        abstract _dropDown: obj with get, set
        abstract _id: obj with get, set
        abstract _isScrollIdle: obj with get, set
        abstract _scrollIdleDelay: obj
        abstract _scrollIdleTimeoutId: obj with get, set
        abstract componentWillReceiveProps: newProps: IDropdownProps -> unit
        abstract componentDidUpdate: prevProps: IDropdownProps * prevState: IDropdownState -> unit
        abstract render: unit -> JSX.Element
        abstract focus: ?shouldOpenOnFocus: bool -> unit
        abstract setSelectedIndex: index: float -> unit
        abstract _copyArray: array: obj -> unit
        /// <summary>Finds the next valid Dropdown option and sets the selected index to it.</summary>
        /// <param name="stepValue">Value of how many items the function should traverse.  Should be -1 or 1.</param>
        /// <param name="index">Index of where the search should start</param>
        /// <param name="selectedIndex">The selectedIndex Dropdown's state</param>
        abstract _moveIndex: stepValue: obj * index: obj * selectedIndex: obj -> unit
        abstract _onRenderTitle: obj with get, set
        abstract _onRenderPlaceHolder: obj with get, set
        abstract _onRenderContainer: obj with get, set
        abstract _onRenderCaretDown: obj with get, set
        abstract _onRenderList: obj with get, set
        abstract _onRenderItem: obj with get, set
        abstract _renderSeparator: item: obj -> unit
        abstract _renderHeader: item: obj -> unit
        abstract _renderOption: obj with get, set
        abstract _onRenderOption: obj with get, set
        abstract _onRenderLabel: obj with get, set
        abstract _onPositioned: obj with get, set
        abstract _onItemClick: obj with get, set
        /// Scroll handler for the callout to make sure the mouse events
        /// for updating focus are not interacting during scroll
        abstract _onScroll: obj with get, set
        abstract _onItemMouseEnter: item: obj * ev: obj -> unit
        abstract _onItemMouseMove: item: obj * ev: obj -> unit
        abstract _onMouseItemLeave: obj with get, set
        abstract _onDismiss: obj with get, set
        abstract _getSelectedIndexes: options: obj * selectedKey: obj -> unit
        abstract _getAllSelectedOptions: options: obj * selectedIndices: obj -> unit
        abstract _getAllSelectedIndices: options: obj -> unit
        abstract _getSelectedIndex: options: obj * selectedKey: obj -> unit
        abstract _onDropdownBlur: obj with get, set
        abstract _onDropdownKeyDown: obj with get, set
        abstract _onDropdownKeyUp: obj with get, set
        abstract _onZoneKeyDown: obj with get, set
        abstract _onDropdownClick: obj with get, set

    type [<AllowNullLiteral>] DropdownStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IDropdownProps -> Dropdown

module __components_Dropdown_Dropdown_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract title: obj
        abstract caretDown: obj
        abstract titleIsPlaceHolder: obj
        abstract titleIsError: obj
        abstract rootIsDisabled: obj
        abstract listWrapper: obj
        abstract caretDownWrapper: obj
        abstract panel: obj
        abstract callout: obj
        abstract errorMessage: obj
        abstract items: obj
        abstract item: obj
        abstract itemIsDisabled: obj
        abstract itemIsSelected: obj
        abstract header: obj
        abstract divider: obj
        abstract optionText: obj

module __components_Dropdown_Dropdown_types =
    type IRenderFunction = Utilities.IRenderFunction
    type ISelectableOption = __utilities_selectableOption_SelectableOption_types.ISelectableOption
    type ISelectableDroppableTextProps = __utilities_selectableOption_SelectableDroppableText_types.ISelectableDroppableTextProps
    type ResponsiveMode = __utilities_decorators_withResponsiveMode.ResponsiveMode
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IDropdown =
        abstract focus: (bool -> unit) with get, set

    type [<AllowNullLiteral>] IDropdownProps =
        inherit ISelectableDroppableTextProps<HTMLDivElement>
        /// Input placeholder text. Displayed until option is selected.
        abstract placeHolder: string option with get, set
        /// Callback issues when the selected option changes
        abstract onChanged: (IDropdownOption -> float -> unit) option with get, set
        /// Callback issues when the options callout is dismissed
        abstract onDismiss: (unit -> unit) option with get, set
        /// Optional custom renderer for placeholder text
        abstract onRenderPlaceHolder: IRenderFunction<IDropdownProps> option with get, set
        /// Optional custom renderer for selected option displayed in input
        abstract onRenderTitle: IRenderFunction<U2<IDropdownOption, ResizeArray<IDropdownOption>>> option with get, set
        /// Optional custom renderer for chevron icon
        abstract onRenderCaretDown: IRenderFunction<IDropdownProps> option with get, set
        /// Custom width for dropdown. If value is 0, width of the input field is used.
        abstract dropdownWidth: float option with get, set
        abstract responsiveMode: ResponsiveMode option with get, set
        /// Optional mode indicates if multi-choice selections is allowed.  Default to false
        abstract multiSelect: bool option with get, set
        /// Keys that will be initially used to set selected items.
        abstract defaultSelectedKeys: U2<ResizeArray<string>, ResizeArray<float>> option with get, set
        /// Keys of the selected items. If you provide this, you must maintain selection
        /// state by observing onChange events and passing a new value in when changed.
        abstract selectedKeys: U2<ResizeArray<string>, ResizeArray<float>> option with get, set
        /// When multiple items are selected, this still will be used to separate values in
        /// the dropdown title.
        abstract multiSelectDelimiter: string option with get, set
        /// Deprecated at v0.52.0, use 'disabled' instead.
        abstract isDisabled: bool option with get, set
        /// Optional keytip for this dropdown
        abstract keytipProps: IKeytipProps option with get, set

    type [<AllowNullLiteral>] IDropdownOption =
        inherit ISelectableOption
        /// Data available to custom onRender functions.
        abstract data: obj option with get, set
        /// Deprecated at v.65.1, use 'selected' instead.
        abstract isSelected: bool option with get, set

module __components_Dropdown_DropdownPage =
    type IComponentDemoPageProps = __components_Dropdown_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract DropdownPage: DropdownPageStatic

    type [<AllowNullLiteral>] DropdownPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DropdownPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DropdownPage

module __components_ExtendedPicker_BaseExtendedPicker =
    type BaseComponent = Utilities.BaseComponent
    type Autofill = Autofill.Autofill
    type IBaseExtendedPickerProps = __components_ExtendedPicker_BaseExtendedPicker_types.IBaseExtendedPickerProps
    type IBaseExtendedPicker = __components_ExtendedPicker_BaseExtendedPicker_types.IBaseExtendedPicker
    type IBaseFloatingPickerProps = FloatingPicker.IBaseFloatingPickerProps
    type BaseFloatingPicker = FloatingPicker.BaseFloatingPicker
    type BaseSelectedItemsList = SelectedItemsList.BaseSelectedItemsList
    type IBaseSelectedItemsListProps = SelectedItemsList.IBaseSelectedItemsListProps
    type Selection = Selection.Selection

    type [<AllowNullLiteral>] IExports =
        abstract BaseExtendedPicker: BaseExtendedPickerStatic

    type [<AllowNullLiteral>] IBaseExtendedPickerState =
        abstract items: obj option with get, set
        abstract suggestedDisplayValue: string option with get, set
        abstract moreSuggestionsAvailable: bool option with get, set
        abstract isSearching: bool option with get, set
        abstract isMostRecentlyUsedVisible: bool option with get, set
        abstract suggestionsVisible: bool option with get, set
        abstract suggestionsLoading: bool option with get, set
        abstract isResultsFooterVisible: bool option with get, set

    type [<AllowNullLiteral>] BaseExtendedPicker<'T, 'P> =
        inherit BaseComponent<'P, IBaseExtendedPickerState>
        inherit IBaseExtendedPicker<'T>
        abstract floatingPicker: obj with get, set
        abstract selectedItemsList: obj with get, set
        abstract root: obj with get, set
        abstract input: obj with get, set
        abstract selection: Selection with get, set
        abstract floatingPickerProps: IBaseFloatingPickerProps<'T> with get, set
        abstract selectedItemsListProps: IBaseSelectedItemsListProps<'T> with get, set
        abstract items: obj option
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: 'P -> unit
        abstract focus: unit -> unit
        abstract clearInput: unit -> unit
        abstract inputElement: HTMLInputElement option
        abstract render: unit -> JSX.Element
        abstract onSelectionChange: (unit -> unit) with get, set
        abstract canAddItems: unit -> bool
        abstract renderSuggestions: unit -> JSX.Element
        abstract renderSelectedItemsList: unit -> JSX.Element
        abstract onInputChange: (string -> unit) with get, set
        abstract onInputFocus: (React.FocusEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
        abstract onInputClick: (React.MouseEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
        abstract onBackspace: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
        abstract onCopy: (React.ClipboardEvent<HTMLElement> -> unit) with get, set
        abstract onPaste: (React.ClipboardEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
        abstract _onSuggestionSelected: ('T -> unit) with get, set
        abstract _onSelectedItemsChanged: (unit -> unit) with get, set

    type [<AllowNullLiteral>] BaseExtendedPickerStatic =
        [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BaseExtendedPicker<'T, 'P>

module __components_ExtendedPicker_BaseExtendedPicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract pickerText: obj
        abstract pickerInput: obj

module __components_ExtendedPicker_BaseExtendedPicker_tests =
    type IBaseExtendedPickerProps = __components_ExtendedPicker_BaseExtendedPicker_types.IBaseExtendedPickerProps
    type BaseExtendedPicker = __components_ExtendedPicker_BaseExtendedPicker.BaseExtendedPicker

    type [<AllowNullLiteral>] ISimple =
        abstract key: string with get, set
        abstract name: string with get, set

    type TypedBaseExtendedPicker =
        BaseExtendedPicker<ISimple, IBaseExtendedPickerProps<ISimple>>

module __components_ExtendedPicker_BaseExtendedPicker_types =
    type Autofill = Autofill.Autofill
    type IInputProps = Pickers.IInputProps
    type IBaseFloatingPickerProps = FloatingPicker.IBaseFloatingPickerProps
    type IBaseSelectedItemsListProps = SelectedItemsList.IBaseSelectedItemsListProps

    type [<AllowNullLiteral>] IBaseExtendedPicker<'T> =
        /// Forces the picker to resolve 
        abstract forceResolve: (unit -> unit) option with get, set
        /// Gets the current value of the input. 
        abstract items: ResizeArray<'T> option with get, set
        /// Sets focus to the input. 
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IBaseExtendedPickerProps<'T> =
        abstract componentRef: (IBaseExtendedPicker<'T> option -> unit) option with get, set
        /// Header/title element for the picker
        abstract headerComponent: JSX.Element option with get, set
        /// Initial items that have already been selected and should appear in the people picker.
        abstract defaultSelectedItems: ResizeArray<'T> option with get, set
        /// A callback for when the selected list of items changes.
        abstract onChange: (ResizeArray<'T> -> unit) option with get, set
        /// A callback for when text is pasted into the input
        abstract onPaste: (string -> ResizeArray<'T>) option with get, set
        /// A callback for when the user put focus on the picker
        abstract onFocus: React.FocusEventHandler<U2<HTMLInputElement, Autofill>> option with get, set
        /// A callback for when the user moves the focus away from the picker
        abstract onBlur: React.FocusEventHandler<U2<HTMLInputElement, Autofill>> option with get, set
        /// ClassName for the picker.
        abstract className: string option with get, set
        /// Function that specifies how the floating picker will appear.
        abstract onRenderFloatingPicker: (IBaseFloatingPickerProps<'T> -> JSX.Element) with get, set
        /// Function that specifies how the floating picker will appear.
        abstract onRenderSelectedItems: (IBaseSelectedItemsListProps<'T> -> JSX.Element) with get, set
        /// Floating picker properties
        abstract floatingPickerProps: IBaseFloatingPickerProps<'T> with get, set
        /// Selected items list properties
        abstract selectedItemsListProps: IBaseSelectedItemsListProps<'T> with get, set
        /// Autofill input native props
        abstract inputProps: IInputProps option with get, set
        /// Flag for disabling the picker.
        abstract disabled: bool option with get, set
        /// Restrict the amount of selectable items.
        abstract itemLimit: float option with get, set
        /// A callback to process a selection after the user selects something from the picker.
        abstract onItemSelected: ('T -> U2<'T, PromiseLike<'T>>) option with get, set
        /// Deprecated at 5.96.0. Use defaultSelectedItems or selectedItems in selectedItemsListProps instead.
        abstract selectedItems: ResizeArray<'T> option with get, set

module __components_Fabric_Fabric =
    type BaseComponent = Utilities.BaseComponent
    type IFabricProps = __components_Fabric_Fabric_types.IFabricProps

    type [<AllowNullLiteral>] IExports =
        abstract Fabric: FabricStatic

    type [<AllowNullLiteral>] Fabric =
        inherit BaseComponent<IFabricProps, obj>
        abstract _rootElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract _onMouseDown: obj with get, set
        abstract _onKeyDown: obj with get, set

    type [<AllowNullLiteral>] FabricStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IFabricProps -> Fabric

module __components_Fabric_Fabric_styles =
    type IFabricStyleProps = __components_Fabric_Fabric_types.IFabricStyleProps
    type IFabricStyles = __components_Fabric_Fabric_types.IFabricStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IFabricStyleProps -> IFabricStyles)

    type [<AllowNullLiteral>] IFabricClassNames =
        abstract root: string with get, set

module __components_Fabric_Fabric_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IFabricProps =
        inherit React.HTMLAttributes<HTMLDivElement>
        abstract componentRef: (unit -> unit) option with get, set
        abstract theme: ITheme option with get, set

    type [<AllowNullLiteral>] IFabricStyleProps =
        inherit IFabricProps
        abstract theme: ITheme with get, set
        abstract isFocusVisible: bool with get, set

    type [<AllowNullLiteral>] IFabricStyles =
        abstract root: IStyle with get, set

module __components_Facepile_Facepile_base =
    type BaseComponent = Utilities.BaseComponent
    type IFacepileProps = __components_Facepile_Facepile_types.IFacepileProps

    type [<AllowNullLiteral>] IExports =
        abstract FacepileBase: FacepileBaseStatic

    type [<AllowNullLiteral>] FacepileBase =
        inherit BaseComponent<IFacepileProps, obj>
        abstract defaultProps: IFacepileProps with get, set
        abstract _ariaDescriptionId: obj with get, set
        abstract render: unit -> JSX.Element
        abstract onRenderAriaDescription: unit -> U2<string, JSX.Element> option
        abstract _onRenderVisiblePersonas: personas: obj * singlePersona: obj -> unit
        abstract _getPersonaControl: persona: obj -> unit
        abstract _getPersonaCoinControl: persona: obj -> unit
        abstract _getElementWithOnClickEvent: personaControl: obj * persona: obj * index: obj -> unit
        abstract _getElementWithoutOnClickEvent: personaControl: obj * persona: obj * index: obj -> unit
        abstract _getElementProps: persona: obj * index: obj -> unit
        abstract _getOverflowElement: personasOverflow: obj -> unit
        abstract _getDescriptiveOverflowElement: personasOverflow: obj -> unit
        abstract _getIconElement: icon: obj -> unit
        abstract _getAddNewElement: unit -> unit
        abstract _onPersonaClick: persona: obj * ?ev: obj -> unit
        abstract _onPersonaMouseMove: persona: obj * ?ev: obj -> unit
        abstract _onPersonaMouseOut: persona: obj * ?ev: obj -> unit
        abstract _renderInitials: iconName: obj * ?overflowButton: obj -> unit
        abstract _renderInitialsNotPictured: numPersonasNotPictured: obj -> unit

    type [<AllowNullLiteral>] FacepileBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IFacepileProps -> FacepileBase

module __components_Facepile_Facepile_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract FacepileStatus: obj

module __components_Facepile_Facepile =
    type IFacepileProps = __components_Facepile_Facepile_types.IFacepileProps

    type [<AllowNullLiteral>] IExports =
        abstract Facepile: (IFacepileProps -> JSX.Element)

module __components_Facepile_Facepile_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract clear: obj
        abstract itemContainer: obj
        abstract members: obj
        abstract itemButton: obj
        abstract addButton: obj
        abstract overflowButton: obj
        abstract descriptiveOverflowButton: obj
        abstract overflowInitialsIcon: obj
        abstract screenReaderOnly: obj

module __components_Facepile_Facepile_styles =
    type IFacepileStyleProps = __components_Facepile_Facepile_types.IFacepileStyleProps
    type IFacepileStyles = __components_Facepile_Facepile_types.IFacepileStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IFacepileStyleProps -> IFacepileStyles)

module __components_Facepile_Facepile_types =
    type FacepileBase = __components_Facepile_Facepile_base.FacepileBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction
    type IButtonProps = __components_Button_index.IButtonProps
    type IPersonaSharedProps = __components_Persona_index.IPersonaSharedProps
    type PersonaInitialsColor = __components_Persona_index.PersonaInitialsColor
    type PersonaSize = __components_Persona_index.PersonaSize

    type [<AllowNullLiteral>] IFacepile =
        interface end

    type [<AllowNullLiteral>] IFacepileProps =
        inherit React.Props<FacepileBase>
        /// Optional callback to access the IFacepile interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IFacepile option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<IFacepileStyleProps, IFacepileStyles> option with get, set
        /// Theme provided by High-Order Component.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Facepile
        abstract className: string option with get, set
        /// Array of IPersonaProps that define each Persona.
        abstract personas: ResizeArray<IFacepilePersona> with get, set
        /// Personas to place in the overflow
        abstract overflowPersonas: ResizeArray<IFacepilePersona> option with get, set
        /// Maximum number of personas to show 
        abstract maxDisplayablePersonas: float option with get, set
        /// Size to display the personas 
        abstract personaSize: PersonaSize option with get, set
        /// ARIA label for persona list 
        abstract ariaDescription: string option with get, set
        /// Show add person button 
        abstract showAddButton: bool option with get, set
        /// Button properties for the add face button 
        abstract addButtonProps: IButtonProps option with get, set
        /// Deprecated at v0.70, use 'overflowButtonProps' instead;
        abstract chevronButtonProps: IButtonProps option with get, set
        /// Properties for the overflow icon 
        abstract overflowButtonProps: IButtonProps option with get, set
        /// Type of overflow icon to use 
        abstract overflowButtonType: OverflowButtonType option with get, set
        /// Method to access properties on the underlying Persona control 
        abstract getPersonaProps: (IFacepilePersona -> IPersonaSharedProps) option with get, set

    type [<AllowNullLiteral>] IFacepilePersona =
        inherit React.ButtonHTMLAttributes<U2<HTMLButtonElement, HTMLDivElement>>
        /// Name of the person.
        abstract personaName: string option with get, set
        /// Url to the image to use, should be a square aspect ratio and big enough to fit in the image area.
        abstract imageUrl: string option with get, set
        /// The user's initials to display in the image area when there is no image.
        abstract imageInitials: string option with get, set
        /// Whether initials are calculated for phone numbers and number sequences.
        /// Example: Set property to true to get initials for project names consisting of numbers only.
        abstract allowPhoneInitials: bool option with get, set
        /// The background color when the user's initials are displayed.
        abstract initialsColor: PersonaInitialsColor option with get, set
        /// If provided, persona will be rendered with cursor:pointer and the handler will be
        /// called on click.
        abstract onClick: (React.MouseEvent<HTMLElement> -> IFacepilePersona -> unit) option with get, set
        /// If provided, the handler will be called on mouse move.
        abstract onMouseMove: (React.MouseEvent<HTMLElement> -> IFacepilePersona -> unit) option with get, set
        /// If provided, the handler will be called when mouse moves out of the component.
        abstract onMouseOut: (React.MouseEvent<HTMLElement> -> IFacepilePersona -> unit) option with get, set
        /// Extra data - not used directly but can be handy for passing additional data to custom event
        /// handlers.
        abstract data: obj option with get, set

    type [<RequireQualifiedAccess>] OverflowButtonType =
        | None = 0
        | Descriptive = 1
        | More = 2
        | DownArrow = 3

    type [<AllowNullLiteral>] IFacepileStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IFacepileStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set

module __components_Facepile_FacepileButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract FacepileButton: FacepileButtonStatic

    type [<AllowNullLiteral>] FacepileButton =
        inherit BaseComponent<IButtonProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FacepileButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FacepileButton

module __components_Facepile_FacepilePage =
    type IComponentDemoPageProps = __components_Facepile_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract FacepilePage: FacepilePageStatic

    type [<AllowNullLiteral>] FacepilePage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FacepilePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FacepilePage

module __components_FloatingPicker_BaseFloatingPicker =
    type BaseComponent = Utilities.BaseComponent
    type IBaseFloatingPicker = __components_FloatingPicker_BaseFloatingPicker_types.IBaseFloatingPicker
    type IBaseFloatingPickerProps = __components_FloatingPicker_BaseFloatingPicker_types.IBaseFloatingPickerProps
    type ISuggestionsControlProps = __components_FloatingPicker_Suggestions_Suggestions_types.ISuggestionsControlProps
    type SuggestionsControl = __components_FloatingPicker_Suggestions_SuggestionsControl.SuggestionsControl
    type SuggestionsStore = __components_FloatingPicker_Suggestions_SuggestionsStore.SuggestionsStore

    type [<AllowNullLiteral>] IExports =
        abstract BaseFloatingPicker: BaseFloatingPickerStatic

    type [<AllowNullLiteral>] IBaseFloatingPickerState =
        abstract queryString: string with get, set
        abstract suggestedDisplayValue: string option with get, set
        abstract moreSuggestionsAvailable: bool option with get, set
        abstract isMostRecentlyUsedVisible: bool option with get, set
        abstract suggestionsVisible: bool option with get, set
        abstract suggestionsLoading: bool option with get, set
        abstract isResultsFooterVisible: bool option with get, set
        abstract didBind: bool with get, set

    type [<AllowNullLiteral>] BaseFloatingPicker<'T, 'P> =
        inherit BaseComponent<'P, IBaseFloatingPickerState>
        inherit IBaseFloatingPicker
        abstract selection: Selection with get, set
        abstract root: obj with get, set
        abstract suggestionStore: SuggestionsStore<'T> with get, set
        abstract suggestionsControl: SuggestionsControl<'T> with get, set
        abstract SuggestionsControlOfProperType: obj with get, set
        abstract loadingTimer: float option with get, set
        abstract currentPromise: PromiseLike<obj option> with get, set
        abstract inputText: string
        abstract suggestions: ResizeArray<obj option>
        abstract forceResolveSuggestion: unit -> unit
        abstract isSuggestionsShown: bool
        abstract onQueryStringChanged: (string -> unit) with get, set
        abstract hidePicker: (unit -> unit) with get, set
        abstract showPicker: (bool -> unit) with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract completeSuggestion: (unit -> unit) with get, set
        abstract updateSuggestions: suggestions: ResizeArray<'T> * ?forceUpdate: bool -> unit
        abstract render: unit -> JSX.Element
        abstract renderSuggestions: unit -> JSX.Element option
        abstract onSuggestionSelect: unit -> unit
        abstract onSelectionChange: unit -> unit
        abstract updateValue: updatedValue: string -> unit
        abstract updateSuggestionWithZeroState: unit -> unit
        abstract updateSuggestionsList: suggestions: U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>> * ?updatedValue: string -> unit
        abstract resolveNewValue: updatedValue: string * suggestions: ResizeArray<'T> -> unit
        abstract onChange: item: 'T -> unit
        abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> 'T -> float -> unit) with get, set
        abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> 'T -> float -> unit) with get, set
        abstract onKeyDown: (MouseEvent -> unit) with get, set
        abstract _onResolveSuggestions: updatedValue: obj -> unit
        abstract _onValidateInput: obj with get, set
        abstract _getTextFromItem: item: obj * ?currentValue: obj -> unit
        abstract _updateSuggestionsVisible: shouldShow: obj -> unit
        abstract _bindToInputElement: unit -> unit
        abstract _unbindFromInputElement: unit -> unit

    type [<AllowNullLiteral>] BaseFloatingPickerStatic =
        [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BaseFloatingPicker<'T, 'P>

module __components_FloatingPicker_BaseFloatingPicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract callout: obj

module __components_FloatingPicker_BaseFloatingPicker_types =
    type ISuggestionModel = Pickers.ISuggestionModel
    type IPersonaProps = Persona.IPersonaProps
    type ISuggestionsHeaderFooterProps = __components_FloatingPicker_Suggestions_Suggestions_types.ISuggestionsHeaderFooterProps
    type SuggestionsStore = __components_FloatingPicker_Suggestions_SuggestionsStore.SuggestionsStore

    type [<AllowNullLiteral>] IBaseFloatingPicker =
        /// Whether the suggestions are shown 
        abstract isSuggestionsShown: bool with get, set
        /// On queryString changed 
        abstract onQueryStringChanged: (string -> unit) with get, set
        /// Hides the picker 
        abstract hidePicker: (unit -> unit) with get, set
        /// Shows the picker
        abstract showPicker: (bool -> unit) with get, set
        /// Gets the suggestions 
        abstract suggestions: ResizeArray<obj option> with get, set
        /// Gets the input text 
        abstract inputText: string with get, set

    type [<AllowNullLiteral>] IBaseFloatingPickerProps<'T> =
        inherit React.Props<obj option>
        abstract componentRef: (IBaseFloatingPicker option -> unit) option with get, set
        /// The suggestions store
        abstract suggestionsStore: SuggestionsStore<'T> with get, set
        /// The suggestions to show on zero query
        abstract onZeroQuerySuggestion: (ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) option with get, set
        /// The input element to listen on events
        abstract inputElement: HTMLInputElement option with get, set
        /// Function that specifies how an individual suggestion item will appear.
        abstract onRenderSuggestionsItem: ('T -> obj option -> JSX.Element) option with get, set
        /// A callback for what should happen when a person types text into the input.
        /// Returns the already selected items so the resolver can filter them out.
        /// If used in conjunction with resolveDelay this will ony kick off after the delay throttle.
        abstract onResolveSuggestions: (string -> ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>> option) with get, set
        /// A callback for when the input has been changed
        abstract onInputChanged: (string -> unit) option with get, set
        /// The delay time in ms before resolving suggestions, which is kicked off when input has been cahnged.
        /// e.g. If a second input change happens within the resolveDelay time, the timer will start over.
        /// Only until after the timer completes will onResolveSuggestions be called.
        abstract resolveDelay: float option with get, set
        /// A callback for when a suggestion is clicked
        abstract onChange: ('T -> unit) option with get, set
        /// ClassName for the picker.
        abstract className: string option with get, set
        /// The properties that will get passed to the Suggestions component.
        abstract pickerSuggestionsProps: IBaseFloatingPickerSuggestionProps option with get, set
        /// A callback for when a persona is removed from the suggestion list
        abstract onRemoveSuggestion: (IPersonaProps -> unit) option with get, set
        /// A function used to validate if raw text entered into the well can be added
        abstract onValidateInput: (string -> bool) option with get, set
        /// The text to display while searching for more results in a limited suggestions list
        abstract searchingText: U2<(obj -> string), string> option with get, set
        /// Function that specifies how arbitrary text entered into the well is handled.
        abstract createGenericItem: (string -> bool -> ISuggestionModel<'T>) option with get, set
        /// The callback that should be called to see if the force resolve command should be shown
        abstract showForceResolve: (unit -> bool) option with get, set
        /// The items that the base picker should currently display as selected. If this is provided then the picker will act as a controlled
        /// component.
        abstract selectedItems: ResizeArray<'T> option with get, set
        /// A callback to get text from an item. Used to autofill text in the pickers.
        abstract getTextFromItem: ('T -> string -> string) option with get, set
        /// Width for the suggestions callout
        abstract calloutWidth: float option with get, set
        /// The callback that should be called when the suggestions are shown
        abstract onSuggestionsShown: (unit -> unit) option with get, set
        /// The callback that should be called when the suggestions are hiden
        abstract onSuggestionsHidden: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] IBaseFloatingPickerSuggestionProps =
        /// Whether or not the first selectable item in the suggestions list should be selected
        abstract shouldSelectFirstItem: (unit -> bool) option with get, set
        /// The header items props
        abstract headerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
        /// The footer items props
        abstract footerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set

module __components_FocusTrapZone_FocusTrapZone =
    type BaseComponent = Utilities.BaseComponent
    type IFocusTrapZone = __components_FocusTrapZone_FocusTrapZone_types.IFocusTrapZone
    type IFocusTrapZoneProps = __components_FocusTrapZone_FocusTrapZone_types.IFocusTrapZoneProps

    type [<AllowNullLiteral>] IExports =
        abstract FocusTrapZone: FocusTrapZoneStatic

    type [<AllowNullLiteral>] FocusTrapZone =
        inherit BaseComponent<IFocusTrapZoneProps, obj>
        inherit IFocusTrapZone
        abstract _focusStack: obj with get, set
        abstract _clickStack: obj with get, set
        abstract _root: obj with get, set
        abstract _previouslyFocusedElement: obj with get, set
        abstract _isInFocusStack: obj with get, set
        abstract _isInClickStack: obj with get, set
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: nextProps: IFocusTrapZoneProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        /// Need to expose this method in case of popups since focus needs to be set when popup is opened
        abstract focus: unit -> unit
        abstract _onKeyboardHandler: obj with get, set
        abstract _forceFocusInTrap: ev: obj -> unit
        abstract _forceClickInTrap: ev: obj -> unit

    type [<AllowNullLiteral>] FocusTrapZoneStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FocusTrapZone

module __components_FocusTrapZone_FocusTrapZone_types =

    type [<AllowNullLiteral>] IFocusTrapZone =
        /// Sets focus on the first focusable, or configured, child in focus trap zone
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IFocusTrapZoneProps =
        inherit React.HTMLAttributes<HTMLDivElement>
        /// Optional callback to access the IFocusTrapZone interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IFocusTrapZone option -> unit) option with get, set
        /// Sets the HTMLElement to focus on when exiting the FocusTrapZone.
        abstract elementToFocusOnDismiss: HTMLElement option with get, set
        /// Sets the aria-labelledby attribute.
        abstract ariaLabelledBy: string option with get, set
        /// Indicates if this Trap Zone will allow clicks outside the FocusTrapZone
        abstract isClickableOutsideFocusTrap: bool option with get, set
        /// Indicates if this Trap Zone will ignore keeping track of HTMLElement that activated the Zone.
        abstract ignoreExternalFocusing: bool option with get, set
        /// Indicates whether focus trap zone should force focus inside the focus trap zone
        abstract forceFocusInsideTrap: bool option with get, set
        /// Indicates the selector for first focusable item
        abstract firstFocusableSelector: U2<string, (unit -> string)> option with get, set
        /// Do not put focus onto first element when render focus trap zone
        abstract disableFirstFocus: bool option with get, set
        /// Optional, onKeyDown event handler
        abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) option with get, set

module __components_FocusTrapZone_FocusTrapZonePage =
    type IComponentDemoPageProps = __components_FocusTrapZone_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract FocusTrapZonePage: FocusTrapZonePageStatic

    type [<AllowNullLiteral>] FocusTrapZonePage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FocusTrapZonePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FocusTrapZonePage

module __components_FocusZone_FocusZone =
    type IFocusZone = __components_FocusZone_FocusZone_types.IFocusZone
    type IFocusZoneProps = __components_FocusZone_FocusZone_types.IFocusZoneProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract FocusZone: FocusZoneStatic

    type [<AllowNullLiteral>] FocusZone =
        inherit BaseComponent<IFocusZoneProps, obj>
        inherit IFocusZone
        abstract defaultProps: IFocusZoneProps with get, set
        abstract _root: obj with get, set
        abstract _id: obj with get, set
        /// The most recently focused child element. 
        abstract _activeElement: obj with get, set
        /// The child element with tabindex=0. 
        abstract _defaultFocusElement: obj with get, set
        abstract _focusAlignment: obj with get, set
        abstract _isInnerZone: obj with get, set
        /// Used to allow us to move to next focusable element even when we're focusing on a input element when pressing tab 
        abstract _processingTabKey: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        /// <summary>Sets focus to the first tabbable item in the zone.</summary>
        /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element, even if focus is already in the focus zone.</param>
        abstract focus: ?forceIntoFirstElement: bool -> bool
        /// <summary>Sets focus to a specific child element within the zone. This can be used in conjunction with
        /// onBeforeFocus to created delayed focus scenarios (like animate the scroll position to the correct
        /// location and then focus.)</summary>
        /// <param name="element">The child element within the zone to focus.</param>
        abstract focusElement: element: HTMLElement -> bool
        abstract _onFocus: obj with get, set
        /// Handle global tab presses so that we can patch tabindexes on the fly.
        abstract _onKeyDownCapture: ev: obj -> unit
        abstract _onMouseDown: obj with get, set
        abstract _setActiveElement: element: obj * ?forceAlignemnt: obj -> unit
        /// Handle the keystrokes.
        abstract _onKeyDown: obj with get, set
        /// Walk up the dom try to find a focusable element.
        abstract _tryInvokeClickForFocusable: target: obj -> unit
        /// Traverse to find first child zone.
        abstract _getFirstInnerZone: ?rootElement: obj -> unit
        abstract _moveFocus: isForward: obj * getDistanceFromCenter: obj * ?ev: obj * ?useDefaultWrap: obj -> unit
        abstract _moveFocusDown: unit -> unit
        abstract _moveFocusUp: unit -> unit
        abstract _moveFocusLeft: unit -> unit
        abstract _moveFocusRight: unit -> unit
        abstract _setFocusAlignment: element: obj * ?isHorizontal: obj * ?isVertical: obj -> unit
        abstract _isImmediateDescendantOfZone: ?element: obj -> unit
        abstract _getOwnerZone: ?element: obj -> unit
        abstract _updateTabIndexes: ?element: obj -> unit
        abstract _isElementInput: element: obj -> unit
        abstract _shouldInputLoseFocus: element: obj * ?isForward: obj -> unit
        abstract _shouldWrapFocus: element: obj * noWrapDataAttribute: obj -> unit

    type [<AllowNullLiteral>] FocusZoneStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IFocusZoneProps -> FocusZone

module __components_FocusZone_FocusZone_types =
    type FocusZone = __components_FocusZone_FocusZone.FocusZone

    /// FocusZone component class interface.
    type [<AllowNullLiteral>] IFocusZone =
        /// <summary>Sets focus to the first tabbable item in the zone.</summary>
        /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element, even if focus is already in the focus zone.</param>
        abstract focus: ?forceIntoFirstElement: bool -> bool
        /// Sets focus to a specific child element within the zone. This can be used in conjunction with
        /// onBeforeFocus to created delayed focus scenarios (like animate the scroll position to the correct
        /// location and then focus.)
        abstract focusElement: ?childElement: HTMLElement -> bool

    /// FocusZone component props.
    type [<AllowNullLiteral>] IFocusZoneProps =
        inherit React.HTMLAttributes<U2<HTMLElement, FocusZone>>
        /// Optional callback to access the IFocusZone interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IFocusZone option -> unit) option with get, set
        /// Additional class name to provide on the root element, in addition to the ms-FocusZone class.
        abstract className: string option with get, set
        /// Defines which arrows to react to.
        abstract direction: FocusZoneDirection option with get, set
        /// Optionally provide a selector for identifying the intial active element.
        abstract defaultActiveElement: string option with get, set
        /// If set, the FocusZone will not be tabbable and keyboard navigation will be disabled.
        /// This does not affect disabled attribute of any child.
        abstract disabled: bool option with get, set
        /// Element type the root element will use. Default is "div".
        abstract elementType: obj option with get, set
        /// If set, will cycle to the beginning of the targets once the user navigates to the
        /// next target while at the end, and to the end when navigate to the previous at the beginning.
        abstract isCircularNavigation: bool option with get, set
        /// If provided, this callback will be executed on keypresses to determine if the user
        /// intends to navigate into the inner zone. Returning true will ask the first inner zone to
        /// set focus.
        abstract isInnerZoneKeystroke: (React.KeyboardEvent<HTMLElement> -> bool) option with get, set
        /// Sets the aria-labelledby attribute.
        abstract ariaLabelledBy: string option with get, set
        /// Sets the aria-describedby attribute.
        abstract ariaDescribedBy: string option with get, set
        /// Callback for when one of immediate children elements gets active by getting focused
        /// or by having one of its respective children elements focused.
        abstract onActiveElementChanged: (HTMLElement -> React.FocusEvent<HTMLElement> -> unit) option with get, set
        /// Deprecated at v1.12.1. DIV props provided to the FocusZone will be mixed into the root element.
        abstract rootProps: React.HTMLAttributes<HTMLDivElement> option with get, set
        /// Callback method for determining if focus should indeed be set on the given element.
        abstract onBeforeFocus: (HTMLElement -> bool) option with get, set
        /// Allow focus to move to root 
        abstract allowFocusRoot: bool option with get, set
        /// Allows tab key to be handled to tab through a list of items in the focus zone,
        /// an unfortunate side effect is that users will not be able to tab out of the focus zone
        /// and have to hit escape or some other key.
        abstract allowTabKey: bool option with get, set
        /// Allows tab key to be handled to tab through a list of items in the focus zone,
        /// an unfortunate side effect is that users will not be able to tab out of the focus zone
        /// and have to hit escape or some other key.
        abstract handleTabKey: FocusZoneTabbableElements option with get, set
        /// A callback method to determine if the input element should lose focus on arrow keys
        ///   
        abstract shouldInputLoseFocusOnArrowKey: (HTMLInputElement -> bool) option with get, set
        /// Whether the to check for data-no-horizontal-wrap or data-no-vertical-wrap attributes
        /// when determining how to move focus
        abstract checkForNoWrap: bool option with get, set
        /// Whether the FocusZone should allow focus events to propagate past the FocusZone
        abstract doNotAllowFocusEventToPropagate: bool option with get, set
        /// Callback to notify creators that focus has been set on the FocusZone
        abstract onFocusNotification: (unit -> unit) option with get, set

    type [<RequireQualifiedAccess>] FocusZoneTabbableElements =
        | None = 0
        | All = 1
        | InputOnly = 2

    type [<RequireQualifiedAccess>] FocusZoneDirection =
        | Vertical = 0
        | Horizontal = 1
        | Bidirectional = 2

module __components_FocusZone_FocusZonePage =
    type IComponentDemoPageProps = __components_FocusZone_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract FocusZonePage: FocusZonePageStatic

    type [<AllowNullLiteral>] FocusZonePage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FocusZonePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FocusZonePage

module __components_GroupedList_GroupedList_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract GroupedListStatus: obj

module __components_GroupedList_GroupedList =
    type BaseComponent = Utilities.BaseComponent
    type IGroupedList = __components_GroupedList_GroupedList_types.IGroupedList
    type IGroupedListProps = __components_GroupedList_GroupedList_types.IGroupedListProps
    type IGroup = __components_GroupedList_GroupedList_types.IGroup
    type ScrollToMode = List.ScrollToMode
    type SelectionMode = __utilities_selection_index.SelectionMode

    type [<AllowNullLiteral>] IExports =
        abstract GroupedList: GroupedListStatic

    type [<AllowNullLiteral>] IGroupedListState =
        abstract lastWidth: float option with get, set
        abstract lastSelectionMode: SelectionMode option with get, set
        abstract groups: ResizeArray<IGroup> option with get, set

    type [<AllowNullLiteral>] GroupedList =
        inherit BaseComponent<IGroupedListProps, IGroupedListState>
        inherit IGroupedList
        abstract defaultProps: obj with get, set
        abstract refs: obj with get, set
        abstract _list: obj with get, set
        abstract _isSomeGroupExpanded: obj with get, set
        abstract scrollToIndex: index: float * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
        abstract componentWillReceiveProps: newProps: IGroupedListProps -> unit
        abstract render: unit -> JSX.Element
        abstract forceUpdate: unit -> unit
        abstract toggleCollapseAll: allCollapsed: bool -> unit
        abstract _renderGroup: obj with get, set
        abstract _returnOne: unit -> unit
        abstract _getGroupKey: group: obj * index: obj -> unit
        abstract _getGroupNestingDepth: unit -> unit
        abstract _onToggleCollapse: obj with get, set
        abstract _onToggleSelectGroup: obj with get, set
        abstract _forceListUpdates: ?groups: obj -> unit
        abstract _onToggleSummarize: obj with get, set
        abstract _getPageSpecification: obj with get, set
        abstract _computeIsSomeGroupExpanded: groups: obj -> unit
        abstract _updateIsSomeGroupExpanded: unit -> unit

    type [<AllowNullLiteral>] GroupedListStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IGroupedListProps -> GroupedList

module __components_GroupedList_GroupedList_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract group: obj
        abstract groupIsDropping: obj

module __components_GroupedList_GroupedList_types =
    type GroupedList = __components_GroupedList_GroupedList.GroupedList
    type IList = List.IList
    type IListProps = List.IListProps
    type IRenderFunction = Utilities.IRenderFunction
    type IDragDropContext = __utilities_dragdrop_index.IDragDropContext
    type IDragDropEvents = __utilities_dragdrop_index.IDragDropEvents
    type IDragDropHelper = __utilities_dragdrop_index.IDragDropHelper
    type ISelection = __utilities_selection_index.ISelection
    type SelectionMode = __utilities_selection_index.SelectionMode
    type IViewport = __utilities_decorators_withViewport.IViewport

    type [<RequireQualifiedAccess>] CollapseAllVisibility =
        | Hidden = 0
        | Visible = 1

    type [<AllowNullLiteral>] IGroupedList =
        inherit IList
        /// Ensures that the list content is updated. Call this in cases where the list prop updates don't change, but the list
        /// still needs to be re-evaluated. For example, if a sizer bar is adjusted and causes the list width to change, you can
        /// call this to force a re-evaluation. Be aware that this can be an expensive operation and should be done sparingly.
        abstract forceUpdate: (unit -> unit) with get, set
        /// Toggles the collapsed state of all the groups in the list.
        abstract toggleCollapseAll: (bool -> unit) with get, set

    type [<AllowNullLiteral>] IGroupedListProps =
        inherit React.Props<GroupedList>
        /// Optional callback to access the IGroupedList interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IGroupedList option -> unit) option with get, set
        /// Optional class name to add to the root element. 
        abstract className: string option with get, set
        /// Map of callback functions related to drag and drop functionality. 
        abstract dragDropEvents: IDragDropEvents option with get, set
        /// helper to manage drag/drop across item and groups 
        abstract dragDropHelper: IDragDropHelper option with get, set
        /// Event names and corresponding callbacks that will be registered to groups and rendered elements 
        abstract eventsToRegister: ResizeArray<obj> option with get, set
        /// Optional override properties to render groups. 
        abstract groupProps: IGroupRenderProps option with get, set
        /// Optional grouping instructions. 
        abstract groups: ResizeArray<IGroup> option with get, set
        /// List of items to render. 
        abstract items: ResizeArray<obj option> with get, set
        /// Optional properties to pass through to the list components being rendered. 
        abstract listProps: IListProps option with get, set
        /// Rendering callback to render the group items. 
        abstract onRenderCell: (float -> obj option -> float -> React.ReactNode) with get, set
        /// Optional selection model to track selection state.  
        abstract selection: ISelection option with get, set
        /// Controls how/if the list manages selection. 
        abstract selectionMode: SelectionMode option with get, set
        /// Optional Viewport, provided by the parent component. 
        abstract viewport: IViewport option with get, set
        /// Optional callback when the group expand state changes between all collapsed and at least one group is expanded. 
        abstract onGroupExpandStateChanged: (bool -> unit) option with get, set
        /// boolean to control if pages containing unchanged items should be cached, this is a perf optimization
        /// The same property in List.Props
        abstract usePageCache: bool option with get, set
        /// Optional callback to determine whether the list should be rendered in full, or virtualized.
        /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
        /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
        /// The default implementation will virtualize when this callback is not provided.
        abstract onShouldVirtualize: (IListProps -> bool) option with get, set

    type [<AllowNullLiteral>] IGroup =
        /// Unique identifier for the group.
        abstract key: string with get, set
        /// Display name for the group, rendered on the header.
        abstract name: string with get, set
        /// Start index for the group within the given items.
        abstract startIndex: float with get, set
        /// How many items should be rendered within the group.
        abstract count: float with get, set
        /// Nested groups, if any.
        abstract children: ResizeArray<IGroup> option with get, set
        /// Number indicating the level of nested groups.
        abstract level: float option with get, set
        /// Deprecated at 1.0.0, selection state will be controled by the selection store only.
        abstract isSelected: bool option with get, set
        /// If all the items in the group are collapsed.
        abstract isCollapsed: bool option with get, set
        /// If the items within the group are summarized or showing all.
        abstract isShowingAll: bool option with get, set
        /// If drag/drop is enabled for the group header.
        abstract isDropEnabled: bool option with get, set
        /// Arbitrary data required to be preserved by the caller.
        abstract data: obj option with get, set
        /// Optional accessibility label (aria-label) attribute that will be stamped on to the element.
        /// If none is specified, the arai-label attribute will contain the group name
        abstract ariaLabel: string option with get, set
        /// Optional flag to indicate the group has more data to load than the current group count indicated.
        /// This can be used to indicate that a plus should be rendered next to the group count in the header.
        abstract hasMoreData: bool option with get, set

    type [<AllowNullLiteral>] IGroupRenderProps =
        /// Boolean indicating if all groups are in collapsed state. 
        abstract isAllGroupsCollapsed: bool option with get, set
        /// Grouping item limit. 
        abstract getGroupItemLimit: (IGroup -> float) option with get, set
        /// Callback for when all groups are expanded or collapsed. 
        abstract onToggleCollapseAll: (bool -> unit) option with get, set
        /// Information to pass in to the group header. 
        abstract headerProps: IGroupDividerProps option with get, set
        /// Information to pass in to the group Show all footer. 
        abstract showAllProps: IGroupDividerProps option with get, set
        /// Information to pass in to the group footer. 
        abstract footerProps: IGroupDividerProps option with get, set
        /// Override which allows the caller to provide a custom header.
        abstract onRenderHeader: IRenderFunction<IGroupDividerProps> option with get, set
        /// Override which allows the caller to provide a custom Show All link.
        abstract onRenderShowAll: IRenderFunction<IGroupDividerProps> option with get, set
        /// Override which allows the caller to provide a custom footer.
        abstract onRenderFooter: IRenderFunction<IGroupDividerProps> option with get, set
        /// Flag to indicate whether to ignore the collapsing icon on header.
        abstract collapseAllVisibility: CollapseAllVisibility option with get, set
        /// Boolean indicating if empty groups are shown
        abstract showEmptyGroups: bool option with get, set

    type [<AllowNullLiteral>] IGroupDividerProps =
        abstract componentRef: (unit -> unit) option with get, set
        /// Callback to determine if a group has missing items and needs to load them from the server. 
        abstract isGroupLoading: (IGroup -> bool) option with get, set
        /// Text shown on group headers to indicate the group is being loaded. 
        abstract loadingText: string option with get, set
        /// The group to be rendered by the header. 
        abstract group: IGroup option with get, set
        /// The index of the group. 
        abstract groupIndex: float option with get, set
        /// The indent level of the group. 
        abstract groupLevel: float option with get, set
        /// If all items in the group are selected. 
        abstract selected: bool option with get, set
        /// Deprecated at v.65.1 and will be removed by v 1.0. Use 'selected' instead.
        abstract isSelected: bool option with get, set
        /// A reference to the viewport in which the header is rendered. 
        abstract viewport: IViewport option with get, set
        /// The selection mode of the list the group lives within. 
        abstract selectionMode: SelectionMode option with get, set
        /// Text to display for the group footer. 
        abstract footerText: string option with get, set
        /// Text to display for the group "Show All" link. 
        abstract showAllLinkText: string option with get, set
        /// Callback for when the group "Show All" link is clicked 
        abstract onToggleSummarize: (IGroup -> unit) option with get, set
        /// Callback for when the group header is clicked. 
        abstract onGroupHeaderClick: (IGroup -> unit) option with get, set
        /// Callback for when the group is expanded or collapsed. 
        abstract onToggleCollapse: (IGroup -> unit) option with get, set
        /// Callback for when the group is selected. 
        abstract onToggleSelectGroup: (IGroup -> unit) option with get, set
        /// Determines if the group selection check box is shown for collapsed groups. 
        abstract isCollapsedGroupSelectVisible: bool option with get, set

module __components_GroupedList_GroupedListPage =
    type IComponentDemoPageProps = __components_GroupedList_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract GroupedListPage: GroupedListPageStatic

    type [<AllowNullLiteral>] GroupedListPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] GroupedListPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GroupedListPage

module __components_GroupedList_GroupedListSection =
    type IGroup = __components_GroupedList_GroupedList_types.IGroup
    type IGroupDividerProps = __components_GroupedList_GroupedList_types.IGroupDividerProps
    type IDragDropContext = __utilities_dragdrop_index.IDragDropContext
    type IDragDropEvents = __utilities_dragdrop_index.IDragDropEvents
    type IDragDropHelper = __utilities_dragdrop_index.IDragDropHelper
    type BaseComponent = Utilities.BaseComponent
    type IRenderFunction = Utilities.IRenderFunction
    type ISelection = __utilities_selection_index.ISelection
    type SelectionMode = __utilities_selection_index.SelectionMode
    type IViewport = __utilities_decorators_withViewport.IViewport
    type IListProps = __components_List_index.IListProps

    type [<AllowNullLiteral>] IExports =
        abstract GroupedListSection: GroupedListSectionStatic

    type [<AllowNullLiteral>] IGroupedListSectionProps =
        inherit React.Props<GroupedListSection>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// Map of callback functions related to drag and drop functionality. 
        abstract dragDropEvents: IDragDropEvents option with get, set
        /// helper to manage drag/drop across item rows and groups 
        abstract dragDropHelper: IDragDropHelper option with get, set
        /// Event names and corresponding callbacks that will be registered to the group and the rendered elements 
        abstract eventsToRegister: ResizeArray<obj> option with get, set
        /// Information to pass in to the group footer. 
        abstract footerProps: IGroupDividerProps option with get, set
        /// Grouping item limit. 
        abstract getGroupItemLimit: (IGroup -> float) option with get, set
        /// Optional grouping instructions. 
        abstract groupIndex: float option with get, set
        /// Optional group nesting level. 
        abstract groupNestingDepth: float option with get, set
        /// Optional grouping instructions. 
        abstract group: IGroup option with get, set
        /// Information to pass in to the group header. 
        abstract headerProps: IGroupDividerProps option with get, set
        /// List of items to render. 
        abstract items: ResizeArray<obj option> with get, set
        /// Optional list props to pass to list renderer.  
        abstract listProps: obj option with get, set
        /// Rendering callback to render the group items. 
        abstract onRenderCell: (float -> obj option -> float -> React.ReactNode) with get, set
        /// Optional selection model to track selection state.  
        abstract selection: ISelection option with get, set
        /// Controls how/if the details list manages selection. 
        abstract selectionMode: SelectionMode option with get, set
        /// Information to pass in to the group Show All footer. 
        abstract showAllProps: IGroupDividerProps option with get, set
        /// Optional Viewport, provided by the parent component. 
        abstract viewport: IViewport option with get, set
        /// Override for rendering the group header. 
        abstract onRenderGroupHeader: IRenderFunction<IGroupDividerProps> option with get, set
        /// Override for rendering the group Show All link. 
        abstract onRenderGroupShowAll: IRenderFunction<IGroupDividerProps> option with get, set
        /// Override for rendering the group footer. 
        abstract onRenderGroupFooter: IRenderFunction<IGroupDividerProps> option with get, set
        /// Optional callback to determine whether the list should be rendered in full, or virtualized.
        /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
        /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
        /// The default implementation will virtualize when this callback is not provided.
        abstract onShouldVirtualize: (IListProps -> bool) option with get, set

    type [<AllowNullLiteral>] IGroupedListSectionState =
        abstract isDropping: bool option with get, set
        abstract isSelected: bool option with get, set

    type [<AllowNullLiteral>] GroupedListSection =
        inherit BaseComponent<IGroupedListSectionProps, IGroupedListSectionState>
        abstract _root: obj with get, set
        abstract _list: obj with get, set
        abstract _dragDropSubscription: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentDidUpdate: previousProps: IGroupedListSectionProps -> unit
        abstract render: unit -> JSX.Element
        abstract forceUpdate: unit -> unit
        abstract forceListUpdate: unit -> unit
        abstract _onRenderGroupHeader: obj with get, set
        abstract _onRenderGroupShowAll: obj with get, set
        abstract _onRenderGroupFooter: obj with get, set
        abstract _onSelectionChange: unit -> unit
        abstract _onRenderGroupCell: onRenderCell: obj * groupNestingDepth: obj -> unit
        abstract _onRenderGroup: renderCount: obj -> unit
        abstract _renderSubGroup: obj with get, set
        abstract _returnOne: unit -> unit
        abstract _getGroupKey: group: obj * index: obj -> unit
        /// collect all the data we need to enable drag/drop for a group
        abstract _getGroupDragDropOptions: obj with get, set
        /// update groupIsDropping state based on the input value, which is used to change style during drag and drop
        abstract _updateDroppingState: obj with get, set
        /// get the correct css class to reflect the dropping state for a given group
        /// 
        /// If the group is the current drop target, return the default dropping class name
        /// Otherwise, return '';
        abstract _getDroppingClassName: unit -> unit

    type [<AllowNullLiteral>] GroupedListSectionStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IGroupedListSectionProps -> GroupedListSection

module __components_GroupedList_GroupFooter =
    type BaseComponent = Utilities.BaseComponent
    type IGroupDividerProps = __components_GroupedList_GroupedList_types.IGroupDividerProps

    type [<AllowNullLiteral>] IExports =
        abstract GroupFooter: GroupFooterStatic

    type [<AllowNullLiteral>] GroupFooter =
        inherit BaseComponent<IGroupDividerProps, obj>
        abstract render: unit -> JSX.Element option

    type [<AllowNullLiteral>] GroupFooterStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GroupFooter

module __components_GroupedList_GroupFooter_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj

module __components_GroupedList_GroupHeader =
    type BaseComponent = Utilities.BaseComponent
    type IGroupDividerProps = __components_GroupedList_GroupedList_types.IGroupDividerProps

    type [<AllowNullLiteral>] IExports =
        abstract GroupHeader: GroupHeaderStatic

    type [<AllowNullLiteral>] IGroupHeaderState =
        abstract isCollapsed: bool with get, set
        abstract isLoadingVisible: bool with get, set

    type [<AllowNullLiteral>] GroupHeader =
        inherit BaseComponent<IGroupDividerProps, IGroupHeaderState>
        abstract componentWillReceiveProps: newProps: obj option -> unit
        abstract render: unit -> JSX.Element option
        abstract _onToggleCollapse: obj with get, set
        abstract _onToggleSelectGroupClick: obj with get, set
        abstract _onHeaderClick: obj with get, set

    type [<AllowNullLiteral>] GroupHeaderStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IGroupDividerProps -> GroupHeader

module __components_GroupedList_GroupHeader_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract rootIsSelected: obj
        abstract groupHeaderContainer: obj
        abstract check: obj
        abstract expand: obj
        abstract title: obj
        abstract headerCount: obj
        abstract expandIsCollapsed: obj
        abstract dropIcon: obj

module __components_GroupedList_GroupShowAll =
    type BaseComponent = Utilities.BaseComponent
    type IGroupDividerProps = __components_GroupedList_GroupedList_types.IGroupDividerProps

    type [<AllowNullLiteral>] IExports =
        abstract GroupShowAll: GroupShowAllStatic

    type [<AllowNullLiteral>] IGroupDividerProps =
        /// The Show All link text.
        abstract showAllLinkText: string with get, set

    type [<AllowNullLiteral>] GroupShowAll =
        inherit BaseComponent<IGroupDividerProps, obj>
        abstract defaultProps: IGroupDividerProps with get, set
        abstract render: unit -> JSX.Element option
        abstract _onSummarizeClick: obj with get, set

    type [<AllowNullLiteral>] GroupShowAllStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GroupShowAll

module __components_GroupedList_GroupShowAll_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj

module __components_GroupedList_GroupSpacer =

    type [<AllowNullLiteral>] IExports =
        abstract GroupSpacer: (IGroupSpacerProps -> U2<obj, JSX.Element>)

    type [<AllowNullLiteral>] IGroupSpacerProps =
        abstract count: float with get, set

module __components_GroupedList_GroupSpacer_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj

module __components_HoverCard_ExpandingCard =
    type BaseComponent = Utilities.BaseComponent
    type IExpandingCardProps = __components_HoverCard_ExpandingCard_types.IExpandingCardProps
    type DirectionalHint = __common_DirectionalHint.DirectionalHint

    type [<AllowNullLiteral>] IExports =
        abstract ExpandingCard: ExpandingCardStatic

    type [<AllowNullLiteral>] IExpandingCardState =
        abstract firstFrameRendered: bool with get, set
        abstract needsScroll: bool with get, set

    type [<AllowNullLiteral>] ExpandingCard =
        inherit BaseComponent<IExpandingCardProps, IExpandingCardState>
        abstract defaultProps: obj with get, set
        abstract _styles: obj with get, set
        abstract _callout: obj with get, set
        abstract _expandedElem: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onKeyDown: obj with get, set
        abstract _onRenderCompactCard: obj with get, set
        abstract _onRenderExpandedCard: obj with get, set
        abstract _checkNeedsScroll: obj with get, set

    type [<AllowNullLiteral>] ExpandingCardStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IExpandingCardProps -> ExpandingCard

module __components_HoverCard_ExpandingCard_styles =
    type IExpandingCardStyles = __components_HoverCard_ExpandingCard_types.IExpandingCardStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IExpandingCardStyles option -> IExpandingCardStyles)

module __components_HoverCard_ExpandingCard_types =
    type ExpandingCard = __components_HoverCard_ExpandingCard.ExpandingCard
    type IRenderFunction = Utilities.IRenderFunction
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type DirectionalHint = __common_DirectionalHint.DirectionalHint

    type [<AllowNullLiteral>] IExpandingCard =
        interface end

    /// ExpandingCard component props.
    type [<AllowNullLiteral>] IExpandingCardProps =
        inherit React.HTMLAttributes<U2<HTMLDivElement, ExpandingCard>>
        /// Optional callback to access the IExpandingCard interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IExpandingCard option -> unit) option with get, set
        /// Item to be returned with onRender functions
        abstract renderData: obj option with get, set
        /// Render function to populate compact content area
        abstract onRenderCompactCard: IRenderFunction<IExpandingCardProps> option with get, set
        /// Render function to populate expanded content area
        abstract onRenderExpandedCard: IRenderFunction<IExpandingCardProps> option with get, set
        /// Element to anchor the ExpandingCard to.
        abstract targetElement: HTMLElement option with get, set
        /// Callback upon focus or mouse enter event
        abstract onEnter: (obj option -> unit) option with get, set
        /// Callback upon blur or mouse leave event
        abstract onLeave: (obj option -> unit) option with get, set
        /// Height of compact card
        abstract compactCardHeight: float option with get, set
        /// Height of expanded card
        abstract expandedCardHeight: float option with get, set
        /// Use to open the card in expanded format and not wait for the delay
        abstract mode: ExpandingCardMode option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// How the element should be positioned
        abstract directionalHint: DirectionalHint option with get, set
        /// The gap between the card and the target
        abstract gapSpace: float option with get, set
        /// Custom styles for this component
        abstract styles: IExpandingCardStyles option with get, set
        /// Make callout content show on the set side
        abstract directionalHintFixed: bool option with get, set
        /// Trap focus or not
        abstract trapFocus: bool option with get, set
        /// Focus on first element by default on card or not
        abstract firstFocus: bool option with get, set

    type [<RequireQualifiedAccess>] ExpandingCardMode =
        | Compact = 0
        | Expanded = 1

    type [<RequireQualifiedAccess>] OpenCardMode =
        | Hover = 0
        | HotKey = 1

    type [<AllowNullLiteral>] IExpandingCardStyles =
        /// Style for the root element in the default enabled, non-toggled state.
        abstract root: IStyle option with get, set
        /// Style for the main card element.
        abstract compactCard: IStyle option with get, set
        /// Base Style for the expanded card content
        abstract expandedCard: IStyle option with get, set
        /// Style for the expanded card scroll content
        abstract expandedCardScroll: IStyle option with get, set

module __components_HoverCard_HoverCard_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract HoverCardStatus: obj

module __components_HoverCard_HoverCard =
    type BaseComponent = Utilities.BaseComponent
    type IHoverCardProps = __components_HoverCard_HoverCard_types.IHoverCardProps
    type ExpandingCardMode = __components_HoverCard_ExpandingCard_types.ExpandingCardMode
    type OpenCardMode = __components_HoverCard_ExpandingCard_types.OpenCardMode

    type [<AllowNullLiteral>] IExports =
        abstract HoverCard: HoverCardStatic

    type [<AllowNullLiteral>] IHoverCardState =
        abstract isHoverCardVisible: bool option with get, set
        abstract mode: ExpandingCardMode option with get, set
        abstract openMode: OpenCardMode option with get, set

    type [<AllowNullLiteral>] HoverCard =
        inherit BaseComponent<IHoverCardProps, IHoverCardState>
        abstract defaultProps: obj with get, set
        abstract _hoverCard: obj with get, set
        abstract _dismissTimerId: obj with get, set
        abstract _openTimerId: obj with get, set
        abstract _currentMouseTarget: obj with get, set
        abstract _styles: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: prevProps: IHoverCardProps * prevState: IHoverCardState -> unit
        abstract render: unit -> JSX.Element
        abstract _getTargetElement: unit -> unit
        abstract _shouldBlockHoverCard: unit -> unit
        abstract _cardOpen: obj with get, set
        abstract _executeCardOpen: obj with get, set
        abstract _cardDismiss: obj with get, set
        abstract _executeCardDimiss: obj with get, set
        abstract _instantOpenAsExpanded: obj with get, set

    type [<AllowNullLiteral>] HoverCardStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IHoverCardProps -> HoverCard

module __components_HoverCard_HoverCard_styles =
    type IHoverCardStyles = __components_HoverCard_HoverCard_types.IHoverCardStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IHoverCardStyles option -> IHoverCardStyles)

module __components_HoverCard_HoverCard_types =
    type HoverCard = __components_HoverCard_HoverCard.HoverCard
    type IExpandingCardProps = __components_HoverCard_ExpandingCard_types.IExpandingCardProps
    type IStyle = Styling.IStyle

    type [<AllowNullLiteral>] IHoverCard =
        interface end

    /// HoverCard component props.
    type [<AllowNullLiteral>] IHoverCardProps =
        inherit React.HTMLAttributes<U2<HTMLDivElement, HoverCard>>
        /// Optional callback to access the IHoverCardHost interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IHoverCard option -> unit) option with get, set
        /// Additional properties to pass through for HoverCard, reference detail properties in IHoverCardProps
        abstract expandingCardProps: IExpandingCardProps option with get, set
        /// Whether or not to mark the container as described by the hover card.
        /// If not specified, the caller should mark as element as described by the hover card id.
        abstract setAriaDescribedBy: bool option with get, set
        /// Length of compact card delay
        abstract cardOpenDelay: float option with get, set
        /// Length of card dismiss delay. A min number is necessary for pointer to hop between target and card
        abstract cardDismissDelay: float option with get, set
        /// Time in ms when expanded card should open after compact card
        abstract expandedCardOpenDelay: float option with get, set
        /// If true disables Card dismiss upon mouse leave, so that card sticks around.
        abstract sticky: bool option with get, set
        /// Enables instant open of the full card upon click
        abstract instantOpenOnClick: bool option with get, set
        /// Custom styles for this component
        abstract styles: IHoverCardStyles option with get, set
        /// Optional target element to tag hover card on
        abstract target: U2<HTMLElement, string> option with get, set
        /// Callback when card becomes visible
        abstract onCardVisible: (unit -> unit) option with get, set
        /// Callback when card hides
        abstract onCardHide: (unit -> unit) option with get, set
        /// Trap focus or not
        abstract trapFocus: bool option with get, set
        /// Should block hover card or not
        abstract shouldBlockHoverCard: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] IHoverCardStyles =
        /// Style for the host element in the default enabled, non-toggled state.
        abstract host: IStyle option with get, set

module __components_HoverCard_HoverCardPage =
    type IComponentDemoPageProps = __components_HoverCard_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract HoverCardPage: HoverCardPageStatic

    type [<AllowNullLiteral>] HoverCardPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] HoverCardPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> HoverCardPage

module __components_Icon_Icon_base =
    type IIconProps = __components_Icon_Icon_types.IIconProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract IconBase: IconBaseStatic

    type [<AllowNullLiteral>] IIconState =
        abstract imageLoadError: bool with get, set

    type [<AllowNullLiteral>] IconBase =
        inherit BaseComponent<IIconProps, IIconState>
        abstract render: unit -> JSX.Element
        abstract onImageLoadingStateChange: obj with get, set
        abstract _getIconContent: ?name: obj -> unit

    type [<AllowNullLiteral>] IconBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IIconProps -> IconBase

module __components_Icon_Icon_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract IconStatus: obj

module __components_Icon_Icon =
    type IIconProps = __components_Icon_Icon_types.IIconProps

    type [<AllowNullLiteral>] IExports =
        abstract Icon: (IIconProps -> JSX.Element)

module __components_Icon_Icon_styles =
    type IIconStyleProps = __components_Icon_Icon_types.IIconStyleProps
    type IIconStyles = __components_Icon_Icon_types.IIconStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IIconStyleProps -> IIconStyles)

module __components_Icon_Icon_types =
    type IImageProps = __components_Image_Image_types.IImageProps
    type IStyle = Styling.IStyle
    type IBaseProps = Utilities.IBaseProps
    type IStyleFunction = Utilities.IStyleFunction

    type [<RequireQualifiedAccess>] IconType =
        | Default = 0
        | Image = 1
        | Default = 100000
        | Image = 100001

    type [<AllowNullLiteral>] IIconProps =
        inherit IBaseProps
        inherit React.HTMLAttributes<HTMLElement>
        /// The name of the icon to use from the icon font. If string is empty, a placeholder icon will be rendered the same width as an icon
        abstract iconName: string option with get, set
        /// The aria label of the button for the benefit of screen readers.
        abstract ariaLabel: string option with get, set
        /// The type of icon to render (image or icon font).
        abstract iconType: IconType option with get, set
        /// If rendering an image icon, these props will be passed to the Image component.
        abstract imageProps: IImageProps option with get, set
        /// If rendering an image icon, this function callback will be invoked in the event loading the image errors.
        abstract imageErrorAs: U2<React.StatelessComponent<IImageProps>, React.ComponentClass<IImageProps>> option with get, set
        /// Gets the styles for an Icon.
        abstract getStyles: IStyleFunction<IIconStyleProps, IIconStyles> option with get, set
        /// Deprecated: use getStyles.
        abstract styles: IIconStyles option with get, set

    type [<AllowNullLiteral>] IIconStyleProps =
        abstract className: string option with get, set
        abstract iconClassName: string option with get, set
        abstract isPlaceholder: bool with get, set
        abstract isImage: bool with get, set
        abstract styles: obj option with get, set

    type [<AllowNullLiteral>] IIconStyles =
        abstract root: IStyle option with get, set
        /// Deprecated. Use 'root'.
        abstract imageContainer: IStyle option with get, set

module __components_Icon_IconPage =
    type IComponentDemoPageProps = __components_Icon_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract IconPage: IconPageStatic

    type [<AllowNullLiteral>] IconPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] IconPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IconPage

module __components_Image_Image_base =
    type BaseComponent = Utilities.BaseComponent
    type IImageProps = __components_Image_Image_types.IImageProps
    type ImageLoadState = __components_Image_Image_types.ImageLoadState

    type [<AllowNullLiteral>] IExports =
        abstract ImageBase: ImageBaseStatic

    type [<AllowNullLiteral>] IImageState =
        abstract loadState: ImageLoadState option with get, set

    type [<AllowNullLiteral>] ImageBase =
        inherit BaseComponent<IImageProps, IImageState>
        abstract defaultProps: obj with get, set
        abstract _svgRegex: obj with get, set
        abstract _coverStyle: obj with get, set
        abstract _imageElement: obj with get, set
        abstract _frameElement: obj with get, set
        abstract componentWillReceiveProps: nextProps: IImageProps -> unit
        abstract componentDidUpdate: prevProps: IImageProps * prevState: IImageState -> unit
        abstract render: unit -> JSX.Element
        abstract _onImageLoaded: obj with get, set
        abstract _checkImageLoaded: unit -> unit
        abstract _computeCoverStyle: props: obj -> unit
        abstract _onImageError: obj with get, set

    type [<AllowNullLiteral>] ImageBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IImageProps -> ImageBase

module __components_Image_Image_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ImageStatus: obj

module __components_Image_Image =
    type IImageProps = __components_Image_Image_types.IImageProps

    type [<AllowNullLiteral>] IExports =
        abstract Image: (IImageProps -> JSX.Element)

module __components_Image_Image_styles =
    type IImageStyleProps = __components_Image_Image_types.IImageStyleProps
    type IImageStyles = __components_Image_Image_types.IImageStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IImageStyleProps -> IImageStyles)

module __components_Image_Image_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IImage =
        interface end

    type [<AllowNullLiteral>] IImageProps =
        inherit React.ImgHTMLAttributes<HTMLImageElement>
        /// Optional callback to access the ICheckbox interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IImage option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IImageStyleProps, IImageStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Component
        abstract className: string option with get, set
        /// If true, fades the image in when loaded.
        abstract shouldFadeIn: bool option with get, set
        /// If true, the image starts as visible and is hidden on error. Otherwise, the image is hidden until
        /// it is successfully loaded. This disables shouldFadeIn.
        abstract shouldStartVisible: bool option with get, set
        /// Used to determine how the image is scaled and cropped to fit the frame.
        abstract imageFit: ImageFit option with get, set
        /// Deprecated at v1.3.6, to replace the src in case of errors, use onLoadingStateChange instead and
        /// rerender the Image with a difference src.
        abstract errorSrc: string option with get, set
        /// If true, the image frame will expand to fill its parent container.
        abstract maximizeFrame: bool option with get, set
        /// Optional callback method for when the image load state has changed.
        /// The 'loadState' parameter indicates the current state of the Image.
        abstract onLoadingStateChange: (ImageLoadState -> unit) option with get, set
        /// Specifies the cover style to be used for this image. If not
        /// specified, this will be dynamically calculated based on the
        /// aspect ratio for the image.
        abstract coverStyle: ImageCoverStyle option with get, set

    type [<RequireQualifiedAccess>] ImageFit =
        | Center = 0
        | Contain = 1
        | Cover = 2
        | None = 3

    type [<RequireQualifiedAccess>] ImageCoverStyle =
        | Landscape = 0
        | Portrait = 1

    type [<RequireQualifiedAccess>] ImageLoadState =
        | NotLoaded = 0
        | Loaded = 1
        | Error = 2
        | ErrorLoaded = 3

    type [<AllowNullLiteral>] IImageStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// If true, the image frame will expand to fill its parent container.
        abstract maximizeFrame: bool option with get, set
        /// If true, the image is loaded
        abstract isLoaded: bool option with get, set
        /// If true, fades the image in when loaded.
        abstract shouldFadeIn: bool option with get, set
        /// If true, the image starts as visible and is hidden on error. Otherwise, the image is hidden until
        /// it is successfully loaded. This disables shouldFadeIn.
        abstract shouldStartVisible: bool option with get, set
        /// If true the image is coverStyle landscape instead of portrait
        abstract isLandscape: bool option with get, set
        /// ImageFit booleans for center, cover, contain, none
        abstract isCenter: bool option with get, set
        abstract isContain: bool option with get, set
        abstract isCover: bool option with get, set
        abstract isNone: bool option with get, set
        /// if true image load is in error
        abstract isError: bool option with get, set
        /// if true, imageFit is undefined
        abstract isNotImageFit: bool option with get, set
        /// Image width valye
        abstract width: U2<float, string> option with get, set
        /// Image height valye
        abstract height: U2<float, string> option with get, set

    type [<AllowNullLiteral>] IImageStyles =
        /// Style set for the root div element.
        abstract root: IStyle with get, set
        /// Style set for the img element.
        abstract image: IStyle with get, set

module __components_Image_ImagePage =
    type IComponentDemoPageProps = __components_Image_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ImagePage: ImagePageStatic

    type [<AllowNullLiteral>] ImagePage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImagePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImagePage

module __components_Keytip_Keytip_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract KeytipStatus: obj

module __components_Keytip_Keytip =
    type BaseComponent = Utilities.BaseComponent
    type IKeytip = __components_Keytip_Keytip_types.IKeytip
    type IKeytipProps = __components_Keytip_Keytip_types.IKeytipProps

    type [<AllowNullLiteral>] IExports =
        abstract Keytip: KeytipStatic

    /// A callout corresponding to another Fabric component to describe a key sequence that will activate that component
    type [<AllowNullLiteral>] Keytip =
        inherit BaseComponent<IKeytipProps, obj>
        inherit IKeytip
        abstract render: unit -> JSX.Element

    /// A callout corresponding to another Fabric component to describe a key sequence that will activate that component
    type [<AllowNullLiteral>] KeytipStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Keytip

module __components_Keytip_Keytip_styles =
    type IKeytipStyleProps = __components_Keytip_Keytip_types.IKeytipStyleProps
    type IKeytipStyles = __components_Keytip_Keytip_types.IKeytipStyles
    type ICalloutContentStyleProps = Callout.ICalloutContentStyleProps
    type ICalloutContentStyles = Callout.ICalloutContentStyles
    type IStyleFunction = Utilities.IStyleFunction
    type IPoint = Utilities.IPoint

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IKeytipStyleProps -> IKeytipStyles)
        abstract getCalloutStyles: (ICalloutContentStyleProps -> ICalloutContentStyles)
        abstract getCalloutOffsetStyles: (IPoint -> IStyleFunction<ICalloutContentStyleProps, ICalloutContentStyles>)

module __components_Keytip_Keytip_types =
    type ICalloutProps = Callout.ICalloutProps
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction
    type IPoint = Utilities.IPoint

    type [<AllowNullLiteral>] IKeytip =
        interface end

    type [<AllowNullLiteral>] IKeytipProps =
        /// Optional callback to access the Keytip component. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IKeytip option -> unit) option with get, set
        /// Content to put inside the keytip
        abstract content: string with get, set
        /// Theme for the component
        abstract theme: ITheme option with get, set
        /// T/F if the corresponding control for this keytip is disabled
        abstract disabled: bool option with get, set
        /// T/F if the keytip is visible
        abstract visible: bool option with get, set
        /// Function to call when this keytip is activated
        /// 'el' is the DOM element marked with 'data-ktp-execute-target'
        abstract onExecute: (HTMLElement option -> unit) option with get, set
        /// Function to call when the keytip is returned to
        /// 'el' is the DOM element marked with 'data-ktp-execute-target'
        abstract onReturn: (HTMLElement option -> unit) option with get, set
        /// Array of KeySequences which is the full key sequence to trigger this keytip
        /// Should not include initial 'start' key sequence
        abstract keySequences: ResizeArray<string> with get, set
        /// Full KeySequence of the overflow set button, will be set automatically if this keytip is inside an overflow
        abstract overflowSetSequence: ResizeArray<string> option with get, set
        /// ICalloutProps to pass to the callout element
        abstract calloutProps: ICalloutProps option with get, set
        /// Optional styles for the component.
        abstract getStyles: IStyleFunction<IKeytipStyleProps, IKeytipStyles> option with get, set
        /// Offset x and y for the keytip, added from the top-left corner
        /// By default the keytip will be anchored to the bottom-center of the element
        abstract offset: IPoint option with get, set
        /// Whether or not this keytip will have children keytips that are dynamically created (DOM is generated on keytip activation)
        /// Common cases are a Pivot or Modal
        abstract hasDynamicChildren: bool option with get, set
        /// Whether or not this keytip belongs to a component that has a menu
        /// Keytip mode will stay on when a menu is opened, even if the items in that menu have no keytips
        abstract hasMenu: bool option with get, set

    /// Props to style Keytip component
    type [<AllowNullLiteral>] IKeytipStyleProps =
        /// The theme for the keytip.
        abstract theme: ITheme with get, set
        /// Whether the keytip is disabled or not.
        abstract disabled: bool option with get, set
        /// T/F if the keytip is visible
        abstract visible: bool option with get, set

    type [<AllowNullLiteral>] IKeytipStyles =
        /// Style for the div container surrounding the keytip content.
        abstract container: IStyle with get, set
        /// Style for the keytip content element.
        abstract root: IStyle with get, set

module __components_Keytip_KeytipContent_base =
    type BaseComponent = Utilities.BaseComponent
    type IKeytipProps = __components_Keytip_Keytip_types.IKeytipProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipContentBase: KeytipContentBaseStatic

    /// A component corresponding the the content rendered inside the callout of the keytip component.
    type [<AllowNullLiteral>] KeytipContentBase =
        inherit BaseComponent<IKeytipProps, obj>
        abstract render: unit -> JSX.Element

    /// A component corresponding the the content rendered inside the callout of the keytip component.
    type [<AllowNullLiteral>] KeytipContentBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> KeytipContentBase

module __components_Keytip_KeytipContent =
    type IKeytipProps = __components_Keytip_Keytip_types.IKeytipProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipContent: (IKeytipProps -> JSX.Element)

module __components_Keytip_KeytipsPage =
    type IComponentDemoPageProps = __components_Keytip_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipsPage: KeytipsPageStatic

    type [<AllowNullLiteral>] KeytipsPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] KeytipsPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> KeytipsPage

module __components_KeytipData_KeytipData =
    type BaseComponent = Utilities.BaseComponent
    type IRenderComponent = Utilities.IRenderComponent
    type IKeytipDataProps = __components_KeytipData_KeytipData_types.IKeytipDataProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipData: KeytipDataStatic

    /// A small element to help the target component correctly read out its aria-describedby for its Keytip
    type [<AllowNullLiteral>] KeytipData =
        inherit BaseComponent<obj, obj>
        abstract _uniqueId: obj with get, set
        abstract _keytipManager: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _getKtpProps: unit -> unit
        /// <summary>Gets the aria- and data- attributes to attach to the component</summary>
        /// <param name="keytipProps"></param>
        /// <param name="describedByPrepend"></param>
        abstract _getKtpAttrs: keytipProps: obj * ?describedByPrepend: obj -> unit

    /// A small element to help the target component correctly read out its aria-describedby for its Keytip
    type [<AllowNullLiteral>] KeytipDataStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> KeytipData

module __components_KeytipData_KeytipData_types =
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IKeytipDataProps =
        /// IKeytipProps to create from this KeytipData
        /// If no keytipProps are defined, a keytip won't be registered
        abstract keytipProps: IKeytipProps option with get, set
        /// String to add to the aria-describedby generated by this KeytipData
        /// It will prepend this string to the generated aria-describedby property
        abstract ariaDescribedBy: string option with get, set
        /// T/F if this keytip should be disabled upon creation
        abstract disabled: bool option with get, set

module __components_KeytipLayer_IKeytipTreeNode =

    type [<AllowNullLiteral>] IKeytipTreeNode =
        /// ID of the <Keytip> DOM element. Needed to locate the correct keytip in the KeytipLayer's 'keytip' state array
        abstract id: string with get, set
        /// KeySequence that invokes this KeytipTreeNode's onExecute function
        abstract keySequences: ResizeArray<string> with get, set
        /// Overflow set sequence for this keytip
        abstract overflowSetSequence: ResizeArray<string> option with get, set
        /// Control's execute function for when keytip is invoked, passed from the component to the Manager in the IKeytipProps
        abstract onExecute: (HTMLElement option -> unit) option with get, set
        /// Function to execute when we return to this keytip
        abstract onReturn: (HTMLElement option -> unit) option with get, set
        /// List of keytip IDs that should become visible when this keytip is pressed, can be empty
        abstract children: ResizeArray<string> with get, set
        /// Parent keytip ID
        abstract parent: string with get, set
        /// Whether or not this keytip will have children keytips that are dynamically created (DOM is generated on keytip activation)
        /// Common cases are keytips in a menu or modal
        abstract hasDynamicChildren: bool option with get, set
        /// Whether or not this keytip belongs to a component that has a menu
        /// Keytip mode will stay on when a menu is opened, even if the items in that menu have no keytips
        abstract hasMenu: bool option with get, set
        /// T/F if this keytip's component is currently disabled
        abstract disabled: bool option with get, set
        /// T/F if this keytip is a persisted keytip
        abstract persisted: bool option with get, set

module __components_KeytipLayer_KeytipLayer_base =
    type IKeytipLayerProps = __components_KeytipLayer_KeytipLayer_types.IKeytipLayerProps
    type IKeytipProps = Keytip.IKeytipProps
    type BaseComponent = Utilities.BaseComponent
    type KeytipTree = __components_KeytipLayer_KeytipTree.KeytipTree
    type IKeytipTransitionKey = __utilities_keytips_IKeytipTransitionKey.IKeytipTransitionKey

    type [<AllowNullLiteral>] IExports =
        abstract KeytipLayerBase: KeytipLayerBaseStatic

    type [<AllowNullLiteral>] IKeytipLayerState =
        abstract inKeytipMode: bool with get, set
        abstract keytips: ResizeArray<IKeytipProps> with get, set
        abstract visibleKeytips: ResizeArray<IKeytipProps> with get, set

    /// A layer that holds all keytip items
    type [<AllowNullLiteral>] KeytipLayerBase =
        inherit BaseComponent<IKeytipLayerProps, IKeytipLayerState>
        abstract defaultProps: IKeytipLayerProps with get, set
        abstract _keytipTree: obj with get, set
        abstract _keytipManager: obj with get, set
        abstract _classNames: obj with get, set
        abstract _currentSequence: obj with get, set
        abstract _newCurrentKeytipSequences: obj option with get, set
        abstract _delayedKeytipQueue: obj with get, set
        abstract _delayedQueueTimeout: obj with get, set
        abstract _keyHandled: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract getCurrentSequence: unit -> string
        abstract getKeytipTree: unit -> KeytipTree
        /// <summary>Processes an IKeytipTransitionKey entered by the user</summary>
        /// <param name="transitionKey">- IKeytipTransitionKey received by the layer to process</param>
        abstract processTransitionInput: transitionKey: IKeytipTransitionKey -> unit
        /// <summary>Processes inputs from the document listener and traverse the keytip tree</summary>
        /// <param name="key">- Key pressed by the user</param>
        abstract processInput: key: string -> unit
        /// <summary>Show the given keytips and hide all others</summary>
        /// <param name="ids">- Keytip IDs to show</param>
        abstract showKeytips: ids: ResizeArray<string> -> unit
        /// Enters keytip mode for this layer
        abstract _enterKeytipMode: unit -> unit
        /// Exits keytip mode for this layer
        abstract _exitKeytipMode: unit -> unit
        /// <summary>Sets the keytips state property</summary>
        /// <param name="keytipProps">- Keytips to set in this layer</param>
        abstract _setKeytips: ?keytipProps: obj -> unit
        /// <summary>Callback function to use for persisted keytips</summary>
        /// <param name="overflowButtonSequences">- The overflow button sequence to execute</param>
        /// <param name="keytipSequences">- The keytip that should become the 'currentKeytip' when it is registered</param>
        abstract _persistedKeytipExecute: overflowButtonSequences: obj * keytipSequences: obj -> unit
        abstract _getVisibleKeytips: keytips: obj -> unit
        abstract _onDismiss: obj with get, set
        abstract _onKeyDown: obj with get, set
        /// <summary>Gets the ModifierKeyCodes based on the keyboard event</summary>
        /// <param name="ev">- React.KeyboardEvent</param>
        abstract _getModifierKey: key: obj * ev: obj -> unit
        abstract _onKeyPress: obj with get, set
        abstract _onKeytipAdded: obj with get, set
        abstract _onKeytipUpdated: obj with get, set
        abstract _onKeytipRemoved: obj with get, set
        abstract _onPersistedKeytipAdded: obj with get, set
        abstract _onPersistedKeytipRemoved: obj with get, set
        abstract _onPersistedKeytipExecute: obj with get, set
        /// <summary>Trigger a keytip immediately and set it as the current keytip</summary>
        /// <param name="keytipProps">- Keytip to trigger immediately</param>
        abstract _triggerKeytipImmediately: keytipProps: obj -> unit
        abstract _addKeytipToQueue: keytipID: obj -> unit
        abstract _removeKeytipFromQueue: keytipID: obj -> unit
        /// <summary>Gets the DOM element for the specified keytip</summary>
        /// <param name="keytipId">- ID of the keytip to query for</param>
        abstract _getKeytipDOMElement: keytipId: obj -> unit
        /// <summary>Returns T/F if the keytipProps keySequences match the currentKeytip, and the currentKeytip is in an overflow well
        /// This will make 'keytipProps' the new currentKeytip</summary>
        /// <param name="keytipProps">- Keytip props to check</param>
        abstract _isCurrentKeytipAnAlias: keytipProps: obj -> unit
        /// Sets if we are in keytip mode.
        /// Note, this sets both the state for the layer as well as
        /// the value that the manager will expose externally.
        abstract _setInKeytipMode: obj with get, set

    /// A layer that holds all keytip items
    type [<AllowNullLiteral>] KeytipLayerBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IKeytipLayerProps * context: obj option -> KeytipLayerBase

module __components_KeytipLayer_KeytipLayer =
    type IKeytipLayerProps = __components_KeytipLayer_KeytipLayer_types.IKeytipLayerProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipLayer: (IKeytipLayerProps -> JSX.Element)

module __components_KeytipLayer_KeytipLayer_styles =
    type ILayerStyles = Layer.ILayerStyles
    type ILayerStyleProps = Layer.ILayerStyleProps
    type IKeytipLayerStyleProps = __components_KeytipLayer_KeytipLayer_types.IKeytipLayerStyleProps
    type IKeytipLayerStyles = __components_KeytipLayer_KeytipLayer_types.IKeytipLayerStyles

    type [<AllowNullLiteral>] IExports =
        abstract getLayerStyles: (ILayerStyleProps -> ILayerStyles)
        abstract getStyles: (IKeytipLayerStyleProps -> IKeytipLayerStyles)

module __components_KeytipLayer_KeytipLayer_types =
    type IStyleFunction = Utilities.IStyleFunction
    type IStyle = Styling.IStyle
    type IKeytipTransitionKey = __utilities_keytips_IKeytipTransitionKey.IKeytipTransitionKey

    type [<AllowNullLiteral>] IKeytipLayer =
        interface end

    type [<AllowNullLiteral>] IKeytipLayerProps =
        inherit React.Props<IKeytipLayer>
        /// Optional callback to access the KeytipLayer component. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IKeytipLayer option -> unit) option with get, set
        /// String to put inside the layer to be used for the aria-describedby for the component with the keytip
        /// Should be one of the starting sequences
        abstract content: string with get, set
        /// List of key sequences that will start keytips mode
        abstract keytipStartSequences: ResizeArray<IKeytipTransitionKey> option with get, set
        /// List of key sequences that execute the return functionality in keytips (going back to the previous level of keytips)
        abstract keytipReturnSequences: ResizeArray<IKeytipTransitionKey> option with get, set
        /// List of key sequences that will exit keytips mode
        abstract keytipExitSequences: ResizeArray<IKeytipTransitionKey> option with get, set
        /// Callback function triggered when keytip mode is exited
        abstract onExitKeytipMode: (unit -> unit) option with get, set
        /// Callback function triggered when keytip mode is entered
        abstract onEnterKeytipMode: (unit -> unit) option with get, set
        /// getStyles function for KeytipLayer
        abstract getStyles: IStyleFunction<IKeytipLayerStyleProps, IKeytipLayerStyles> option with get, set

    type [<AllowNullLiteral>] IKeytipLayerStyles =
        abstract innerContent: IStyle with get, set

    type [<AllowNullLiteral>] IKeytipLayerStyleProps =
        interface end

module __components_KeytipLayer_KeytipTree =
    type IKeytipProps = Keytip.IKeytipProps
    type IKeytipTreeNode = __components_KeytipLayer_IKeytipTreeNode.IKeytipTreeNode

    type [<AllowNullLiteral>] IExports =
        abstract KeytipTree: KeytipTreeStatic

    /// This class is responsible for handling the parent/child relationships between keytips
    type [<AllowNullLiteral>] KeytipTree =
        abstract currentKeytip: IKeytipTreeNode option with get, set
        abstract root: IKeytipTreeNode with get, set
        abstract nodeMap: obj with get, set
        /// <summary>Add a keytip node to this KeytipTree</summary>
        /// <param name="keytipProps">- Keytip to add to the Tree</param>
        /// <param name="uniqueID">- Unique ID for this keytip</param>
        /// <param name="persisted">- T/F if this keytip should be marked as persisted</param>
        abstract addNode: keytipProps: IKeytipProps * uniqueID: string * ?persisted: bool -> unit
        /// <summary>Updates a node in the tree</summary>
        /// <param name="keytipProps">- Keytip props to update</param>
        /// <param name="uniqueID">- Unique ID for this keytip</param>
        abstract updateNode: keytipProps: IKeytipProps * uniqueID: string -> unit
        /// Removes a node from the KeytipTree
        abstract removeNode: keytipProps: IKeytipProps * uniqueID: string -> unit
        /// <summary>Searches the currentKeytip's children to exactly match a sequence. Will not match disabled nodes but
        /// will match persisted nodes</summary>
        /// <param name="keySequence">- string to match</param>
        /// <param name="currentKeytip">- The keytip who's children will try to match</param>
        abstract getExactMatchedNode: keySequence: string * currentKeytip: IKeytipTreeNode -> IKeytipTreeNode option
        /// <summary>Searches the currentKeytip's children to find nodes that start with the given sequence. Will not match
        /// disabled nodes but will match persisted nodes</summary>
        /// <param name="keySequence">- string to partially match</param>
        /// <param name="currentKeytip">- The keytip who's children will try to partially match</param>
        abstract getPartiallyMatchedNodes: keySequence: string * currentKeytip: IKeytipTreeNode -> ResizeArray<IKeytipTreeNode>
        /// <summary>Get the non-persisted children of the give node
        /// If no node is given, will use the 'currentKeytip'</summary>
        /// <param name="node">- Node to get the children for</param>
        abstract getChildren: ?node: IKeytipTreeNode -> ResizeArray<string>
        /// <summary>Gets all nodes from their IDs</summary>
        /// <param name="ids">List of keytip IDs</param>
        abstract getNodes: ids: ResizeArray<string> -> ResizeArray<IKeytipTreeNode>
        /// <summary>Gets a single node from its ID</summary>
        /// <param name="id">- ID of the node to get</param>
        abstract getNode: id: string -> IKeytipTreeNode option
        /// <summary>Tests if the currentKeytip in this.keytipTree is the parent of 'keytipProps'</summary>
        /// <param name="keytipProps">- Keytip to test the parent for</param>
        abstract isCurrentKeytipParent: keytipProps: IKeytipProps -> bool
        abstract _getParentID: fullSequence: obj -> unit
        abstract _getFullSequence: keytipProps: obj -> unit
        abstract _getNodeSequence: node: obj -> unit
        abstract _createNode: id: obj * keySequences: obj * parentId: obj * children: obj * ?hasDynamicChildren: obj * ?overflowSetSequence: obj * ?hasMenu: obj * ?onExecute: obj * ?onReturn: obj * ?disabled: obj * ?persisted: obj -> unit

    /// This class is responsible for handling the parent/child relationships between keytips
    type [<AllowNullLiteral>] KeytipTreeStatic =
        /// KeytipTree constructor
        [<Emit "new $0($1...)">] abstract Create: unit -> KeytipTree

module __components_Label_Label_base =
    type BaseComponent = Utilities.BaseComponent
    type ILabelProps = __components_Label_Label_types.ILabelProps

    type [<AllowNullLiteral>] IExports =
        abstract Label: LabelStatic

    type [<AllowNullLiteral>] Label =
        inherit BaseComponent<ILabelProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LabelStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Label

module __components_Label_Label_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract LabelStatus: obj

module __components_Label_Label_classNames =
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getLabelClassNames: (ITheme -> string option -> bool -> bool -> ILabelClassNames)

    type [<AllowNullLiteral>] ILabelClassNames =
        abstract root: string with get, set

module __components_Label_Label_types =
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] ILabel =
        interface end

    type [<AllowNullLiteral>] ILabelProps =
        inherit React.LabelHTMLAttributes<HTMLLabelElement>
        /// Optional callback to access the ILabel interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ILabel option -> unit) option with get, set
        /// Whether the associated form field is required or not
        abstract required: bool option with get, set
        /// Renders the label as disabled.
        abstract disabled: bool option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set

module __components_Label_LabelPage =
    type IComponentDemoPageProps = __components_Label_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract LabelPage: LabelPageStatic

    type [<AllowNullLiteral>] LabelPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LabelPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LabelPage

module __components_Layer_Layer_base =
    type ILayerProps = __components_Layer_Layer_types.ILayerProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract LayerBase: LayerBaseStatic

    type [<AllowNullLiteral>] LayerBase =
        inherit BaseComponent<ILayerProps, obj>
        abstract defaultProps: ILayerProps with get, set
        abstract _rootElement: obj with get, set
        abstract _host: obj with get, set
        abstract _layerElement: obj with get, set
        abstract _hasMounted: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _removeLayerElement: unit -> unit
        abstract _getHost: unit -> unit

    type [<AllowNullLiteral>] LayerBaseStatic =
        /// Used for notifying applicable Layers that a host is available/unavailable and to re-evaluate Layers that
        /// care about the specific host.
        abstract notifyHostChanged: id: string -> unit
        /// Sets the default target selector to use when determining the host in which
        /// Layered content will be injected into. If not provided, an element will be
        /// created at the end of the document body.
        /// 
        /// Passing in a falsey value will clear the default target and reset back to
        /// using a created element at the end of document body.
        abstract setDefaultTarget: ?selector: string -> unit
        [<Emit "new $0($1...)">] abstract Create: props: ILayerProps -> LayerBase

module __components_Layer_Layer_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract LayerStatus: obj

module __components_Layer_Layer =
    type ILayerProps = __components_Layer_Layer_types.ILayerProps

    type [<AllowNullLiteral>] IExports =
        abstract Layer: (ILayerProps -> JSX.Element)

module __components_Layer_Layer_styles =
    type ILayerStyleProps = __components_Layer_Layer_types.ILayerStyleProps
    type ILayerStyles = __components_Layer_Layer_types.ILayerStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ILayerStyleProps -> ILayerStyles)

module __components_Layer_Layer_types =
    type LayerBase = __components_Layer_Layer_base.LayerBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] ILayer =
        interface end

    type [<AllowNullLiteral>] ILayerProps =
        inherit React.HTMLAttributes<U2<HTMLDivElement, LayerBase>>
        /// Optional callback to access the ILayer interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ILayer option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<ILayerStyleProps, ILayerStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Layer
        abstract className: string option with get, set
        /// Callback for when the layer is mounted. 
        abstract onLayerMounted: (unit -> unit) option with get, set
        /// Callback for when the layer is mounted.
        abstract onLayerDidMount: (unit -> unit) option with get, set
        /// Callback for when the layer is unmounted.
        abstract onLayerWillUnmount: (unit -> unit) option with get, set
        /// The optional id property provided on a LayerHost that this Layer should render within. The LayerHost does
        /// not need to be immediately available but once has been rendered, and if missing, we'll avoid trying
        /// to render the Layer content until the host is available. If an id is not provided, we will render the Layer
        /// content in a fixed position element rendered at the end of the document.
        abstract hostId: string option with get, set

    type [<AllowNullLiteral>] ILayerStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// Check if Host
        abstract isNotHost: bool option with get, set

    type [<AllowNullLiteral>] ILayerStyles =
        /// Style for the root element when fixed.
        abstract root: IStyle option with get, set
        /// Style for the Fabric component.
        abstract content: IStyle option with get, set

module __components_Layer_LayerHost =
    type BaseComponent = Utilities.BaseComponent
    type ILayerHostProps = __components_Layer_LayerHost_types.ILayerHostProps

    type [<AllowNullLiteral>] IExports =
        abstract LayerHost: LayerHostStatic

    type [<AllowNullLiteral>] LayerHost =
        inherit BaseComponent<ILayerHostProps, obj>
        abstract shouldComponentUpdate: unit -> bool
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LayerHostStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LayerHost

module __components_Layer_LayerHost_types =

    type [<AllowNullLiteral>] ILayerHost =
        interface end

    type [<AllowNullLiteral>] ILayerHostProps =
        inherit React.HTMLAttributes<HTMLElement>
        /// Optional callback to access the ILayerHost interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ILayerHost option -> unit) option with get, set
        /// Defines the id for the layer host that Layers can target (using the hostId property.)
        abstract id: string option with get, set

module __components_Layer_LayerPage =
    type IComponentDemoPageProps = __components_Layer_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract LayerPage: LayerPageStatic

    type [<AllowNullLiteral>] LayerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LayerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LayerPage

module __components_Link_Link_base =
    type BaseComponent = Utilities.BaseComponent
    type ILink = __components_Link_Link_types.ILink
    type ILinkProps = __components_Link_Link_types.ILinkProps

    type [<AllowNullLiteral>] IExports =
        abstract LinkBase: LinkBaseStatic

    type [<AllowNullLiteral>] LinkBase =
        inherit BaseComponent<ILinkProps, obj option>
        inherit ILink
        abstract _link: obj with get, set
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _onClick: obj with get, set

    type [<AllowNullLiteral>] LinkBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LinkBase

module __components_Link_Link_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract LinkStatus: obj

module __components_Link_Link =
    type ILinkProps = __components_Link_Link_types.ILinkProps

    type [<AllowNullLiteral>] IExports =
        abstract Link: (ILinkProps -> JSX.Element)

module __components_Link_Link_styles =
    type ILinkStyleProps = __components_Link_Link_types.ILinkStyleProps
    type ILinkStyles = __components_Link_Link_types.ILinkStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ILinkStyleProps -> ILinkStyles)

module __components_Link_Link_types =
    type LinkBase = __components_Link_Link_base.LinkBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] ILink =
        /// Sets focus to the link. 
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] ILinkProps =
        inherit React.AllHTMLAttributes<U4<HTMLAnchorElement, HTMLButtonElement, HTMLElement, LinkBase>>
        /// Optional callback to access the ILink interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ILink option -> unit) option with get, set
        /// Whether the link is disabled
        abstract disabled: bool option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<ILinkStyleProps, ILinkStyles> option with get, set
        /// Theme (provided through customization.)
        abstract theme: ITheme option with get, set
        /// Optional keytip for this Link
        abstract keytipProps: IKeytipProps option with get, set

    type [<AllowNullLiteral>] ILinkStyleProps =
        abstract className: string option with get, set
        abstract isButton: bool option with get, set
        abstract isDisabled: bool option with get, set
        abstract theme: ITheme with get, set

    type [<AllowNullLiteral>] ILinkStyles =
        abstract root: IStyle with get, set

module __components_Link_LinkPage =
    type IComponentDemoPageProps = __components_Link_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract LinkPage: LinkPageStatic

    type [<AllowNullLiteral>] LinkPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LinkPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LinkPage

module __components_List_List_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ListStatus: obj

module __components_List_List =
    type BaseComponent = Utilities.BaseComponent
    type IList = __components_List_List_types.IList
    type IListProps = __components_List_List_types.IListProps
    type IPage = __components_List_List_types.IPage
    type ScrollToMode = __components_List_List_types.ScrollToMode

    type [<AllowNullLiteral>] IExports =
        abstract List: ListStatic

    type [<AllowNullLiteral>] IListState =
        abstract pages: ResizeArray<IPage> option with get, set
        /// The last versionstamp for  
        abstract measureVersion: float option with get, set
        abstract isScrolling: bool option with get, set

    /// The List renders virtualized pages of items. Each page's item count is determined by the getItemCountForPage callback if
    /// provided by the caller, or 10 as default. Each page's height is determined by the getPageHeight callback if provided by
    /// the caller, or by cached measurements if available, or by a running average, or a default fallback.
    /// 
    /// The algorithm for rendering pages works like this:
    /// 
    /// 1. Predict visible pages based on "current measure data" (page heights, surface position, visible window)
    /// 2. If changes are necessary, apply changes (add/remove pages)
    /// 3. For pages that are added, measure the page heights if we need to using getBoundingClientRect
    /// 4. If measurements don't match predictions, update measure data and goto step 1 asynchronously
    /// 
    /// Measuring too frequently can pull performance down significantly. To compensate, we cache measured values so that
    /// we can avoid re-measuring during operations that should not alter heights, like scrolling.
    /// 
    /// To optimize glass rendering performance, onShouldVirtualize can be set. When onShouldVirtualize return false,
    /// List will run in fast mode (not virtualized) to render all items without any measurements to improve page load time. And we
    /// start doing measurements and rendering in virtualized mode when items grows larger than this threshold.
    /// 
    /// However, certain operations can make measure data stale. For example, resizing the list, or passing in new props,
    /// or forcing an update change cause pages to shrink/grow. When these operations occur, we increment a measureVersion
    /// number, which we associate with cached measurements and use to determine if a remeasure should occur.
    type [<AllowNullLiteral>] List =
        inherit BaseComponent<IListProps, IListState>
        inherit IList
        abstract defaultProps: obj with get, set
        abstract refs: obj with get, set
        abstract _root: obj with get, set
        abstract _surface: obj with get, set
        abstract _estimatedPageHeight: obj with get, set
        abstract _totalEstimates: obj with get, set
        abstract _cachedPageHeights: obj with get, set
        abstract _focusedIndex: obj with get, set
        abstract _scrollElement: obj with get, set
        abstract _hasCompletedFirstRender: obj with get, set
        abstract _surfaceRect: obj with get, set
        abstract _requiredRect: obj with get, set
        abstract _allowedRect: obj with get, set
        abstract _materializedRect: obj with get, set
        abstract _requiredWindowsAhead: obj with get, set
        abstract _requiredWindowsBehind: obj with get, set
        abstract _measureVersion: obj with get, set
        abstract _scrollHeight: obj with get, set
        abstract _scrollTop: obj with get, set
        abstract _pageCache: obj with get, set
        /// <summary>Scroll to the given index. By default will bring the page the specified item is on into the view. If a callback
        /// to measure the height of an individual item is specified, will only scroll to bring the specific item into view.
        /// 
        /// Note: with items of variable height and no passed in `getPageHeight` method, the list might jump after scrolling
        /// when windows before/ahead are being rendered, and the estimated height is replaced using actual elements.</summary>
        /// <param name="index">Index of item to scroll to</param>
        /// <param name="measureItem">Optional callback to measure the height of an individual item</param>
        /// <param name="scrollToMode">Optional defines where in the window the item should be positioned to when scrolling</param>
        abstract scrollToIndex: index: float * ?measureItem: (float -> float) * ?scrollToMode: ScrollToMode -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: IListProps -> unit
        abstract shouldComponentUpdate: newProps: IListProps * newState: IListState -> bool
        abstract forceUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _shouldVirtualize: ?props: obj -> unit
        /// when props.items change or forceUpdate called, throw away cached pages
        abstract _invalidatePageCache: unit -> unit
        abstract _renderPage: page: obj -> unit
        /// Generate the style object for the page. 
        abstract _getPageStyle: page: obj -> unit
        abstract _onRenderPage: obj with get, set
        /// Track the last item index focused so that we ensure we keep it rendered. 
        abstract _onFocus: ev: obj -> unit
        /// Called synchronously to reset the required render range to 0 on scrolling. After async scroll has executed,
        /// we will call onAsyncIdle which will reset it back to it's correct value.
        abstract _onScroll: unit -> unit
        abstract _resetRequiredWindows: unit -> unit
        /// Debounced method to asynchronously update the visible region on a scroll event.
        abstract _onAsyncScroll: unit -> unit
        /// This is an async debounced method that will try and increment the windows we render. If we can increment
        /// either, we increase the amount we render and re-evaluate.
        abstract _onAsyncIdle: unit -> unit
        /// Function to call when the list is done scrolling.
        /// This function is debounced.
        abstract _onScrollingDone: unit -> unit
        abstract _onAsyncResize: unit -> unit
        abstract _updatePages: ?props: obj -> unit
        /// <summary>Notify consumers that the rendered pages have changed</summary>
        /// <param name="oldPages">The old pages</param>
        /// <param name="newPages">The new pages</param>
        /// <param name="props">The props to use</param>
        abstract _notifyPageChanges: oldPages: obj * newPages: obj * ?props: obj -> unit
        abstract _updatePageMeasurements: pages: obj -> unit
        /// Given a page, measure its dimensions, update cache.
        abstract _measurePage: page: obj -> unit
        /// Called when a page has been added to the DOM. 
        abstract _onPageAdded: page: obj -> unit
        /// Called when a page has been removed from the DOM. 
        abstract _onPageRemoved: page: obj -> unit
        /// Build up the pages that should be rendered. 
        abstract _buildPages: props: obj -> unit
        abstract _getPageSpecification: itemIndex: obj * visibleRect: obj -> unit
        /// Get the pixel height of a give page. Will use the props getPageHeight first, and if not provided, fallback to
        /// cached height, or estimated page height, or default page height.
        abstract _getPageHeight: itemIndex: obj * itemsPerPage: obj * visibleRect: obj -> unit
        abstract _getItemCountForPage: itemIndex: obj * visibileRect: obj -> unit
        abstract _createPage: pageKey: obj * items: obj * ?startIndex: obj * ?count: obj * ?style: obj * ?data: obj -> unit
        abstract _getRenderCount: ?props: obj -> unit
        /// Calculate the visible rect within the list where top: 0 and left: 0 is the top/left of the list. 
        abstract _updateRenderRects: ?props: obj * ?forceUpdate: obj -> unit

    /// The List renders virtualized pages of items. Each page's item count is determined by the getItemCountForPage callback if
    /// provided by the caller, or 10 as default. Each page's height is determined by the getPageHeight callback if provided by
    /// the caller, or by cached measurements if available, or by a running average, or a default fallback.
    /// 
    /// The algorithm for rendering pages works like this:
    /// 
    /// 1. Predict visible pages based on "current measure data" (page heights, surface position, visible window)
    /// 2. If changes are necessary, apply changes (add/remove pages)
    /// 3. For pages that are added, measure the page heights if we need to using getBoundingClientRect
    /// 4. If measurements don't match predictions, update measure data and goto step 1 asynchronously
    /// 
    /// Measuring too frequently can pull performance down significantly. To compensate, we cache measured values so that
    /// we can avoid re-measuring during operations that should not alter heights, like scrolling.
    /// 
    /// To optimize glass rendering performance, onShouldVirtualize can be set. When onShouldVirtualize return false,
    /// List will run in fast mode (not virtualized) to render all items without any measurements to improve page load time. And we
    /// start doing measurements and rendering in virtualized mode when items grows larger than this threshold.
    /// 
    /// However, certain operations can make measure data stale. For example, resizing the list, or passing in new props,
    /// or forcing an update change cause pages to shrink/grow. When these operations occur, we increment a measureVersion
    /// number, which we associate with cached measurements and use to determine if a remeasure should occur.
    type [<AllowNullLiteral>] ListStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IListProps -> List

module __components_List_List_types =
    type IRectangle = Utilities.IRectangle
    type IRenderFunction = Utilities.IRenderFunction
    type List = __components_List_List.List

    type [<RequireQualifiedAccess>] ScrollToMode =
        | Auto = 0
        | Top = 1
        | Bottom = 2
        | Center = 3

    type [<AllowNullLiteral>] IList =
        /// Force the component to update.
        abstract forceUpdate: (unit -> unit) with get, set
        /// Scroll to the given index. By default will bring the page the specified item is on into the view. If a callback
        /// to measure the height of an individual item is specified, will only scroll to bring the specific item into view.
        /// 
        /// Note: with items of variable height and no passed in `getPageHeight` method, the list might jump after scrolling
        /// when windows before/ahead are being rendered, and the estimated height is replaced using actual elements.
        abstract scrollToIndex: (float -> (float -> float) -> ScrollToMode -> unit) with get, set

    type [<AllowNullLiteral>] IListProps =
        inherit React.HTMLAttributes<U2<List, HTMLDivElement>>
        /// Optional callback to access the IList interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IList option -> unit) option with get, set
        /// Optional classname to append to root list. 
        abstract className: string option with get, set
        /// Items to render. 
        abstract items: ResizeArray<obj option> option with get, set
        /// Method to call when trying to render an item.
        abstract onRenderCell: (obj option -> float -> bool -> React.ReactNode) option with get, set
        /// Optional callback for monitoring when a page is added. 
        abstract onPageAdded: (IPage -> unit) option with get, set
        /// Optional callback for monitoring when a page is removed. 
        abstract onPageRemoved: (IPage -> unit) option with get, set
        /// Optional callback to get the item key, to be used on render. 
        abstract getKey: (obj option -> float -> string) option with get, set
        /// Called by the list to get the specification for a page.
        /// Use this method to provide an allocation of items per page,
        /// as well as an estimated rendered height for the page.
        /// The list will use this to optimize virtualization.
        abstract getPageSpecification: (float -> IRectangle -> IPageSpecification) option with get, set
        /// Method called by the list to get how many items to render per page from specified index.
        /// In general, use `getPageSpecification` instead.
        abstract getItemCountForPage: (float -> IRectangle -> float) option with get, set
        /// Method called by the list to get the pixel height for a given page. By default, we measure the first
        /// page's height and default all other pages to that height when calculating the surface space. It is
        /// ideal to be able to adequately predict page heights in order to keep the surface space from jumping
        /// in pixels, which has been seen to cause browser performance issues.
        /// In general, use `getPageSpecification` instead.
        abstract getPageHeight: (float -> IRectangle -> float) option with get, set
        /// Method called by the list to derive the page style object. For spacer pages, the list will derive
        /// the height and passed in heights will be ignored.
        abstract getPageStyle: (IPage -> obj option) option with get, set
        /// In addition to the visible window, how many windowHeights should we render ahead.
        abstract renderedWindowsAhead: float option with get, set
        /// In addition to the visible window, how many windowHeights should we render behind.
        abstract renderedWindowsBehind: float option with get, set
        /// Index in items array to start rendering from. Defaults to 0. 
        abstract startIndex: float option with get, set
        /// Number of items to render. Defaults to items.length. 
        abstract renderCount: float option with get, set
        /// Boolean value to enable render page caching. This is an experimental performance optimization
        /// that is off by default.
        abstract usePageCache: bool option with get, set
        /// Optional callback to determine whether the list should be rendered in full, or virtualized.
        /// Virtualization will add and remove pages of items as the user scrolls them into the visible range.
        /// This benefits larger list scenarios by reducing the DOM on the screen, but can negatively affect performance for smaller lists.
        /// The default implementation will virtualize when this callback is not provided.
        abstract onShouldVirtualize: (IListProps -> bool) option with get, set
        /// The role to assign to the list root element.
        /// Use this to override the default assignment of 'list' to the root and 'listitem' to the cells.
        abstract role: string option with get, set
        /// Called when the List will render a page.
        /// Override this to control how cells are rendered within a page.
        abstract onRenderPage: (IPageProps -> IRenderFunction<IPageProps> -> React.ReactNode) option with get, set

    type [<AllowNullLiteral>] IPage =
        abstract key: string with get, set
        abstract items: ResizeArray<obj option> option with get, set
        abstract startIndex: float with get, set
        abstract itemCount: float with get, set
        abstract style: obj option with get, set
        abstract top: float with get, set
        abstract height: float with get, set
        abstract data: obj option with get, set

    type [<AllowNullLiteral>] IPageProps =
        inherit React.HTMLAttributes<HTMLDivElement>
        inherit React.Props<HTMLDivElement>
        /// The role being assigned to the rendered page element by the list.
        abstract role: string option with get, set
        /// The allocation data for the page.
        abstract page: IPage with get, set

    type [<AllowNullLiteral>] IPageSpecification =
        /// The number of items to allocate to the page.
        abstract itemCount: float option with get, set
        /// The estimated pixel height of the page.
        abstract height: float option with get, set
        /// Data to pass through to the page when rendering.
        abstract data: obj option with get, set
        /// The key to use when creating the page.
        abstract key: string option with get, set

module __components_List_ListPage =
    type IComponentDemoPageProps = __components_List_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ListPage: ListPageStatic

    type [<AllowNullLiteral>] ListPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ListPageStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IComponentDemoPageProps -> ListPage

module __components_MarqueeSelection_MarqueeSelection_base =
    type BaseComponent = Utilities.BaseComponent
    type IPoint = Utilities.IPoint
    type IRectangle = Utilities.IRectangle
    type IMarqueeSelectionProps = __components_MarqueeSelection_MarqueeSelection_types.IMarqueeSelectionProps

    type [<AllowNullLiteral>] IExports =
        abstract MarqueeSelectionBase: MarqueeSelectionBaseStatic

    type [<AllowNullLiteral>] IMarqueeSelectionState =
        abstract dragOrigin: IPoint option with get, set
        abstract dragRect: IRectangle option with get, set

    /// MarqueeSelection component abstracts managing a draggable rectangle which sets items selected/not selected.
    /// Elements which have data-selectable-index attributes are queried and measured once to determine if they
    /// fall within the bounds of the rectangle. The measure is memoized during the drag as a performance optimization
    /// so if the items change sizes while dragging, that could cause incorrect results.
    type [<AllowNullLiteral>] MarqueeSelectionBase =
        inherit BaseComponent<IMarqueeSelectionProps, IMarqueeSelectionState>
        abstract defaultProps: obj with get, set
        abstract _root: obj with get, set
        abstract _dragOrigin: obj with get, set
        abstract _rootRect: obj with get, set
        abstract _lastMouseEvent: obj with get, set
        abstract _autoScroll: obj with get, set
        abstract _selectedIndicies: obj with get, set
        abstract _preservedIndicies: obj with get, set
        abstract _itemRectCache: obj with get, set
        abstract _scrollableParent: obj with get, set
        abstract _scrollableSurface: obj with get, set
        abstract _scrollTop: obj with get, set
        abstract _isTouch: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        /// Determine if the mouse event occured on a scrollbar of the target element. 
        abstract _isMouseEventOnScrollbar: ev: obj -> unit
        abstract _onMouseDown: obj with get, set
        abstract _onTouchStart: obj with get, set
        abstract _onPointerDown: obj with get, set
        abstract _getRootRect: unit -> unit
        abstract _onAsyncMouseMove: ev: obj -> unit
        abstract _onMouseMove: ev: obj -> unit
        abstract _onMouseUp: ev: obj -> unit
        abstract _isPointInRectangle: rectangle: obj * point: obj -> unit
        /// We do not want to start the marquee if we're trying to marquee
        /// from within an existing marquee selection.
        abstract _isDragStartInSelection: ev: obj -> unit
        abstract _isInSelectionToggle: ev: obj -> unit
        abstract _evaluateSelection: dragRect: obj * rootRect: obj -> unit

    /// MarqueeSelection component abstracts managing a draggable rectangle which sets items selected/not selected.
    /// Elements which have data-selectable-index attributes are queried and measured once to determine if they
    /// fall within the bounds of the rectangle. The measure is memoized during the drag as a performance optimization
    /// so if the items change sizes while dragging, that could cause incorrect results.
    type [<AllowNullLiteral>] MarqueeSelectionBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IMarqueeSelectionProps -> MarqueeSelectionBase

module __components_MarqueeSelection_MarqueeSelection =
    type IMarqueeSelectionProps = __components_MarqueeSelection_MarqueeSelection_types.IMarqueeSelectionProps

    type [<AllowNullLiteral>] IExports =
        abstract MarqueeSelection: (IMarqueeSelectionProps -> JSX.Element)

module __components_MarqueeSelection_MarqueeSelection_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract dragMask: obj
        abstract box: obj
        abstract boxFill: obj

module __components_MarqueeSelection_MarqueeSelection_styles =
    type IMarqueeSelectionStyleProps = __components_MarqueeSelection_MarqueeSelection_types.IMarqueeSelectionStyleProps
    type IMarqueeSelectionStyles = __components_MarqueeSelection_MarqueeSelection_types.IMarqueeSelectionStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IMarqueeSelectionStyleProps -> IMarqueeSelectionStyles)

module __components_MarqueeSelection_MarqueeSelection_types =
    type ISelection = __utilities_selection_interfaces.ISelection
    type ITheme = Styling.ITheme
    type IStyle = Styling.IStyle
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IMarqueeSelection =
        interface end

    type [<AllowNullLiteral>] IMarqueeSelectionProps =
        inherit React.HTMLAttributes<HTMLDivElement>
        /// Optional callback to access the IMarqueeSelection interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IMarqueeSelection option -> unit) option with get, set
        /// The selection object to interact with when updating selection changes.
        abstract selection: ISelection with get, set
        /// Optional props to mix into the root DIV element.
        abstract rootProps: React.HTMLAttributes<HTMLDivElement> option with get, set
        /// Optional callback that is called, when the mouse down event occurs, in order to determine
        /// if we should start a marquee selection. If true is returned, we will cancel the mousedown
        /// event to prevent upstream mousedown handlers from executing.
        abstract onShouldStartSelection: (MouseEvent -> bool) option with get, set
        /// Optional flag to control the enabled state of marquee selection. This allows you to render
        /// it and have events all ready to go, but conditionally disable it. That way transitioning
        /// between enabled/disabled generate no difference in the DOM.
        abstract isEnabled: bool option with get, set
        /// Optional flag to restrict the drag rect to the root element, instead of allowing the drag
        /// rect to start outside of the root element boundaries.
        abstract isDraggingConstrainedToRoot: bool option with get, set
        /// Additional CSS class(es) to apply to the MarqueeSelection.
        abstract className: string option with get, set
        /// Theme (provided through customization.)
        abstract theme: ITheme option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<IMarqueeSelectionStyleProps, IMarqueeSelectionStyles> option with get, set

    type [<AllowNullLiteral>] IMarqueeSelectionStyleProps =
        abstract theme: ITheme with get, set
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IMarqueeSelectionStyles =
        abstract root: IStyle option with get, set
        abstract dragMask: IStyle option with get, set
        abstract box: IStyle option with get, set
        abstract boxFill: IStyle option with get, set

module __components_MarqueeSelection_MarqueeSelectionPage =
    type IComponentDemoPageProps = __components_MarqueeSelection_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract MarqueeSelectionPage: MarqueeSelectionPageStatic

    type [<AllowNullLiteral>] MarqueeSelectionPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] MarqueeSelectionPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MarqueeSelectionPage

module __components_MessageBar_MessageBar_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract MessageBarStatus: obj

module __components_MessageBar_MessageBar =
    type BaseComponent = Utilities.BaseComponent
    type IMessageBarProps = __components_MessageBar_MessageBar_types.IMessageBarProps

    type [<AllowNullLiteral>] IExports =
        abstract MessageBar: MessageBarStatic

    type [<AllowNullLiteral>] IMessageBarState =
        abstract labelId: string option with get, set
        abstract showContent: bool option with get, set
        abstract expandSingleLine: bool option with get, set

    type [<AllowNullLiteral>] MessageBar =
        inherit BaseComponent<IMessageBarProps, IMessageBarState>
        abstract defaultProps: IMessageBarProps with get, set
        abstract ICON_MAP: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getActionsDiv: unit -> unit
        abstract _getClassName: unit -> unit
        abstract _getDismissDiv: unit -> unit
        abstract _getDismissSingleLine: unit -> unit
        abstract _getExpandSingleLine: unit -> unit
        abstract _getIconSpan: unit -> unit
        abstract _renderMultiLine: unit -> unit
        abstract _renderSingleLine: unit -> unit
        abstract _renderInnerText: unit -> unit
        abstract _getAnnouncementPriority: unit -> unit
        abstract _onClick: obj with get, set

    type [<AllowNullLiteral>] MessageBarStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IMessageBarProps -> MessageBar

module __components_MessageBar_MessageBar_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract icon: obj
        abstract text: obj
        abstract noDismissButton: obj
        abstract innerText: obj
        abstract rootIsWarning: obj
        abstract rootIsSevereWarning: obj
        abstract rootIsError: obj
        abstract rootIsBlocked: obj
        abstract rootIsSuccess: obj
        abstract content: obj
        abstract actions: obj
        abstract actionsSingleLine: obj
        abstract dismissal: obj
        abstract expand: obj
        abstract dismissSingleLine: obj
        abstract expandSingleLine: obj
        abstract multiLine: obj
        abstract multiLineWithActions: obj
        abstract singleLine: obj
        abstract expandingSingleLine: obj

module __components_MessageBar_MessageBar_types =
    type BaseButton = Button.BaseButton
    type Button = Button.Button

    type [<AllowNullLiteral>] IMessageBar =
        interface end

    type [<AllowNullLiteral>] IMessageBarProps =
        inherit React.HTMLAttributes<HTMLElement>
        /// Optional callback to access the IMessageBar interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IMessageBar option -> unit) option with get, set
        /// The type of MessageBar to render.
        abstract messageBarType: MessageBarType option with get, set
        /// The actions you want to show on the other side.
        abstract actions: JSX.Element option with get, set
        /// A description of the message bar for the benefit of screen readers.
        abstract ariaLabel: string option with get, set
        /// Whether the message bar has a dismiss button and its callback.
        /// If null, we don't show a dismiss button.
        abstract onDismiss: (React.MouseEvent<U5<HTMLButtonElement, BaseButton, HTMLAnchorElement, HTMLDivElement, Button>> -> obj option) option with get, set
        /// Determines if the message bar is multi lined.
        /// If false, and the text overflows over buttons or to another line, it is clipped.
        abstract isMultiline: bool option with get, set
        /// Aria label on dismiss button if onDismiss is defined.
        abstract dismissButtonAriaLabel: string option with get, set
        /// Determines if the message bar text is truncated.
        /// If true, a button will render to toggle between a single line view and multiline view.
        /// This prop is for single line message bars with no buttons only in a limited space scenario.
        abstract truncated: bool option with get, set
        /// Aria label on overflow button if truncated is defined.
        abstract overflowButtonAriaLabel: string option with get, set

    type [<RequireQualifiedAccess>] MessageBarType =
        | Info = 0
        | Error = 1
        | Blocked = 2
        | SevereWarning = 3
        | Success = 4
        | Warning = 5
        | Remove = 90000

module __components_MessageBar_MessageBarPage =
    type IComponentDemoPageProps = __components_MessageBar_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract MessageBarPage: MessageBarPageStatic

    type [<AllowNullLiteral>] MessageBarPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] MessageBarPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarPage

module __components_Modal_Modal_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ModalStatus: obj

module __components_Modal_Modal =
    type BaseComponent = Utilities.BaseComponent
    type IModalProps = __components_Modal_Modal_types.IModalProps
    type IModal = __components_Modal_Modal_types.IModal

    type [<AllowNullLiteral>] IExports =
        abstract Modal: ModalStatic

    type [<AllowNullLiteral>] IDialogState =
        abstract isOpen: bool option with get, set
        abstract isVisible: bool option with get, set
        abstract isVisibleClose: bool option with get, set
        abstract id: string option with get, set

    type [<AllowNullLiteral>] Modal =
        inherit BaseComponent<IModalProps, IDialogState>
        inherit IModal
        abstract defaultProps: IModalProps with get, set
        abstract _onModalCloseTimer: obj with get, set
        abstract _focusTrapZone: obj with get, set
        abstract componentWillReceiveProps: newProps: IModalProps -> unit
        abstract componentDidUpdate: prevProps: IModalProps * prevState: IDialogState -> unit
        abstract render: unit -> JSX.Element option
        abstract focus: unit -> unit
        abstract _onModalClose: unit -> unit

    type [<AllowNullLiteral>] ModalStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IModalProps -> Modal

module __components_Modal_Modal_scss =

    type [<AllowNullLiteral>] IExports =
        abstract duration: obj
        abstract root: obj
        abstract rootIsVisible: obj
        abstract main: obj

module __components_Modal_Modal_types =
    type Modal = __components_Modal_Modal.Modal
    type IWithResponsiveModeState = __utilities_decorators_withResponsiveMode.IWithResponsiveModeState
    type IAccessiblePopupProps = __common_IAccessiblePopupProps.IAccessiblePopupProps

    type [<AllowNullLiteral>] IModal =
        /// Sets focus on the first focusable, or configured, child in focus trap zone
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IModalProps =
        inherit React.Props<Modal>
        inherit IWithResponsiveModeState
        inherit IAccessiblePopupProps
        /// Optional callback to access the IDialog interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IModal option -> unit) option with get, set
        /// Whether the dialog is displayed.
        abstract isOpen: bool option with get, set
        /// Whether the overlay is dark themed.
        abstract isDarkOverlay: bool option with get, set
        /// A callback function for when the Modal is dismissed light dismiss, before the animation completes.
        abstract onDismiss: (React.MouseEvent<HTMLButtonElement> -> obj option) option with get, set
        /// A callback function which is called after the Modal is dismissed and the animation is complete.
        abstract onDismissed: (unit -> obj option) option with get, set
        /// Whether the dialog can be light dismissed by clicking outside the dialog (on the overlay).
        abstract isBlocking: bool option with get, set
        /// Optional class name to be added to the root class
        abstract className: string option with get, set
        /// Optional override for container class
        abstract containerClassName: string option with get, set
        /// A callback function for when the Modal content is mounted on the overlay layer
        abstract onLayerDidMount: (unit -> unit) option with get, set
        /// ARIA id for the title of the Modal, if any
        abstract titleAriaId: string option with get, set
        /// ARIA id for the subtitle of the Modal, if any
        abstract subtitleAriaId: string option with get, set

module __components_Modal_ModalPage =
    type IComponentDemoPageProps = __components_Modal_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ModalPage: ModalPageStatic

    type [<AllowNullLiteral>] ModalPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ModalPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ModalPage

module __components_Nav_Nav_base =
    type BaseComponent = Utilities.BaseComponent
    type INav = __components_Nav_Nav_types.INav
    type INavProps = __components_Nav_Nav_types.INavProps

    type [<AllowNullLiteral>] IExports =
        abstract isRelativeUrl: url: string -> bool
        abstract NavBase: NavBaseStatic

    type [<AllowNullLiteral>] INavState =
        abstract isGroupCollapsed: obj option with get, set
        abstract isLinkExpandStateChanged: bool option with get, set
        abstract selectedKey: string option with get, set

    type [<AllowNullLiteral>] NavBase =
        inherit BaseComponent<INavProps, INavState>
        inherit INav
        abstract defaultProps: INavProps with get, set
        abstract componentWillReceiveProps: newProps: INavProps -> unit
        abstract render: unit -> JSX.Element option
        abstract selectedKey: string option
        abstract _onRenderLink: obj with get, set
        abstract _renderNavLink: link: obj * linkIndex: obj * nestingLevel: obj -> unit
        abstract _renderCompositeLink: link: obj * linkIndex: obj * nestingLevel: obj -> unit
        abstract _renderLink: link: obj * linkIndex: obj * nestingLevel: obj -> unit
        abstract _renderLinks: links: obj * nestingLevel: obj -> unit
        abstract _renderGroup: obj with get, set
        abstract _onGroupHeaderClicked: group: obj * ev: obj -> unit
        abstract _onLinkExpandClicked: link: obj * ev: obj -> unit
        abstract _onNavAnchorLinkClicked: link: obj * ev: obj -> unit
        abstract _onNavButtonLinkClicked: link: obj * ev: obj -> unit
        abstract _isLinkSelected: link: obj -> unit

    type [<AllowNullLiteral>] NavBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: INavProps -> NavBase

module __components_Nav_Nav_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract NavStatus: obj

module __components_Nav_Nav =
    type INavProps = __components_Nav_Nav_types.INavProps

    type [<AllowNullLiteral>] IExports =
        abstract Nav: (INavProps -> JSX.Element)

module __components_Nav_Nav_styles =
    type INavStyleProps = __components_Nav_Nav_types.INavStyleProps
    type INavStyles = __components_Nav_Nav_types.INavStyles
    type IButtonStyles = Button.IButtonStyles

    type [<AllowNullLiteral>] IExports =
        abstract buttonStyles: IButtonStyles
        abstract getStyles: (INavStyleProps -> INavStyles)

module __components_Nav_Nav_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IRenderFunction = Utilities.IRenderFunction
    type IStyleFunction = Utilities.IStyleFunction
    type IIconProps = __components_Icon_Icon_types.IIconProps

    type [<AllowNullLiteral>] INav =
        /// The meta 'key' property of the currently selected NavItem of the Nav. Can return
        /// undefined if the currently selected nav item has no populated key property. Be aware
        /// that in order for Nav to properly understand which key is selected all NavItems in
        /// all groups of the Nav must have populated key properties.
        abstract selectedKey: string option with get, set

    type [<AllowNullLiteral>] INavProps =
        /// Optional callback to access the INav interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (INav option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<INavStyleProps, INavStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Nav
        abstract className: string option with get, set
        /// A collection of link groups to display in the navigation bar
        abstract groups: ResizeArray<INavLinkGroup> option with get, set
        /// Used to customize how content inside the link tag is rendered
        abstract onRenderLink: IRenderFunction<INavLink> option with get, set
        /// Function callback invoked when a link in the navigation is clicked
        abstract onLinkClick: (React.MouseEvent<HTMLElement> -> INavLink -> unit) option with get, set
        /// Function callback invoked when the chevron on a link is clicked
        abstract onLinkExpandClick: (React.MouseEvent<HTMLElement> -> INavLink -> unit) option with get, set
        /// Indicates whether the navigation component renders on top of other content in the UI
        abstract isOnTop: bool option with get, set
        /// (Optional) The key of the nav item initially selected.
        abstract initialSelectedKey: string option with get, set
        /// (Optional) The key of the nav item selected by caller.
        abstract selectedKey: string option with get, set
        /// (Optional) The nav container aria label.
        abstract ariaLabel: string option with get, set
        /// (Optional) The nav container aria label.
        abstract expandButtonAriaLabel: string option with get, set
        /// Deprecated at v0.68.1 and will be removed at >= V1.0.0.
        abstract expandedStateText: string option with get, set
        /// Deprecated at v0.68.1 and will be removed at >= V1.0.0.
        abstract collapsedStateText: string option with get, set

    type [<AllowNullLiteral>] INavLinkGroup =
        /// Text to render as the header of a group
        abstract name: string option with get, set
        /// Links to render within this group
        abstract links: ResizeArray<INavLink> with get, set
        /// The name to use for functional automation tests
        abstract automationId: string option with get, set
        /// If true, the group should render collapsed by default
        abstract collapseByDefault: bool option with get, set
        /// Callback invoked when a group header is clicked
        abstract onHeaderClick: (React.MouseEvent<HTMLElement> -> bool -> unit) option with get, set

    type [<AllowNullLiteral>] INavLink =
        /// Text to render for this link
        abstract name: string with get, set
        /// URL to navigate to for this link
        abstract url: string with get, set
        /// Meta info for the link server, if negative, client side added node.
        abstract key: string option with get, set
        /// Child links to this link, if any
        abstract links: ResizeArray<INavLink> option with get, set
        /// Callback invoked when this link is clicked. Providing this callback will cause the link
        /// to render as a button (rather than an anchor) unless forceAnchor is set to true.
        abstract onClick: (React.MouseEvent<HTMLElement> -> INavLink -> unit) option with get, set
        /// button icon name if applied
        abstract icon: string option with get, set
        /// Deprecated. Use iconProps.className instead.
        abstract iconClassName: string option with get, set
        /// button icon props if applied
        abstract iconProps: IIconProps option with get, set
        /// Deprecated at v0.68.1 and will be removed at >= v1.0.0.
        abstract engagementName: string option with get, set
        /// Deprecated at v0.68.1 and will be removed at >= v1.0.0.
        abstract altText: string option with get, set
        /// The name to use for functional automation tests
        abstract automationId: string option with get, set
        /// Whether or not the link is in an expanded state
        abstract isExpanded: bool option with get, set
        /// Aria label for nav link
        abstract ariaLabel: string option with get, set
        /// title for tooltip or description
        abstract title: string option with get, set
        /// Link <a> target.
        abstract target: string option with get, set
        /// Point to the parent node key.  This is used in EditNav when move node from sublink to
        ///    parent link vs vers.
        abstract parentId: string option with get, set
        /// (Optional) By default, any link with onClick defined will render as a button.
        /// Set this property to true to override that behavior. (Links without onClick defined
        /// will render as anchors by default.)
        abstract forceAnchor: bool option with get, set
        /// (Optional) Any additional properties to apply to the rendered links.
        [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set

    type [<AllowNullLiteral>] INavStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// is element on top boolean
        abstract isOnTop: bool option with get, set
        /// is element a link boolean
        abstract isLink: bool option with get, set
        /// is element a group boolean
        abstract isGroup: bool option with get, set
        /// is element expanded boolean
        abstract isExpanded: bool option with get, set
        /// is element selected boolean
        abstract isSelected: bool option with get, set
        /// is button
        abstract isButtonEntry: bool option with get, set
        /// Nav height value
        abstract navHeight: float option with get, set
        /// left padding value
        abstract leftPadding: float option with get, set
        /// left padding when expanded value
        abstract leftPaddingExpanded: float option with get, set
        /// right padding value
        abstract rightPadding: float option with get, set
        /// position value
        abstract position: float option with get, set
        /// Inherited from INavProps
        /// A collection of link groups to display in the navigation bar
        abstract groups: ResizeArray<INavLinkGroup> option with get, set

    type [<AllowNullLiteral>] INavStyles =
        /// Style set for the root element.
        abstract root: IStyle with get, set
        /// Style set for the link text container div element.
        abstract linkText: IStyle with get, set
        /// Style set for the link element extending the
        /// root style set for ActionButton component.
        abstract link: IStyle with get, set
        /// Style set for the composite link container div element
        abstract compositeLink: IStyle with get, set
        /// Style set for the chevron button inside the composite
        /// link and group elements.
        abstract chevronButton: IStyle with get, set
        /// Style set for the chevron icon inside the composite
        /// link and group elements.
        abstract chevronIcon: IStyle with get, set
        /// Style set for the nav links ul element.
        abstract navItems: IStyle with get, set
        /// Style set for the nav links li element.
        abstract navItem: IStyle with get, set
        /// Style set for the group root div.
        abstract group: IStyle with get, set
        /// Style set for the group content div inside group.
        abstract groupContent: IStyle with get, set

module __components_Nav_NavPage =
    type IComponentDemoPageProps = __components_Nav_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract NavPage: NavPageStatic

    type [<AllowNullLiteral>] NavPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] NavPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NavPage

module __components_OverflowSet_OverflowSet_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract OverflowSetStatus: obj

module __components_OverflowSet_OverflowSet =
    type BaseComponent = Utilities.BaseComponent
    type IOverflowSet = __components_OverflowSet_OverflowSet_types.IOverflowSet
    type IOverflowSetProps = __components_OverflowSet_OverflowSet_types.IOverflowSetProps

    type [<AllowNullLiteral>] IExports =
        abstract OverflowSet: OverflowSetStatic

    type [<AllowNullLiteral>] OverflowSet =
        inherit BaseComponent<IOverflowSetProps, obj>
        inherit IOverflowSet
        abstract _focusZone: obj with get, set
        abstract _persistedKeytips: obj with get, set
        abstract _keytipManager: obj with get, set
        abstract _divContainer: obj with get, set
        abstract render: unit -> JSX.Element
        /// <summary>Sets focus to the first tabbable item in the OverflowSet.</summary>
        /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element,
        /// even if focus is already in theOverflowSet</param>
        abstract focus: ?forceIntoFirstElement: bool -> bool
        /// <summary>Sets focus to a specific child element within the OverflowSet.</summary>
        /// <param name="childElement">The child element within the zone to focus.</param>
        abstract focusElement: ?childElement: HTMLElement -> bool
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentWillUpdate: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract _registerPersistedKeytips: unit -> unit
        abstract _unregisterPersistedKeytips: unit -> unit
        abstract _onRenderItems: obj with get, set
        abstract _onRenderOverflowButtonWrapper: obj with get, set
        /// Gets the subMenu for an overflow item
        /// Checks if itemSubMenuProvider has been defined, if not defaults to subMenuProps
        abstract _getSubMenuForItem: item: obj -> unit

    type [<AllowNullLiteral>] OverflowSetStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IOverflowSetProps -> OverflowSet

module __components_OverflowSet_OverflowSet_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract rootVertical: obj
        abstract item: obj

module __components_OverflowSet_OverflowSet_types =
    type OverflowSet = __components_OverflowSet_OverflowSet.OverflowSet
    type IRenderFunction = Utilities.IRenderFunction
    type IFocusZoneProps = FocusZone.IFocusZoneProps
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IOverflowSet =
        /// <summary>Sets focus to the first tabbable item in the zone.</summary>
        /// <param name="forceIntoFirstElement">If true, focus will be forced into the first element, even if focus is already in the focus zone.</param>
        abstract focus: ?forceIntoFirstElement: bool -> bool
        /// <summary>Sets focus to a specific child element within the zone. This can be used in conjunction with
        /// onBeforeFocus to created delayed focus scenarios (like animate the scroll position to the correct
        /// location and then focus.)</summary>
        /// <param name="childElement">The child element within the zone to focus.</param>
        abstract focusElement: ?childElement: HTMLElement -> bool

    type [<AllowNullLiteral>] IOverflowSetProps =
        inherit React.Props<OverflowSet>
        /// Gets the component ref.
        abstract componentRef: (IOverflowSet option -> unit) option with get, set
        /// Class name
        abstract className: string option with get, set
        /// An array of items to be rendered by your onRenderItem function in the primary content area
        abstract items: ResizeArray<IOverflowSetItemProps> option with get, set
        /// Change item layout direction to vertical/stacked.
        abstract vertical: bool option with get, set
        /// An array of items to be passed to overflow contextual menu
        abstract overflowItems: ResizeArray<IOverflowSetItemProps> option with get, set
        /// Method to call when trying to render an item.
        abstract onRenderItem: (IOverflowSetItemProps -> obj option) with get, set
        /// Rendering method for overflow button and contextual menu. The argument to the function is
        /// the overflowItems passed in as props to this function.
        abstract onRenderOverflowButton: IRenderFunction<ResizeArray<obj option>> with get, set
        /// Custom properties for OverflowSet's FocusZone.
        /// If doNotContainWithinFocusZone is set to true focusZoneProps will be ignored.
        /// Use one or the other.
        abstract focusZoneProps: IFocusZoneProps option with get, set
        /// If true do not contain the OverflowSet inside of a FocusZone,
        /// otherwise the OverflowSet will contain a FocusZone.
        /// If this is set to true focusZoneProps will be ignored.
        /// Use one or the other.
        abstract doNotContainWithinFocusZone: bool option with get, set
        /// The role for the OverflowSet.
        abstract role: string option with get, set
        /// Optional full keytip sequence for the overflow button, if it will have a keytip.
        abstract keytipSequences: ResizeArray<string> option with get, set
        /// Function that will take in an IOverflowSetItemProps and return the subMenu for that item.
        /// If not provided, will use 'item.subMenuProps.items' by default.
        /// This is only used if your overflow set has keytips.
        abstract itemSubMenuProvider: (IOverflowSetItemProps -> ResizeArray<obj option> option) option with get, set

    type [<AllowNullLiteral>] IOverflowSetItemProps =
        /// Unique id to identify the item.
        abstract key: string with get, set
        /// Optional keytip for the overflowSetItem.
        abstract keytipProps: IKeytipProps option with get, set
        /// Any additional properties to use when custom rendering menu items.
        [<Emit "$0[$1]{{=$2}}">] abstract Item: propertyName: string -> obj option with get, set

module __components_OverflowSet_OverflowSetPage =
    type IComponentDemoPageProps = __components_OverflowSet_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract OverflowSetPage: OverflowSetPageStatic

    type [<AllowNullLiteral>] OverflowSetPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] OverflowSetPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OverflowSetPage

module __components_Overlay_Overlay_base =
    type BaseComponent = Utilities.BaseComponent
    type IOverlayProps = __components_Overlay_Overlay_types.IOverlayProps

    type [<AllowNullLiteral>] IExports =
        abstract OverlayBase: OverlayBaseStatic

    type [<AllowNullLiteral>] OverlayBase =
        inherit BaseComponent<IOverlayProps, obj>
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] OverlayBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OverlayBase

module __components_Overlay_Overlay_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract OverlayStatus: obj

module __components_Overlay_Overlay =
    type IOverlayProps = __components_Overlay_Overlay_types.IOverlayProps

    type [<AllowNullLiteral>] IExports =
        abstract Overlay: (IOverlayProps -> JSX.Element)

module __components_Overlay_Overlay_styles =
    type IOverlayStyleProps = __components_Overlay_Overlay_types.IOverlayStyleProps
    type IOverlayStyles = __components_Overlay_Overlay_types.IOverlayStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IOverlayStyleProps -> IOverlayStyles)

module __components_Overlay_Overlay_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IOverlay =
        interface end

    type [<AllowNullLiteral>] IOverlayProps =
        inherit React.HTMLAttributes<HTMLElement>
        /// Gets the component ref.
        abstract componentRef: (IOverlayProps option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IOverlayStyleProps, IOverlayStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Overlay
        abstract className: string option with get, set
        /// Whether to use the dark-themed overlay.
        abstract isDarkThemed: bool option with get, set
        abstract onClick: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] IOverlayStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// Is overlay visible
        abstract isNone: bool option with get, set
        /// Is overlay dark themed
        abstract isDark: bool option with get, set

    type [<AllowNullLiteral>] IOverlayStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set

module __components_Overlay_OverlayPage =
    type IComponentDemoPageProps = __components_Overlay_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract OverlayPage: OverlayPageStatic

    type [<AllowNullLiteral>] OverlayPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] OverlayPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OverlayPage

module __components_Panel_Panel_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract PanelStatus: obj

module __components_Panel_Panel =
    type BaseComponent = Utilities.BaseComponent
    type IPanel = __components_Panel_Panel_types.IPanel
    type IPanelProps = __components_Panel_Panel_types.IPanelProps

    type [<AllowNullLiteral>] IExports =
        abstract Panel: PanelStatic

    type [<AllowNullLiteral>] IPanelState =
        abstract isFooterSticky: bool option with get, set
        abstract isOpen: bool option with get, set
        abstract isAnimating: bool option with get, set
        abstract id: string option with get, set

    type [<AllowNullLiteral>] Panel =
        inherit BaseComponent<IPanelProps, IPanelState>
        inherit IPanel
        abstract defaultProps: IPanelProps with get, set
        abstract _panel: obj with get, set
        abstract _content: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: IPanelProps -> unit
        abstract render: unit -> JSX.Element option
        abstract ``open``: unit -> unit
        abstract dismiss: (unit -> unit) with get, set
        abstract _onRenderNavigation: obj with get, set
        abstract _onRenderHeader: obj with get, set
        abstract _onRenderBody: obj with get, set
        abstract _onRenderFooter: obj with get, set
        abstract _updateFooterPosition: unit -> unit
        abstract _dismissOnOuterClick: ev: obj -> unit
        abstract _onPanelClick: obj with get, set
        abstract _onTransitionComplete: obj with get, set

    type [<AllowNullLiteral>] PanelStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPanelProps -> Panel

module __components_Panel_Panel_scss =

    type [<AllowNullLiteral>] IExports =
        abstract hiddenPanel: obj
        abstract root: obj
        abstract overlay: obj
        abstract main: obj
        abstract rootIsSmall: obj
        abstract rootIsSmallLeft: obj
        abstract rootIsSmallFluid: obj
        abstract rootIsMedium: obj
        abstract rootIsLarge: obj
        abstract rootIsXLarge: obj
        abstract rootIsCustom: obj
        abstract rootIsFixed: obj
        abstract rootIsOpen: obj
        abstract navigation: obj
        abstract contentInner: obj
        abstract rootHasCloseButton: obj
        abstract header: obj
        abstract content: obj
        abstract footerInner: obj
        abstract contentGrow: obj
        abstract footer: obj
        abstract footerIsSticky: obj
        abstract headerText: obj

module __components_Panel_Panel_types =
    type Panel = __components_Panel_Panel.Panel
    type IRenderFunction = Utilities.IRenderFunction
    type ILayerProps = Layer.ILayerProps
    type IFocusTrapZoneProps = FocusTrapZone.IFocusTrapZoneProps

    type [<AllowNullLiteral>] IPanel =
        /// Forces the panel to open.
        abstract ``open``: (unit -> unit) with get, set
        /// Forces the panel to dismiss.
        abstract dismiss: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IPanelProps =
        inherit React.Props<Panel>
        /// Optional callback to access the IPanel interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IPanel option -> unit) option with get, set
        /// Whether the panel is displayed.
        abstract isOpen: bool option with get, set
        /// Has the close button visible.
        abstract hasCloseButton: bool option with get, set
        /// Whether the panel can be light dismissed.
        abstract isLightDismiss: bool option with get, set
        /// Whether the panel is hidden on dismiss, instead of destroyed in the DOM.
        abstract isHiddenOnDismiss: bool option with get, set
        /// Whether the panel uses a modal overlay or not
        abstract isBlocking: bool option with get, set
        /// Determines if content should stretch to fill available space putting footer at the bottom of the page
        abstract isFooterAtBottom: bool option with get, set
        /// Header text for the Panel.
        abstract headerText: string option with get, set
        /// A callback function for when the panel is closed, before the animation completes.
        abstract onDismiss: (unit -> unit) option with get, set
        /// A callback function which is called after the Panel is dismissed and the animation is complete.
        abstract onDismissed: (unit -> unit) option with get, set
        /// Additional styling options.
        abstract className: string option with get, set
        /// Type of the panel.
        abstract ``type``: PanelType option with get, set
        /// Custom panel width, used only when type is set to PanelType.custom.
        abstract customWidth: string option with get, set
        /// Aria label on close button
        abstract closeButtonAriaLabel: string option with get, set
        /// Optional parameter to provider the class name for header text
        abstract headerClassName: string option with get, set
        /// Sets the HTMLElement to focus on when exiting the FocusTrapZone.
        abstract elementToFocusOnDismiss: HTMLElement option with get, set
        /// Indicates if this Panel will ignore keeping track of HTMLElement that activated the Zone.
        /// Deprecated, use focusTrapZoneProps.
        abstract ignoreExternalFocusing: bool option with get, set
        /// Indicates whether Panel should force focus inside the focus trap zone
        /// Deprecated, use focusTrapZoneProps.
        abstract forceFocusInsideTrap: bool option with get, set
        /// Indicates the selector for first focusable item.
        /// Deprecated, use focusTrapZoneProps.
        abstract firstFocusableSelector: string option with get, set
        /// Optional props to pass to the FocusTrapZone component to manage focus in the panel.
        abstract focusTrapZoneProps: IFocusTrapZoneProps option with get, set
        /// Optional props to pass to the Layer component hosting the panel.
        abstract layerProps: ILayerProps option with get, set
        /// Optional custom function to handle clicks outside the panel in lightdismiss mode
        abstract onLightDismissClick: (unit -> unit) option with get, set
        /// Optional custom function to handle clicks outside this component
        abstract onOuterClick: (unit -> unit) option with get, set
        /// Optional custom renderer navigation region. Replaces current close button.
        abstract onRenderNavigation: IRenderFunction<IPanelProps> option with get, set
        /// Optional custom renderer for header region. Replaces current title
        abstract onRenderHeader: IPanelHeaderRenderer option with get, set
        /// Optional custom renderer for body region. Replaces any children passed into the component.
        abstract onRenderBody: IRenderFunction<IPanelProps> option with get, set
        /// Optional custom renderer for footer region. Replaces sticky footer.
        abstract onRenderFooter: IRenderFunction<IPanelProps> option with get, set
        /// Custom renderer for content in the sticky footer
        abstract onRenderFooterContent: IRenderFunction<IPanelProps> option with get, set
        /// Deprecated property. Serves no function.
        abstract componentId: string option with get, set

    /// Renderer function which takes an additional parameter, the ID to use for the element containing
    /// the panel's title. This allows the `aria-labelledby` for the panel popup to work correctly.
    /// Note that if `headerTextId` is provided, it **must** be used on an element, or screen readers
    /// will be confused by the reference to a nonexistent ID.
    type [<AllowNullLiteral>] IPanelHeaderRenderer =
        inherit IRenderFunction<IPanelProps>
        /// <param name="props">Props given to the panel</param>
        /// <param name="defaultRender">Default header renderer. If using this renderer in code that does not
        /// assign `headerTextId` to an element elsewhere, it **must** be passed to this function.</param>
        /// <param name="headerTextId">If provided, this **must** be used as the ID of an element containing the
        /// panel's title, because the panel popup uses this ID as its aria-labelledby.</param>
        [<Emit "$0($1...)">] abstract Invoke: ?props: IPanelProps * ?defaultRender: IPanelHeaderRenderer * ?headerTextId: string option -> JSX.Element option

    type [<RequireQualifiedAccess>] PanelType =
        | SmallFluid = 0
        | SmallFixedFar = 1
        | SmallFixedNear = 2
        | Medium = 3
        | Large = 4
        | LargeFixed = 5
        | ExtraLarge = 6
        | Custom = 7

module __components_Panel_PanelPage =
    type IComponentDemoPageProps = __components_Panel_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract PanelPage: PanelPageStatic

    type [<AllowNullLiteral>] PanelPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PanelPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PanelPage

module __components_Persona_Persona_base =
    type BaseComponent = Utilities.BaseComponent
    type IPersonaProps = __components_Persona_Persona_types.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract PersonaBase: PersonaBaseStatic

    /// Persona with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] PersonaBase =
        inherit BaseComponent<IPersonaProps, obj>
        abstract defaultProps: IPersonaProps with get, set
        abstract render: unit -> JSX.Element
        /// Deprecation helper for getting text.
        abstract _getText: unit -> unit
        abstract _renderElement: obj with get, set

    /// Persona with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] PersonaBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPersonaProps -> PersonaBase

module __components_Persona_Persona_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract PersonaStatus: obj

module __components_Persona_Persona =
    type IPersonaProps = __components_Persona_Persona_types.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract Persona: (IPersonaProps -> JSX.Element)

module __components_Persona_Persona_styles =
    type IPersonaStyleProps = __components_Persona_Persona_types.IPersonaStyleProps
    type IPersonaStyles = __components_Persona_Persona_types.IPersonaStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IPersonaStyleProps -> IPersonaStyles)

module __components_Persona_Persona_types =
    type IRenderFunction = Utilities.IRenderFunction
    type PersonaBase = __components_Persona_Persona_base.PersonaBase
    type ImageLoadState = Image.ImageLoadState
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IPersona =
        interface end

    type [<AllowNullLiteral>] IPersonaSharedProps =
        inherit React.HTMLAttributes<PersonaBase>
        /// Primary text to display, usually the name of the person.
        abstract text: string option with get, set
        /// Decides the size of the control.
        abstract size: PersonaSize option with get, set
        /// Optional custom renderer for the coin
        abstract onRenderCoin: IRenderFunction<IPersonaSharedProps> option with get, set
        /// If true, adds the css class 'is-fadeIn' to the image.
        abstract imageShouldFadeIn: bool option with get, set
        /// If true, the image starts as visible and is hidden on error. Otherwise, the image is hidden until
        /// it is successfully loaded. This disables imageShouldFadeIn.
        abstract imageShouldStartVisible: bool option with get, set
        /// Url to the image to use, should be a square aspect ratio and big enough to fit in the image area.
        abstract imageUrl: string option with get, set
        /// Alt text for the image to use. Defaults to an empty string.
        abstract imageAlt: string option with get, set
        /// The user's initials to display in the image area when there is no image.
        abstract imageInitials: string option with get, set
        /// Whether initials are calculated for phone numbers and number sequences.
        /// Example: Set property to true to get initials for project names consisting of numbers only.
        abstract allowPhoneInitials: bool option with get, set
        /// Optional custom renderer for the initials
        abstract onRenderInitials: IRenderFunction<IPersonaSharedProps> option with get, set
        /// Optional callback for when loading state of the photo changes
        abstract onPhotoLoadingStateChange: (ImageLoadState -> unit) option with get, set
        /// The background color when the user's initials are displayed.
        abstract initialsColor: U2<PersonaInitialsColor, string> option with get, set
        /// Presence of the person to display - will not display presence if undefined.
        abstract presence: PersonaPresence option with get, set
        /// Secondary text to display, usually the role of the user.
        abstract secondaryText: string option with get, set
        /// Tertiary text to display, usually the status of the user.
        abstract tertiaryText: string option with get, set
        /// Optional text to display, usually a custom message set.
        abstract optionalText: string option with get, set
        /// Whether to not render persona details, and just render the persona image/initials.
        abstract hidePersonaDetails: bool option with get, set
        abstract showSecondaryText: bool option with get, set
        /// If true, show the special coin for unknown persona.
        /// It has '?' in place of initials, with static font and background colors
        abstract showUnknownPersonaCoin: bool option with get, set
        /// Optional custom persona coin size in pixel.
        abstract coinSize: float option with get, set
        /// Optional HTML element props for Persona coin.
        abstract coinProps: React.HTMLAttributes<HTMLDivElement> option with get, set
        /// Theme provided by High-Order Component.
        abstract theme: ITheme option with get, set
        /// Primary text to display, usually the name of the person.
        abstract primaryText: string option with get, set

    type [<AllowNullLiteral>] IPersonaProps =
        inherit IPersonaSharedProps
        /// Optional callback to access the IPersona interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IPersona option -> unit) option with get, set
        /// Additional CSS class(es) to apply to the Persona
        abstract className: string option with get, set
        /// Call to provide customized styling that will layer on top of variant rules
        abstract getStyles: IStyleFunction<IPersonaStyleProps, IPersonaStyles> option with get, set
        /// Optional custom renderer for the primary text.
        abstract onRenderPrimaryText: IRenderFunction<IPersonaProps> option with get, set
        /// Optional custom renderer for the secondary text.
        abstract onRenderSecondaryText: IRenderFunction<IPersonaProps> option with get, set
        /// Optional custom renderer for the tertiary text.
        abstract onRenderTertiaryText: IRenderFunction<IPersonaProps> option with get, set
        /// Optional custom renderer for the optional text.
        abstract onRenderOptionalText: IRenderFunction<IPersonaProps> option with get, set

    type [<AllowNullLiteral>] IPersonaStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Custom class name.
        abstract className: string option with get, set
        /// Optional custom persona coin size in pixel.
        abstract coinSize: float option with get, set
        /// Decides the size of the control.
        abstract size: PersonaSize option with get, set
        /// Presence of the person to display - will not display presence if undefined.
        abstract presence: PersonaPresence option with get, set
        abstract showSecondaryText: bool option with get, set

    type [<AllowNullLiteral>] IPersonaStyles =
        abstract root: IStyle with get, set
        abstract details: IStyle with get, set
        abstract primaryText: IStyle with get, set
        abstract secondaryText: IStyle with get, set
        abstract tertiaryText: IStyle with get, set
        abstract optionalText: IStyle with get, set
        abstract textContent: IStyle with get, set

    type [<AllowNullLiteral>] IPersonaCoinProps =
        inherit IPersonaSharedProps
        /// Gets the component ref.
        abstract componentRef: (IPersonaCoinProps -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IPersonaCoinStyleProps, IPersonaCoinStyles> option with get, set
        /// Additional css class to apply to the PersonaCoin
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IPersonaCoinStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Custom class name.
        abstract className: string option with get, set
        /// Decides the size of the control.
        abstract size: PersonaSize option with get, set
        /// Decides whether to display coin for unknown persona
        abstract showUnknownPersonaCoin: bool option with get, set

    type [<AllowNullLiteral>] IPersonaCoinStyles =
        abstract coin: IStyle with get, set
        abstract imageArea: IStyle with get, set
        abstract image: IStyle with get, set
        abstract initials: IStyle with get, set
        abstract size10WithoutPresenceIcon: IStyle with get, set

    type [<AllowNullLiteral>] IPersonaPresenceProps =
        inherit IPersonaSharedProps
        /// Gets the component ref.
        abstract componentRef: (IPersonaPresenceProps -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IPersonaPresenceStyleProps, IPersonaPresenceStyles> option with get, set

    type [<AllowNullLiteral>] IPersonaPresenceStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Custom class name.
        abstract className: string option with get, set
        /// Presence of the person to display - will not display presence if undefined.
        abstract presence: PersonaPresence option with get, set
        /// Decides the size of the control.
        abstract size: PersonaSize option with get, set

    type [<AllowNullLiteral>] IPersonaPresenceStyles =
        abstract presence: IStyle with get, set
        abstract presenceIcon: IStyle with get, set

    type [<RequireQualifiedAccess>] PersonaSize =
        | Tiny = 0
        | ExtraExtraSmall = 1
        | ExtraSmall = 2
        | Small = 3
        | Regular = 4
        | Large = 5
        | ExtraLarge = 6
        | Size28 = 7
        | Size16 = 8
        | Size10 = 9
        | Size24 = 10
        | Size32 = 11
        | Size40 = 12
        | Size48 = 13
        | Size72 = 14
        | Size100 = 15

    type [<RequireQualifiedAccess>] PersonaPresence =
        | None = 0
        | Offline = 1
        | Online = 2
        | Away = 3
        | Dnd = 4
        | Blocked = 5
        | Busy = 6

    type [<RequireQualifiedAccess>] PersonaInitialsColor =
        | LightBlue = 0
        | Blue = 1
        | DarkBlue = 2
        | Teal = 3
        | LightGreen = 4
        | Green = 5
        | DarkGreen = 6
        | LightPink = 7
        | Pink = 8
        | Magenta = 9
        | Purple = 10
        | Black = 11
        | Orange = 12
        | Red = 13
        | DarkRed = 14
        | Transparent = 15

module __components_Persona_PersonaConsts =
    type PersonaPresence = __components_Persona_Persona_types.PersonaPresence
    type PersonaSize = __components_Persona_Persona_types.PersonaSize

    type [<AllowNullLiteral>] IExports =
        abstract sizeBoolean: (PersonaSize -> obj)
        abstract presenceBoolean: (PersonaPresence -> obj)

    module PersonaSize =

        type [<AllowNullLiteral>] IExports =
            abstract size10: obj
            abstract size16: obj
            abstract size24: obj
            abstract size28: obj
            abstract size32: obj
            abstract size40: obj
            abstract size48: obj
            abstract size72: obj
            abstract size100: obj

    module PersonaPresenceSize =

        type [<AllowNullLiteral>] IExports =
            abstract size6: obj
            abstract size8: obj
            abstract size12: obj
            abstract size20: obj
            abstract size28: obj
            abstract border: obj

module __components_Persona_PersonaInitialsColor =
    type IPersonaProps = __components_Persona_Persona_types.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract initialsColorPropToColorCode: props: IPersonaProps -> string

module __components_Persona_PersonaPage =
    type IComponentDemoPageProps = __components_Persona_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract PersonaPage: PersonaPageStatic

    type [<AllowNullLiteral>] PersonaPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PersonaPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PersonaPage

module __components_pickers_BasePicker =
    type BaseComponent = Utilities.BaseComponent
    type KeyCodes = Utilities.KeyCodes
    type IFocusZone = FocusZone.IFocusZone
    type Selection = __utilities_selection_index.Selection
    type Suggestions = __components_pickers_Suggestions_Suggestions.Suggestions
    type ISuggestionsProps = __components_pickers_Suggestions_Suggestions_types.ISuggestionsProps
    type SuggestionsController = __components_pickers_Suggestions_SuggestionsController.SuggestionsController
    type IBasePicker = __components_pickers_BasePicker_types.IBasePicker
    type IBasePickerProps = __components_pickers_BasePicker_types.IBasePickerProps
    type IAutofill = __components_Autofill_index.IAutofill
    type Autofill = __components_Autofill_index.Autofill
    type IPickerItemProps = __components_pickers_PickerItem_types.IPickerItemProps
    type IPersonaProps = __components_Persona_Persona_types.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract BasePicker: BasePickerStatic
        abstract BasePickerListBelow: BasePickerListBelowStatic

    type [<AllowNullLiteral>] IBasePickerState =
        abstract items: obj option with get, set
        abstract suggestedDisplayValue: string option with get, set
        abstract moreSuggestionsAvailable: bool option with get, set
        abstract isFocused: bool option with get, set
        abstract isSearching: bool option with get, set
        abstract isMostRecentlyUsedVisible: bool option with get, set
        abstract suggestionsVisible: bool option with get, set
        abstract suggestionsLoading: bool option with get, set
        abstract isResultsFooterVisible: bool option with get, set

    type [<AllowNullLiteral>] BasePicker<'T, 'P> =
        inherit BaseComponent<'P, IBasePickerState>
        inherit IBasePicker<'T>
        abstract selection: Selection with get, set
        abstract root: obj with get, set
        abstract input: obj with get, set
        abstract focusZone: obj with get, set
        abstract suggestionElement: obj with get, set
        abstract suggestionStore: SuggestionsController<'T> with get, set
        abstract SuggestionOfProperType: obj with get, set
        abstract loadingTimer: float option with get, set
        abstract currentPromise: PromiseLike<obj option> option with get, set
        abstract items: ResizeArray<'T>
        abstract componentWillUpdate: newProps: 'P * newState: IBasePickerState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: 'P -> unit
        abstract componentWillUnmount: unit -> unit
        abstract focus: unit -> unit
        abstract focusInput: unit -> unit
        abstract dismissSuggestions: (obj option -> unit) with get, set
        abstract completeSuggestion: unit -> unit
        abstract refocusSuggestions: (KeyCodes -> unit) with get, set
        abstract render: unit -> JSX.Element
        abstract canAddItems: unit -> bool
        abstract renderSuggestions: unit -> JSX.Element option
        abstract renderItems: unit -> ResizeArray<JSX.Element>
        abstract resetFocus: ?index: float -> unit
        abstract onSuggestionSelect: unit -> unit
        abstract onSelectionChange: unit -> unit
        abstract updateSuggestions: suggestions: ResizeArray<obj option> -> unit
        abstract onEmptyInputFocus: unit -> unit
        abstract updateValue: updatedValue: string -> unit
        abstract updateSuggestionsList: suggestions: U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>> * ?updatedValue: string -> unit
        abstract resolveNewValue: updatedValue: string * suggestions: ResizeArray<'T> -> unit
        abstract onChange: ?items: ResizeArray<'T> -> unit
        abstract onInputChange: (string -> unit) with get, set
        abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> obj option -> float -> unit) with get, set
        abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> IPersonaProps -> float -> unit) with get, set
        abstract onInputFocus: (React.FocusEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
        abstract onInputBlur: (React.FocusEvent<U2<HTMLInputElement, Autofill>> -> unit) with get, set
        abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
        abstract onItemChange: ('T -> float -> unit) with get, set
        abstract onGetMoreResults: (unit -> unit) with get, set
        abstract addItemByIndex: (float -> unit) with get, set
        abstract addItem: ('T -> unit) with get, set
        abstract removeItem: (IPickerItemProps<'T> -> unit) with get, set
        abstract removeItems: (ResizeArray<obj option> -> unit) with get, set
        abstract onBackspace: ev: React.KeyboardEvent<HTMLElement> -> unit
        abstract _isFocusZoneInnerKeystroke: (React.KeyboardEvent<HTMLElement> -> bool) with get, set
        /// Controls what happens whenever there is an action that impacts the selected items.
        /// If selectedItems is provided as a property then this will act as a controlled component and it will not update it's own state.
        abstract _updateSelectedItems: items: obj * ?focusIndex: obj -> unit
        abstract _onSelectedItemsUpdated: ?items: obj * ?focusIndex: obj -> unit
        abstract _onResolveSuggestions: updatedValue: obj -> unit
        abstract _onValidateInput: unit -> unit
        abstract _getTextFromItem: item: obj * ?currentValue: obj -> unit

    type [<AllowNullLiteral>] BasePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BasePicker<'T, 'P>

    type [<AllowNullLiteral>] BasePickerListBelow<'T, 'P> =
        inherit BasePicker<'T, 'P>
        abstract render: unit -> JSX.Element
        abstract onBackspace: ev: React.KeyboardEvent<HTMLElement> -> unit

    type [<AllowNullLiteral>] BasePickerListBelowStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BasePickerListBelow<'T, 'P>

module __components_pickers_BasePicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract pickerText: obj
        abstract inputFocused: obj
        abstract pickerInput: obj
        abstract screenReaderOnly: obj

module __components_pickers_BasePicker_types =
    type IPickerItemProps = __components_pickers_PickerItem_types.IPickerItemProps
    type IPersonaProps = __components_Persona_Persona_types.IPersonaProps
    type IRenderFunction = Utilities.IRenderFunction
    type ISuggestionModel = __components_pickers_Suggestions_SuggestionsController.ISuggestionModel
    type BaseAutoFill = __components_pickers_AutoFill_BaseAutoFill.BaseAutoFill

    type [<AllowNullLiteral>] IBasePicker<'T> =
        /// Gets the current value of the input. 
        abstract items: ResizeArray<'T> option with get, set
        /// Sets focus to the focus zone. 
        abstract focus: (unit -> unit) with get, set
        /// Set focus to the input 
        abstract focusInput: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IBasePickerProps<'T> =
        inherit React.Props<obj option>
        abstract componentRef: (IBasePicker<'T> option -> unit) option with get, set
        /// Function that specifies how the selected item will appear.
        abstract onRenderItem: (IPickerItemProps<'T> -> JSX.Element) option with get, set
        /// Function that specifies how an individual suggestion item will appear.
        abstract onRenderSuggestionsItem: ('T -> obj option -> JSX.Element) option with get, set
        /// A callback for what should happen when a person types text into the input.
        /// Returns the already selected items so the resolver can filter them out.
        /// If used in conjunction with resolveDelay this will ony kick off after the delay throttle.
        abstract onResolveSuggestions: (string -> ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) with get, set
        /// The delay time in ms before resolving suggestions, which is kicked off when input has been cahnged.
        /// e.g. If a second input change happens within the resolveDelay time, the timer will start over.
        /// Only until after the timer completes will onResolveSuggestions be called.
        abstract resolveDelay: float option with get, set
        /// A callback for what should happen when a user clicks the input.
        abstract onEmptyInputFocus: (ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) option with get, set
        /// Initial items that have already been selected and should appear in the people picker.
        abstract defaultSelectedItems: ResizeArray<'T> option with get, set
        /// A callback for when the selected list of items changes.
        abstract onChange: (ResizeArray<'T> -> unit) option with get, set
        /// A callback for when the user put focus on the picker
        abstract onFocus: React.FocusEventHandler<U2<HTMLInputElement, BaseAutoFill>> option with get, set
        /// A callback for when the user moves the focus away from the picker
        abstract onBlur: React.FocusEventHandler<U2<HTMLInputElement, BaseAutoFill>> option with get, set
        /// A callback to get text from an item. Used to autofill text in the pickers.
        abstract getTextFromItem: ('T -> string -> string) option with get, set
        /// A callback that gets the rest of the results when a user clicks get more results.
        abstract onGetMoreResults: (string -> ResizeArray<'T> -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>) option with get, set
        /// ClassName for the picker.
        abstract className: string option with get, set
        /// The properties that will get passed to the Suggestions component.
        abstract pickerSuggestionsProps: IBasePickerSuggestionsProps option with get, set
        /// AutoFill input native props
        abstract inputProps: IInputProps option with get, set
        /// A callback for when a persona is removed from the suggestion list
        abstract onRemoveSuggestion: (IPersonaProps -> unit) option with get, set
        /// A function used to validate if raw text entered into the well can be added into the selected items list
        abstract onValidateInput: (string -> ValidationState) option with get, set
        /// The text to display while searching for more results in a limited suggestions list
        abstract searchingText: U2<(obj -> string), string> option with get, set
        /// Flag for disabling the picker.
        abstract disabled: bool option with get, set
        /// Restrict the amount of selectable items.
        abstract itemLimit: float option with get, set
        /// Function that specifies how arbitrary text entered into the well is handled.
        abstract createGenericItem: (string -> ValidationState -> U2<ISuggestionModel<'T>, 'T>) option with get, set
        /// Aria label for the "X" button in the selected item component.
        abstract removeButtonAriaLabel: string option with get, set
        /// A callback to process a selection after the user selects something from the picker. If the callback returns null,
        /// the item will not be added to the picker.
        abstract onItemSelected: ('T -> U2<'T, PromiseLike<'T>> option) option with get, set
        /// The items that the base picker should currently display as selected. If this is provided then the picker will act as a controlled component.
        abstract selectedItems: ResizeArray<'T> option with get, set
        /// A callback used to modify the input string.
        abstract onInputChange: (string -> string) option with get, set
        /// A callback to override the default behavior of adding the selected suggestion on dismiss.
        abstract onDismiss: (obj option -> 'T -> unit) option with get, set
        /// Adds an additional alert for the currently selected suggestion. This prop should be set to true for IE11 and below, as it
        /// enables proper screen reader behavior for each suggestion (since aria-activedescendant does not work with IE11).
        /// It should not be set for modern browsers (Edge, Chrome).
        abstract enableSelectedSuggestionAlert: bool option with get, set

    type [<AllowNullLiteral>] IBasePickerSuggestionsProps =
        /// Function that specifies what to render when no results are found.
        abstract onRenderNoResultFound: IRenderFunction<unit> option with get, set
        /// The text that should appear at the top of the suggestion box.
        abstract suggestionsHeaderText: string option with get, set
        /// The text that should appear at the top of the most recently used box.
        abstract mostRecentlyUsedHeaderText: string option with get, set
        /// the text that should appear when no results are returned.
        abstract noResultsFoundText: string option with get, set
        /// ClassName for the picker.
        abstract className: string option with get, set
        /// Classname for the suggestion box.
        abstract suggestionsClassName: string option with get, set
        /// ClassName for suggestion items.
        abstract suggestionsItemClassName: string option with get, set
        /// The text that should appear on the button to search for more.
        abstract searchForMoreText: string option with get, set
        /// The text that appears indicating to the use to force resolve the input
        abstract forceResolveText: string option with get, set
        /// The text to display while the results are loading.
        abstract loadingText: string option with get, set
        /// The text to display while searching for more results in a limited sugesstions list.
        abstract searchingText: string option with get, set
        /// A renderer that adds an element at the end of the suggestions list it has more items than resultsMaximumNumber.
        abstract resultsFooterFull: (unit -> JSX.Element) option with get, set
        /// A renderer that adds an element at the end of the suggestions list when there are fewer than resultsMaximumNumber.
        abstract resultsFooter: (unit -> JSX.Element) option with get, set
        /// Maximum number of suggestions to show in the full suggestion list.
        abstract resultsMaximumNumber: float option with get, set
        /// Indicates whether to show a button with each suggestion to remove that suggestion.
        abstract showRemoveButtons: bool option with get, set
        /// Screen reader message to read when there are suggestions available.
        abstract suggestionsAvailableAlertText: string option with get, set
        /// An ARIA label for the container that is the parent of the suggestions.
        abstract suggestionsContainerAriaLabel: string option with get, set

    type [<RequireQualifiedAccess>] ValidationState =
        | Valid = 0
        | Warning = 1
        | Invalid = 2

    type [<AllowNullLiteral>] IInputProps =
        inherit React.InputHTMLAttributes<HTMLInputElement>
        /// Screen reader label to apply to an input element.
        abstract ``aria-label``: string option with get, set
        /// The default value to be visible when the autofill first created.
        /// This is different than placeholder text because the placeholder text will disappear and re-appear. This
        /// text persists until deleted or changed.
        abstract defaultVisibleValue: string option with get, set

module __components_pickers_PickerItem_types =

    type [<AllowNullLiteral>] IPickerItemProps<'T> =
        inherit React.AllHTMLAttributes<HTMLElement>
        abstract componentRef: (unit -> unit) option with get, set
        abstract item: 'T with get, set
        abstract index: float with get, set
        abstract selected: bool option with get, set
        abstract onRemoveItem: (unit -> unit) option with get, set
        /// Internal Use only, gives a callback to the renderer to call when an item has changed.
        /// This allows the base picker to keep track of changes in the items.
        abstract onItemChange: ('T -> float -> unit) option with get, set
        abstract key: U2<string, float> option with get, set
        abstract removeButtonAriaLabel: string option with get, set

module __components_pickers_Pickers_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract PickersStatus: obj

module __components_pickers_PickersPage =
    type IComponentDemoPageProps = __components_pickers_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract PickersPage: PickersPageStatic

    type [<AllowNullLiteral>] PickersPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PickersPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PickersPage

module __components_Pivot_Pivot_base =
    type BaseComponent = Utilities.BaseComponent
    type IPivotProps = __components_Pivot_Pivot_types.IPivotProps
    type IPivotItemProps = __components_Pivot_PivotItem_types.IPivotItemProps

    type [<AllowNullLiteral>] IExports =
        abstract PivotBase: PivotBaseStatic

    /// Usage:
    /// 
    ///   <Pivot>
    ///     <PivotItem linkText="Foo">
    ///       <Label>Pivot #1</Label>
    ///     </PivotItem>
    ///     <PivotItem linkText="Bar">
    ///       <Label>Pivot #2</Label>
    ///     </PivotItem>
    ///     <PivotItem linkText="Bas">
    ///       <Label>Pivot #3</Label>
    ///     </PivotItem>
    ///   </Pivot>
    type [<AllowNullLiteral>] IPivotState =
        abstract links: ResizeArray<IPivotItemProps> with get, set
        abstract selectedKey: string with get, set
        abstract selectedTabId: string with get, set

    type [<AllowNullLiteral>] PivotBase =
        inherit BaseComponent<IPivotProps, IPivotState>
        abstract _keyToIndexMapping: obj with get, set
        abstract _keyToTabIds: obj with get, set
        abstract _pivotId: obj with get, set
        abstract focusZone: obj with get, set
        abstract componentWillReceiveProps: nextProps: IPivotProps -> unit
        /// Sets focus to the first pivot tab.
        abstract focus: unit -> unit
        abstract render: unit -> JSX.Element
        /// Renders the set of links to route between pivots
        abstract _renderPivotLinks: unit -> unit
        abstract _renderPivotLink: obj with get, set
        abstract _renderLinkContent: obj with get, set
        /// Renders the current Pivot Item
        abstract _renderPivotItem: unit -> unit
        /// Gets the set of PivotLinks as arrary of IPivotItemProps
        /// The set of Links is determined by child components of type PivotItem
        abstract _getPivotLinks: props: obj -> unit
        /// Generates the Id for the tab button.
        abstract _getTabId: itemKey: obj * index: obj -> unit
        /// whether the key exists in the pivot items.
        abstract _isKeyValid: itemKey: obj -> unit
        /// Handles the onClick event on PivotLinks
        abstract _onLinkClick: itemKey: obj * ev: obj -> unit
        /// Handle the onKeyPress eventon the PivotLinks
        abstract _onKeyPress: itemKey: obj * ev: obj -> unit
        /// Updates the state with the new selected index
        abstract _updateSelectedItem: itemKey: obj * ?ev: obj -> unit

    type [<AllowNullLiteral>] PivotBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPivotProps -> PivotBase

module __components_Pivot_Pivot_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract PivotStatus: obj

module __components_Pivot_Pivot =
    type IPivotProps = __components_Pivot_Pivot_types.IPivotProps

    type [<AllowNullLiteral>] IExports =
        abstract Pivot: (IPivotProps -> JSX.Element)

module __components_Pivot_Pivot_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract links: obj
        abstract link: obj
        abstract text: obj
        abstract count: obj
        abstract icon: obj
        abstract linkIsSelected: obj
        abstract linkIsDisabled: obj
        abstract linkIsOverflow: obj
        abstract ellipsis: obj
        abstract rootIsLarge: obj
        abstract rootIsTabs: obj

module __components_Pivot_Pivot_styles =
    type IPivotStyleProps = __components_Pivot_Pivot_types.IPivotStyleProps
    type IPivotStyles = __components_Pivot_Pivot_types.IPivotStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IPivotStyleProps -> IPivotStyles)

module __components_Pivot_Pivot_types =
    type PivotBase = __components_Pivot_Pivot_base.PivotBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction
    type PivotItem = __components_Pivot_PivotItem.PivotItem

    type [<AllowNullLiteral>] IPivot =
        /// Sets focus to the first pivot tab.
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] IPivotProps =
        inherit React.Props<PivotBase>
        /// Optional callback to access the IPivot interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IPivot option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<IPivotStyleProps, IPivotStyles> option with get, set
        /// Theme provided by High-Order Component.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Pivot
        abstract className: string option with get, set
        /// The index of the pivot item initially selected.
        /// 
        /// It only works when initialSelectedKey is not defined. You must not use them together.
        abstract initialSelectedIndex: float option with get, set
        /// The key of the pivot item initially selected.
        /// 
        /// It will make initialSelectedIndex not work. You must not use them together.
        abstract initialSelectedKey: string option with get, set
        /// The key of the selected pivot item.
        /// 
        /// If set, this will override the Pivot's selected item state.
        abstract selectedKey: string option with get, set
        /// Callback issued when the selected pivot item is changed
        abstract onLinkClick: (PivotItem -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        /// Specify the PivotLinkSize to use (normal, large)
        abstract linkSize: PivotLinkSize option with get, set
        /// Specify the PivotLinkFormat to use (links, tabs)
        abstract linkFormat: PivotLinkFormat option with get, set
        /// Specify whether to skip rendering the tabpanel with the content of the selected tab.
        /// Use this prop if you plan to separately render the tab content
        /// and don't want to leave an empty tabpanel in the page that may confuse Screen Readers.
        abstract headersOnly: bool option with get, set
        /// Optional. Specify how IDs are generated for each tab header.
        /// Useful if you're rendering content outside and need to connect aria-labelledby.
        abstract getTabId: (string -> float -> string) option with get, set

    type [<AllowNullLiteral>] IPivotStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        abstract linkIsSelected: bool option with get, set
        abstract linkIsDisabled: bool option with get, set
        abstract linkIsOverflow: bool option with get, set
        abstract rootIsLarge: bool option with get, set
        abstract rootIsTabs: bool option with get, set

    type [<AllowNullLiteral>] IPivotStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set
        abstract links: IStyle with get, set
        abstract link: IStyle with get, set
        abstract text: IStyle with get, set
        abstract count: IStyle with get, set
        abstract icon: IStyle with get, set
        abstract ellipsis: IStyle with get, set

    type [<RequireQualifiedAccess>] PivotLinkFormat =
        | Links = 0
        | Tabs = 1

    type [<RequireQualifiedAccess>] PivotLinkSize =
        | Normal = 0
        | Large = 1

module __components_Pivot_PivotItem =
    type BaseComponent = Utilities.BaseComponent
    type IPivotItemProps = __components_Pivot_PivotItem_types.IPivotItemProps

    type [<AllowNullLiteral>] IExports =
        abstract PivotItem: PivotItemStatic

    type [<AllowNullLiteral>] PivotItem =
        inherit BaseComponent<IPivotItemProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotItemStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotItem

module __components_Pivot_PivotItem_types =
    type IRenderFunction = Utilities.IRenderFunction
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IPivotItemProps =
        inherit React.HTMLAttributes<HTMLDivElement>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// The text displayed of each pivot link - renaming to 'headerText'.
        abstract linkText: string option with get, set
        /// The text displayed of each pivot link.
        abstract headerText: string option with get, set
        /// Props for the header command button supporting native props - data-* and aria-* - for each pivot header/link element
        abstract headerButtonProps: obj option with get, set
        /// An required key to uniquely identify a pivot item.
        /// 
        /// Note: The 'key' from react props cannot be used inside component.
        abstract itemKey: string option with get, set
        /// The aria label of each pivot link which will read by screen reader instead of linkText.
        /// 
        /// Note that unless you have compelling requirements you should not override aria-label.
        abstract ariaLabel: string option with get, set
        /// An optional item count that gets displayed just after the linkText(itemCount)
        /// 
        /// Example: completed(4)
        abstract itemCount: float option with get, set
        /// An optional icon to show next to the pivot link.
        abstract itemIcon: string option with get, set
        /// Optional custom renderer for the pivot item link
        abstract onRenderItemLink: IRenderFunction<IPivotItemProps> option with get, set
        /// Optional keytip for this PivotItem
        abstract keytipProps: IKeytipProps option with get, set

module __components_Pivot_PivotPage =
    type IComponentDemoPageProps = __components_Pivot_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract PivotPage: PivotPageStatic

    type [<AllowNullLiteral>] PivotPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotPage

module __components_Popup_Popup =
    type BaseComponent = Utilities.BaseComponent
    type IPopupProps = __components_Popup_Popup_types.IPopupProps

    type [<AllowNullLiteral>] IExports =
        abstract Popup: PopupStatic

    type [<AllowNullLiteral>] IPopupState =
        abstract needsVerticalScrollBar: bool option with get, set

    /// This adds accessibility to Dialog and Panel controls
    type [<AllowNullLiteral>] Popup =
        inherit BaseComponent<IPopupProps, IPopupState>
        abstract defaultProps: IPopupProps with get, set
        abstract _root: obj with get, set
        abstract _originalFocusedElement: obj with get, set
        abstract _containsFocus: obj with get, set
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _onKeyDown: obj with get, set
        abstract _updateScrollBarAsync: unit -> unit
        abstract _getScrollBar: unit -> unit
        abstract _onFocus: unit -> unit
        abstract _onBlur: ev: obj -> unit

    /// This adds accessibility to Dialog and Panel controls
    type [<AllowNullLiteral>] PopupStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPopupProps -> Popup

module __components_Popup_Popup_types =
    type Popup = __components_Popup_Popup.Popup

    type [<AllowNullLiteral>] IPopup =
        interface end

    type [<AllowNullLiteral>] IPopupProps =
        inherit React.HTMLAttributes<Popup>
        /// Optional callback to access the IPopup interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IPopup option -> unit) option with get, set
        /// Aria role for popup
        abstract role: string option with get, set
        /// Accessible label text for the popup.
        abstract ariaLabel: string option with get, set
        /// Defines the element id referencing the element containing label text for popup.
        abstract ariaLabelledBy: string option with get, set
        /// Defines the element id referencing the element containing the description for the popup.
        abstract ariaDescribedBy: string option with get, set
        /// A callback function for when the popup is dismissed from the close button or light dismiss. If provided, will
        /// handle escape keypresses and call this. The event will be stopped/canceled.
        abstract onDismiss: (U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> obj option) option with get, set
        /// Optional class name for the root popup div.
        abstract className: string option with get, set
        /// If true, the unmounting of this component will cause focus to be restored to the element that had focus when first mounted.
        abstract shouldRestoreFocus: bool option with get, set

module __components_ProgressIndicator_ProgressIndicator_base =
    type BaseComponent = Utilities.BaseComponent
    type IProgressIndicatorProps = __components_ProgressIndicator_ProgressIndicator_types.IProgressIndicatorProps

    type [<AllowNullLiteral>] IExports =
        abstract ProgressIndicatorBase: ProgressIndicatorBaseStatic

    /// ProgressIndicator with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] ProgressIndicatorBase =
        inherit BaseComponent<IProgressIndicatorProps, obj>
        abstract defaultProps: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onRenderProgress: obj with get, set

    /// ProgressIndicator with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] ProgressIndicatorBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IProgressIndicatorProps -> ProgressIndicatorBase

module __components_ProgressIndicator_ProgressIndicator_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ProgressIndicatorStatus: obj

module __components_ProgressIndicator_ProgressIndicator =
    type IProgressIndicatorProps = __components_ProgressIndicator_ProgressIndicator_types.IProgressIndicatorProps

    type [<AllowNullLiteral>] IExports =
        abstract ProgressIndicator: (IProgressIndicatorProps -> JSX.Element)

module __components_ProgressIndicator_ProgressIndicator_styles =
    type IProgressIndicatorStyleProps = __components_ProgressIndicator_ProgressIndicator_types.IProgressIndicatorStyleProps
    type IProgressIndicatorStyles = __components_ProgressIndicator_ProgressIndicator_types.IProgressIndicatorStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IProgressIndicatorStyleProps -> IProgressIndicatorStyles)

module __components_ProgressIndicator_ProgressIndicator_types =
    type ProgressIndicatorBase = __components_ProgressIndicator_ProgressIndicator_base.ProgressIndicatorBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction
    type IRenderFunction = Utilities.IRenderFunction

    type [<AllowNullLiteral>] IProgressIndicator =
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IProgressIndicatorProps =
        inherit React.Props<ProgressIndicatorBase>
        /// Gets the component ref.
        abstract componentRef: (IProgressIndicatorProps option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<IProgressIndicatorStyleProps, IProgressIndicatorStyles> option with get, set
        /// Theme provided by High-Order Component.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the ProgressIndicator
        abstract className: string option with get, set
        /// Label to display above the control. May be a string or React virtual elements.
        abstract label: React.ReactNode option with get, set
        /// Text describing or supplementing the operation. May be a string or React virtual elements.
        abstract description: React.ReactNode option with get, set
        /// Percentage of the operation's completeness. If this is not set, the indeterminate progress animation will be shown instead.
        abstract percentComplete: float option with get, set
        /// Whether or not to hide the progress state.
        abstract progressHidden: bool option with get, set
        /// A render override for the progress track.
        abstract onRenderProgress: IRenderFunction<IProgressIndicatorProps> option with get, set
        /// Text alternative of the progress status, used by screen readers for reading the value of the progress.
        abstract ariaValueText: string option with get, set
        /// Deprecated at v0.43.0, to be removed at >= v0.53.0. Use 'label' instead.
        abstract title: string option with get, set
        /// Height of the ProgressIndicator
        abstract barHeight: float option with get, set

    type [<AllowNullLiteral>] IProgressIndicatorStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        abstract indeterminate: bool option with get, set
        abstract barHeight: float option with get, set

    type [<AllowNullLiteral>] IProgressIndicatorStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set
        abstract itemName: IStyle with get, set
        abstract itemDescription: IStyle with get, set
        abstract itemProgress: IStyle with get, set
        abstract progressTrack: IStyle with get, set
        abstract progressBar: IStyle with get, set

module __components_ProgressIndicator_ProgressIndicatorPage =
    type IComponentDemoPageProps = __components_ProgressIndicator_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ProgressIndicatorPage: ProgressIndicatorPageStatic

    type [<AllowNullLiteral>] ProgressIndicatorPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ProgressIndicatorPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ProgressIndicatorPage

module __components_Rating_Rating_base =
    type BaseComponent = Utilities.BaseComponent
    type IRatingProps = __components_Rating_Rating_types.IRatingProps

    type [<AllowNullLiteral>] IExports =
        abstract RatingBase: RatingBaseStatic

    type [<AllowNullLiteral>] IRatingState =
        abstract rating: float option with get, set

    type [<AllowNullLiteral>] RatingBase =
        inherit BaseComponent<IRatingProps, IRatingState>
        abstract defaultProps: IRatingProps with get, set
        abstract _id: obj with get, set
        abstract _min: obj with get, set
        abstract _labelId: obj with get, set
        abstract _classNames: obj with get, set
        abstract componentWillReceiveProps: nextProps: IRatingProps -> unit
        abstract render: unit -> JSX.Element
        abstract _getStarId: index: obj -> unit
        abstract _onFocus: value: obj * ev: obj -> unit
        abstract _getLabel: rating: obj -> unit
        abstract _getInitialValue: props: obj -> unit
        abstract _getClampedRating: rating: obj -> unit
        abstract _getFillingPercentage: starPosition: obj -> unit

    type [<AllowNullLiteral>] RatingBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IRatingProps -> RatingBase

module __components_Rating_Rating_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract RatingStatus: obj

module __components_Rating_Rating =
    type IRatingProps = __components_Rating_Rating_types.IRatingProps

    type [<AllowNullLiteral>] IExports =
        abstract Rating: (IRatingProps -> JSX.Element)

module __components_Rating_Rating_styles =
    type IRatingStyleProps = __components_Rating_Rating_types.IRatingStyleProps
    type IRatingStyles = __components_Rating_Rating_types.IRatingStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: props: IRatingStyleProps -> IRatingStyles

module __components_Rating_Rating_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IRating =
        interface end

    /// Rating component props.
    type [<AllowNullLiteral>] IRatingProps =
        inherit React.AllHTMLAttributes<HTMLElement>
        /// Optional callback to access the IRating interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IRating option -> unit) option with get, set
        /// Selected rating, has to be an integer between min and max
        abstract rating: float option with get, set
        /// Minimum rating, defaults to 1, has to be >= 0
        abstract min: float option with get, set
        /// Maximum rating, defaults to 5, has to be >= min
        abstract max: float option with get, set
        /// Allow the rating value to be set to 0 instead of a minimum of 1.
        abstract allowZeroStars: bool option with get, set
        /// Custom icon, defaults to FavoriteStar
        abstract icon: string option with get, set
        /// Size of rating, defaults to small
        abstract size: RatingSize option with get, set
        /// Callback when the rating has changed
        abstract onChanged: (float -> unit) option with get, set
        /// Optional label format for star ratings, will be read by screen readers, defaults to ''.
        /// Can be used like "{0} of {1} stars selected".
        /// Where {0} will be subsituted by the current rating and {1} will be subsituted by the max rating.
        abstract ariaLabelFormat: string option with get, set
        /// Deprecated: Optional id of label describing this instance of Rating. Instead of this use getArialabel
        abstract ariaLabelId: string option with get, set
        /// Optional flag to mark rating control as readOnly
        abstract readOnly: bool option with get, set
        abstract getAriaLabel: (float -> float -> string) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<IRatingStyleProps, IRatingStyles> option with get, set
        /// Theme (provided through customization.)
        abstract theme: ITheme option with get, set

    type [<RequireQualifiedAccess>] RatingSize =
        | Small = 0
        | Large = 1

    type [<AllowNullLiteral>] IRatingStyleProps =
        abstract disabled: bool option with get, set
        abstract readOnly: bool option with get, set
        abstract theme: ITheme with get, set

    type [<AllowNullLiteral>] IRatingStyles =
        abstract root: IStyle with get, set
        abstract ratingStar: IStyle with get, set
        abstract ratingStarBack: IStyle with get, set
        abstract ratingStarFront: IStyle with get, set
        abstract ratingButton: IStyle with get, set
        abstract ratingStarIsSmall: IStyle with get, set
        abstract ratingStarIsLarge: IStyle with get, set
        abstract rootIsSmall: IStyle with get, set
        abstract rootIsLarge: IStyle with get, set
        abstract labelText: IStyle with get, set
        abstract ratingFocusZone: IStyle with get, set

module __components_Rating_RatingPage =
    type IComponentDemoPageProps = __components_Rating_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract RatingPage: RatingPageStatic

    type [<AllowNullLiteral>] RatingPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] RatingPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> RatingPage

module __components_ResizeGroup_ResizeGroup_base =
    type BaseComponent = Utilities.BaseComponent
    type IResizeGroupProps = __components_ResizeGroup_ResizeGroup_types.IResizeGroupProps

    type [<AllowNullLiteral>] IExports =
        abstract getMeasurementCache: (unit -> obj)
        abstract getNextResizeGroupStateProvider: (obj -> obj)
        abstract ResizeGroupBase: ResizeGroupBaseStatic

    type [<AllowNullLiteral>] IResizeGroupState =
        /// Final data used to render proper sized component
        abstract renderedData: obj option with get, set
        /// Data to render in a hidden div for measurement
        abstract dataToMeasure: obj option with get, set
        /// Set to true when the content container might have new dimensions and should
        /// be remeasured.
        abstract measureContainer: bool option with get, set
        /// Are we resizing to accommodate having more or less available space?
        /// The 'grow' direction is when the container may have more room than the last render,
        /// such as when a window resize occurs. This means we will try to fit more content in the window.
        /// The 'shrink' direction is when the contents don't fit in the container and we need
        /// to find a transformation of the data that makes everything fit.
        abstract resizeDirection: U2<string, string> option with get, set

    type [<AllowNullLiteral>] ResizeGroupBase =
        inherit BaseComponent<IResizeGroupProps, IResizeGroupState>
        abstract _nextResizeGroupStateProvider: obj with get, set
        abstract _root: obj with get, set
        abstract _measured: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: nextProps: IResizeGroupProps -> unit
        abstract componentDidUpdate: prevProps: IResizeGroupProps -> unit
        abstract remeasure: unit -> unit
        abstract _afterComponentRendered: unit -> unit
        abstract _onResize: unit -> unit

    type [<AllowNullLiteral>] ResizeGroupBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IResizeGroupProps -> ResizeGroupBase

module __components_ResizeGroup_ResizeGroup_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ResizeGroupStatus: obj

module __components_ResizeGroup_ResizeGroup =
    type IResizeGroupProps = __components_ResizeGroup_ResizeGroup_types.IResizeGroupProps

    type [<AllowNullLiteral>] IExports =
        abstract ResizeGroup: (IResizeGroupProps -> JSX.Element)

module __components_ResizeGroup_ResizeGroup_styles =
    type IResizeGroupStyleProps = __components_ResizeGroup_ResizeGroup_types.IResizeGroupStyleProps
    type IResizeGroupStyles = __components_ResizeGroup_ResizeGroup_types.IResizeGroupStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IResizeGroupStyleProps -> IResizeGroupStyles)

module __components_ResizeGroup_ResizeGroup_types =
    type ResizeGroupBase = __components_ResizeGroup_ResizeGroup_base.ResizeGroupBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IResizeGroup =
        /// Remeasures the available space.
        abstract remeasure: unit -> unit

    type [<AllowNullLiteral>] IResizeGroupProps =
        inherit React.HTMLAttributes<U2<ResizeGroupBase, HTMLElement>>
        /// Optional callback to access the IResizeGroup interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IResizeGroup option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IResizeGroupStyleProps, IResizeGroupStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the Component
        abstract className: string option with get, set
        /// Initial data to be passed to the onRenderData function. When there is no onGrowData provided, this data should represent what should
        /// be passed to the render function when the parent container of the ResizeGroup is at it's maximum supported width. A cacheKey property
        /// may optionally be included as part of the data. Two data objects with the same cacheKey will be assumed to take up the
        /// same width and will prevent measurements. The type of cacheKey is a string.
        abstract data: obj option with get, set
        /// Function to render the data. Called when rendering the contents to the screen and when
        /// rendering in a hidden div to measure the size of the contents.
        abstract onRenderData: (obj option -> JSX.Element) with get, set
        /// Function to be performed on the data in order to reduce its width and make it fit into the given space.
        /// If there are no more scaling steps to apply, it should return undefined to prevent
        /// an infinite render loop.
        abstract onReduceData: (obj option -> obj option) with get, set
        /// Function to be performed on the data in order to increase its width. It is called in scenarios where the
        /// container has more room than the previous render and we may be able to fit more content. If there are no more
        /// scaling operations to perform on teh data, it should return undefined to prevent an infinite render loop.
        abstract onGrowData: (obj option -> obj option) option with get, set
        /// Function to be called every time data is rendered. It provides the data that was actually rendered.
        /// A use case would be adding telemetry when a particular control is shown in an overflow well or
        /// dropped as a result of onReduceData or to count the number of renders that an implementation of
        /// onReduceData triggers.
        abstract dataDidRender: (obj option -> unit) option with get, set

    type [<AllowNullLiteral>] IResizeGroupStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IResizeGroupStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set

module __components_ResizeGroup_ResizeGroupPage =
    type IComponentDemoPageProps = __components_ResizeGroup_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ResizeGroupPage: ResizeGroupPageStatic

    type [<AllowNullLiteral>] ResizeGroupPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ResizeGroupPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ResizeGroupPage

module __components_ScrollablePane_ScrollablePane_base =
    module PropTypes = Prop_types
    type BaseComponent = Utilities.BaseComponent
    type IScrollablePane = __components_ScrollablePane_ScrollablePane_types.IScrollablePane
    type IScrollablePaneProps = __components_ScrollablePane_ScrollablePane_types.IScrollablePaneProps
    type Sticky = Sticky.Sticky

    type [<AllowNullLiteral>] IExports =
        abstract ScrollablePaneBase: ScrollablePaneBaseStatic

    type [<AllowNullLiteral>] IScrollablePaneContext =
        abstract scrollablePane: PropTypes.Requireable<obj> with get, set

    type [<AllowNullLiteral>] IScrollablePaneState =
        abstract stickyTopHeight: float with get, set
        abstract stickyBottomHeight: float with get, set

    type [<AllowNullLiteral>] ScrollablePaneBase =
        inherit BaseComponent<IScrollablePaneProps, IScrollablePaneState>
        inherit IScrollablePane
        abstract childContextTypes: React.ValidationMap<IScrollablePaneContext> with get, set
        abstract _root: obj with get, set
        abstract _stickyAboveRef: obj with get, set
        abstract _stickyBelowRef: obj with get, set
        abstract _contentContainer: obj with get, set
        abstract _subscribers: obj with get, set
        abstract _stickies: obj with get, set
        abstract _mutationObserver: obj with get, set
        abstract root: HTMLDivElement option
        abstract stickyAbove: HTMLDivElement option
        abstract stickyBelow: HTMLDivElement option
        abstract contentContainer: HTMLDivElement option
        abstract getChildContext: unit -> obj
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract shouldComponentUpdate: nextProps: IScrollablePaneProps * nextState: IScrollablePaneState -> bool
        abstract componentDidUpdate: prevProps: IScrollablePaneProps * prevState: IScrollablePaneState -> unit
        abstract render: unit -> JSX.Element
        abstract setStickiesDistanceFromTop: unit -> unit
        abstract forceLayoutUpdate: unit -> unit
        abstract subscribe: (Function -> unit) with get, set
        abstract unsubscribe: (Function -> unit) with get, set
        abstract addSticky: (Sticky -> unit) with get, set
        abstract removeSticky: (Sticky -> unit) with get, set
        abstract sortSticky: (Sticky -> unit) with get, set
        abstract updateStickyRefHeights: (unit -> unit) with get, set
        abstract notifySubscribers: (unit -> unit) with get, set
        abstract getScrollPosition: (unit -> float) with get, set
        abstract _checkStickyStatus: sticky: obj -> unit
        abstract _addToStickyContainer: obj with get, set
        abstract _removeStickyFromContainers: obj with get, set
        abstract _onWindowResize: obj with get, set
        abstract _getStickyContainerStyle: obj with get, set

    type [<AllowNullLiteral>] ScrollablePaneBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IScrollablePaneProps -> ScrollablePaneBase

module __components_ScrollablePane_ScrollablePane_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ScrollablePaneStatus: obj

module __components_ScrollablePane_ScrollablePane =
    type IScrollablePaneProps = __components_ScrollablePane_ScrollablePane_types.IScrollablePaneProps

    type [<AllowNullLiteral>] IExports =
        abstract ScrollablePane: (IScrollablePaneProps -> JSX.Element)

module __components_ScrollablePane_ScrollablePane_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract stickyAbove: obj
        abstract stickyBelow: obj

module __components_ScrollablePane_ScrollablePane_styles =
    type IScrollablePaneStyleProps = __components_ScrollablePane_ScrollablePane_types.IScrollablePaneStyleProps
    type IScrollablePaneStyles = __components_ScrollablePane_ScrollablePane_types.IScrollablePaneStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IScrollablePaneStyleProps -> IScrollablePaneStyles)

module __components_ScrollablePane_ScrollablePane_types =
    type ScrollablePaneBase = __components_ScrollablePane_ScrollablePane_base.ScrollablePaneBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IScrollablePane =
        /// Triggers a layout update for the pane. 
        abstract forceLayoutUpdate: unit -> unit
        /// Gets the current scroll position of the scrollable pane 
        abstract getScrollPosition: unit -> float

    type [<AllowNullLiteral>] IScrollablePaneProps =
        inherit React.HTMLAttributes<U2<HTMLElement, ScrollablePaneBase>>
        /// Optional callback to access the IScrollablePane interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IScrollablePane option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules
        abstract getStyles: IStyleFunction<IScrollablePaneStyleProps, IScrollablePaneStyles> option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Additional css class to apply to the ScrollablePane
        abstract className: string option with get, set
        /// Sets the initial scroll position of the ScrollablePane
        abstract initialScrollPosition: float option with get, set

    type [<AllowNullLiteral>] IScrollablePaneStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set

    type [<AllowNullLiteral>] IScrollablePaneStyles =
        /// Style set for the root element.
        abstract root: IStyle with get, set
        /// Style set for the stickyAbove element.
        abstract stickyAbove: IStyle with get, set
        /// Style set for the stickyAbove element.
        abstract stickyBelow: IStyle with get, set
        /// Style set for the stickyBelowItems element.
        abstract stickyBelowItems: IStyle with get, set
        /// Style set for the contentContainer element.
        abstract contentContainer: IStyle with get, set

module __components_ScrollablePane_ScrollablePanePage =
    type IComponentDemoPageProps = __components_ScrollablePane_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ScrollablePanePage: ScrollablePanePageStatic

    type [<AllowNullLiteral>] ScrollablePanePage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ScrollablePanePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ScrollablePanePage

module __components_SearchBox_SearchBox_base =
    type ISearchBoxProps = __components_SearchBox_SearchBox_types.ISearchBoxProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxBase: SearchBoxBaseStatic

    type [<AllowNullLiteral>] ISearchBoxState =
        abstract value: string option with get, set
        abstract hasFocus: bool option with get, set
        abstract id: string option with get, set

    type [<AllowNullLiteral>] SearchBoxBase =
        inherit BaseComponent<ISearchBoxProps, ISearchBoxState>
        abstract defaultProps: ISearchBoxProps with get, set
        abstract _rootElement: obj with get, set
        abstract _inputElement: obj with get, set
        abstract _latestValue: obj with get, set
        abstract componentWillReceiveProps: newProps: ISearchBoxProps -> unit
        abstract render: unit -> JSX.Element
        /// Sets focus to the search box input field
        abstract focus: unit -> unit
        /// Returns whether or not the SearchBox has focus
        abstract hasFocus: unit -> bool
        abstract _onClear: ev: obj -> unit
        abstract _onClickFocus: obj with get, set
        abstract _onFocusCapture: obj with get, set
        abstract _onClearClick: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onBlur: obj with get, set
        abstract _onInputChange: obj with get, set
        abstract _callOnChange: newValue: obj -> unit

    type [<AllowNullLiteral>] SearchBoxBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ISearchBoxProps -> SearchBoxBase

module __components_SearchBox_SearchBox_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxStatus: obj

module __components_SearchBox_SearchBox =
    type ISearchBoxProps = __components_SearchBox_SearchBox_types.ISearchBoxProps

    type [<AllowNullLiteral>] IExports =
        abstract SearchBox: (ISearchBoxProps -> JSX.Element)

module __components_SearchBox_SearchBox_styles =
    type ISearchBoxStyleProps = __components_SearchBox_SearchBox_types.ISearchBoxStyleProps
    type ISearchBoxStyles = __components_SearchBox_SearchBox_types.ISearchBoxStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: props: ISearchBoxStyleProps -> ISearchBoxStyles

module __components_SearchBox_SearchBox_types =
    type ITheme = Styling.ITheme
    type IStyle = Styling.IStyle
    type IStyleFunction = Utilities.IStyleFunction
    type IButtonProps = __components_Button.IButtonProps

    type [<AllowNullLiteral>] ISearchBox =
        /// Sets focus inside the search input box.
        abstract focus: unit -> unit
        /// Returns whether or not the SearchBox has focus
        abstract hasFocus: unit -> bool

    type [<AllowNullLiteral>] ISearchBoxProps =
        inherit React.InputHTMLAttributes<HTMLInputElement>
        /// Optional callback to access the ISearchBox interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ISearchBox option -> unit) option with get, set
        /// Placeholder for the search box.
        abstract placeholder: string option with get, set
        /// Deprecated. Use placeholder instead.
        abstract labelText: string option with get, set
        /// Callback function for when the typed input for the SearchBox has changed.
        abstract onChange: (obj option -> unit) option with get, set
        /// Callback executed when the user presses enter in the search box.
        abstract onSearch: (obj option -> unit) option with get, set
        /// Callback executed when the user clears the search box by either clicking 'X' or hitting escape.
        abstract onClear: (obj option -> unit) option with get, set
        /// Callback executed when the user presses escape in the search box.
        abstract onEscape: (obj option -> unit) option with get, set
        /// Deprecated at v0.52.2, use 'onChange' instead.
        abstract onChanged: (obj option -> unit) option with get, set
        /// The value of the text in the SearchBox.
        abstract value: string option with get, set
        /// The default value of the text in the SearchBox, in the case of an uncontrolled component.
        /// Up till now, this has not been implemented, deprecating. Will re-implement if uncontrolled
        /// component behavior is implemented.
        abstract defaultValue: string option with get, set
        /// CSS class to apply to the SearchBox.
        abstract className: string option with get, set
        /// The aria label of the SearchBox for the benefit of screen readers.
        abstract ariaLabel: string option with get, set
        /// The props for the clear button.
        abstract clearButtonProps: IButtonProps option with get, set
        /// Whether or not the SearchBox is underlined.
        abstract underlined: bool option with get, set
        /// Theme (provided through customization.)
        abstract theme: ITheme option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<ISearchBoxStyleProps, ISearchBoxStyles> option with get, set
        /// Whether or not to animate the SearchBox icon on focus.
        abstract disableAnimation: bool option with get, set

    type [<AllowNullLiteral>] ISearchBoxStyleProps =
        abstract theme: ITheme with get, set
        abstract className: string option with get, set
        abstract disabled: bool option with get, set
        abstract hasFocus: bool option with get, set
        abstract underlined: bool option with get, set
        abstract hasInput: bool option with get, set
        abstract disableAnimation: bool option with get, set

    type [<AllowNullLiteral>] ISearchBoxStyles =
        abstract root: IStyle option with get, set
        abstract iconContainer: IStyle option with get, set
        abstract icon: IStyle option with get, set
        abstract field: IStyle option with get, set
        abstract clearButton: IStyle option with get, set

module __components_SearchBox_SearchBoxPage =
    type IComponentDemoPageProps = __components_SearchBox_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxPage: SearchBoxPageStatic

    type [<AllowNullLiteral>] SearchBoxPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SearchBoxPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SearchBoxPage

module __components_SelectedItemsList_BaseSelectedItemsList =
    type BaseComponent = Utilities.BaseComponent
    type Selection = Selection.Selection
    type IBaseSelectedItemsList = __components_SelectedItemsList_BaseSelectedItemsList_types.IBaseSelectedItemsList
    type IBaseSelectedItemsListProps = __components_SelectedItemsList_BaseSelectedItemsList_types.IBaseSelectedItemsListProps
    type ISelectedItemProps = __components_SelectedItemsList_BaseSelectedItemsList_types.ISelectedItemProps

    type [<AllowNullLiteral>] IExports =
        abstract BaseSelectedItemsList: BaseSelectedItemsListStatic

    type [<AllowNullLiteral>] IBaseSelectedItemsListState =
        abstract items: obj option with get, set
        abstract suggestedDisplayValue: string option with get, set
        abstract moreSuggestionsAvailable: bool option with get, set
        abstract isSearching: bool option with get, set
        abstract isMostRecentlyUsedVisible: bool option with get, set
        abstract suggestionsVisible: bool option with get, set
        abstract suggestionsLoading: bool option with get, set
        abstract isResultsFooterVisible: bool option with get, set

    type [<AllowNullLiteral>] BaseSelectedItemsList<'T, 'P> =
        inherit BaseComponent<'P, IBaseSelectedItemsListState>
        inherit IBaseSelectedItemsList<'T>
        abstract root: HTMLElement with get, set
        abstract selection: Selection with get, set
        abstract items: ResizeArray<'T>
        abstract addItems: (ResizeArray<'T> -> unit) with get, set
        abstract removeItemAt: (float -> unit) with get, set
        abstract removeItem: (ISelectedItemProps<'T> -> unit) with get, set
        abstract removeItems: (ResizeArray<obj option> -> unit) with get, set
        /// Controls what happens whenever there is an action that impacts the selected items.
        /// If selectedItems is provided as a property then this will act as a controlled component and it will not update it's own state.
        abstract updateItems: items: ResizeArray<'T> * ?focusIndex: float -> unit
        abstract onCopy: (React.ClipboardEvent<HTMLElement> -> unit) with get, set
        abstract unselectAll: unit -> unit
        abstract componentWillUpdate: newProps: 'P * newState: IBaseSelectedItemsListState -> unit
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: 'P -> unit
        abstract render: unit -> obj option
        abstract renderItems: (unit -> ResizeArray<JSX.Element>) with get, set
        abstract onSelectionChanged: (unit -> unit) with get, set
        abstract onChange: ?items: ResizeArray<'T> -> unit
        abstract onKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
        abstract onItemChange: ('T -> float -> unit) with get, set
        abstract onBackspace: ev: React.KeyboardEvent<HTMLElement> -> unit
        abstract copyItems: items: ResizeArray<'T> -> unit
        abstract _isFocusZoneInnerKeystroke: ev: React.KeyboardEvent<HTMLElement> -> bool
        abstract _onSelectedItemsUpdated: ?items: obj * ?focusIndex: obj -> unit

    type [<AllowNullLiteral>] BaseSelectedItemsListStatic =
        [<Emit "new $0($1...)">] abstract Create: basePickerProps: 'P -> BaseSelectedItemsList<'T, 'P>

module __components_SelectedItemsList_BaseSelectedItemsList_types =
    type IPickerItemProps = Pickers.IPickerItemProps
    type ISuggestionModel = Pickers.ISuggestionModel
    type ValidationState = Pickers.ValidationState
    type Selection = Selection.Selection

    type [<AllowNullLiteral>] IBaseSelectedItemsList<'T> =
        /// Gets the current value of the input. 
        abstract items: ResizeArray<'T> option with get, set
        abstract addItems: (ResizeArray<'T> -> unit) with get, set

    type [<AllowNullLiteral>] ISelectedItemProps<'T> =
        inherit IPickerItemProps<'T>
        abstract onCopyItem: ('T -> unit) with get, set

    type [<AllowNullLiteral>] IBaseSelectedItemsListProps<'T> =
        inherit React.Props<obj option>
        abstract componentRef: (IBaseSelectedItemsList<'T> option -> unit) option with get, set
        /// The selection
        abstract selection: Selection option with get, set
        /// A callback for when items are copied
        abstract onCopyItems: (ResizeArray<'T> -> string) option with get, set
        /// Function that specifies how the selected item will appear.
        abstract onRenderItem: (ISelectedItemProps<'T> -> JSX.Element) option with get, set
        /// Initial items that have already been selected and should appear in the people picker.
        abstract defaultSelectedItems: ResizeArray<'T> option with get, set
        /// A callback for when the selected list of items changes.
        abstract onChange: (ResizeArray<'T> -> unit) option with get, set
        /// ClassName for the picker.
        abstract className: string option with get, set
        /// Function that specifies how arbitrary text entered into the well is handled.
        abstract createGenericItem: (string -> ValidationState -> ISuggestionModel<'T>) option with get, set
        /// A callback to process a selection after the user selects something from the picker.
        abstract onItemSelected: ('T -> U2<'T, PromiseLike<'T>>) option with get, set
        /// The items that the base picker should currently display as selected. If this is provided then the picker will act as a
        /// controlled component.
        abstract selectedItems: ResizeArray<'T> option with get, set
        /// Aria label for the 'X' button in the selected item component.
        abstract removeButtonAriaLabel: string option with get, set
        /// A callback when and item is deleted
        abstract onItemDeleted: ('T -> unit) option with get, set

module __components_Slider_Slider_base =
    type BaseComponent = Utilities.BaseComponent
    type ISliderProps = __components_Slider_Slider_types.ISliderProps
    type ISlider = __components_Slider_Slider_types.ISlider

    type [<AllowNullLiteral>] IExports =
        abstract SliderBase: SliderBaseStatic

    type [<AllowNullLiteral>] ISliderState =
        abstract value: float option with get, set
        abstract renderedValue: float option with get, set

    type [<RequireQualifiedAccess>] ValuePosition =
        | Previous = 0
        | Next = 1

    type [<AllowNullLiteral>] SliderBase =
        inherit BaseComponent<ISliderProps, ISliderState>
        inherit ISlider
        abstract defaultProps: ISliderProps with get, set
        abstract _sliderLine: obj with get, set
        abstract _thumb: obj with get, set
        abstract _id: obj with get, set
        /// Invoked when a component is receiving new props. This method is not called for the initial render.
        abstract componentWillReceiveProps: newProps: ISliderProps -> unit
        abstract render: unit -> React.ReactElement<obj>
        abstract focus: unit -> unit
        abstract value: float option
        abstract _getAriaValueText: obj with get, set
        abstract _getThumbStyle: vertical: obj * thumbOffsetPercent: obj -> unit
        abstract _onMouseDownOrTouchStart: obj with get, set
        abstract _onMouseMoveOrTouchMove: obj with get, set
        abstract _getPosition: ``event``: obj * vertical: obj -> unit
        abstract _updateValue: value: obj * renderedValue: obj -> unit
        abstract _onMouseUpOrTouchEnd: obj with get, set
        abstract _onKeyDown: obj with get, set

    type [<AllowNullLiteral>] SliderBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ISliderProps -> SliderBase

module __components_Slider_Slider_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract SliderStatus: obj

module __components_Slider_Slider =
    type ISliderProps = __components_Slider_Slider_types.ISliderProps

    type [<AllowNullLiteral>] IExports =
        abstract Slider: (ISliderProps -> JSX.Element)

module __components_Slider_Slider_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract titleLabel: obj
        abstract line: obj
        abstract lineContainer: obj
        abstract container: obj
        abstract valueLabel: obj
        abstract slideBox: obj
        abstract thumb: obj
        abstract rootIsHorizontal: obj
        abstract rootIsVertical: obj
        abstract activeSection: obj
        abstract inactiveSection: obj
        abstract showTransitions: obj
        abstract rootIsEnabled: obj
        abstract rootIsDisabled: obj

module __components_Slider_Slider_styles =
    type ISliderStyleProps = __components_Slider_Slider_types.ISliderStyleProps
    type ISliderStyles = __components_Slider_Slider_types.ISliderStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ISliderStyleProps -> ISliderStyles)

module __components_Slider_Slider_types =
    type SliderBase = __components_Slider_Slider_base.SliderBase
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] ISlider =
        abstract value: float option with get, set
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] ISliderProps =
        inherit React.Props<SliderBase>
        /// Optional callback to access the ISlider interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ISlider option -> unit) option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<ISliderStyleProps, ISliderStyles> option with get, set
        /// Theme provided by High-Order Component.
        abstract theme: ITheme option with get, set
        /// Description label of the Slider
        abstract label: string option with get, set
        /// The initial value of the Slider. Use this if you intend for the Slider to be an uncontrolled component.
        /// This value is mutually exclusive to value. Use one or the other.
        abstract defaultValue: float option with get, set
        /// The initial value of the Slider. Use this if you intend to pass in a new value as a result of onChange events.
        /// This value is mutually exclusive to defaultValue. Use one or the other.
        abstract value: float option with get, set
        /// The min value of the Slider
        abstract min: float option with get, set
        /// The max value of the Slider
        abstract max: float option with get, set
        /// The difference between the two adjacent values of the Slider
        abstract step: float option with get, set
        /// Whether to show the value on the right of the Slider.
        abstract showValue: bool option with get, set
        /// Callback when the value has been changed
        abstract onChange: (float -> unit) option with get, set
        /// A description of the Slider for the benefit of screen readers.
        abstract ariaLabel: string option with get, set
        /// A text description of the Slider number value for the benefit of screen readers. This should be used when the Slider number value is not accurately represented by a number.
        abstract ariaValueText: (float -> string) option with get, set
        /// Optional flag to render the slider vertically. Defaults to rendering horizontal.
        abstract vertical: bool option with get, set
        /// Optional flag to render the Slider as disabled.
        abstract disabled: bool option with get, set
        /// Optional className to attach to the slider root element.
        abstract className: string option with get, set
        /// Optional mixin for additional props on the thumb button within the slider.
        abstract buttonProps: React.HTMLAttributes<HTMLButtonElement> option with get, set

    type [<AllowNullLiteral>] ISliderStyleProps =
        /// Theme provided by High-Order Component.
        abstract theme: ITheme with get, set
        /// Accept custom classNames.
        abstract className: string option with get, set
        abstract titleLabel: string option with get, set
        abstract rootIsEnabled: bool option with get, set
        abstract rootIsDisabled: bool option with get, set
        abstract rootIsHorizontal: bool option with get, set
        abstract rootIsVertical: bool option with get, set
        abstract showTransitions: bool option with get, set

    type [<AllowNullLiteral>] ISliderStyles =
        abstract root: IStyle with get, set
        abstract container: IStyle with get, set
        abstract slideBox: IStyle with get, set
        abstract line: IStyle with get, set
        abstract thumb: IStyle with get, set
        abstract lineContainer: IStyle with get, set
        abstract activeSection: IStyle with get, set
        abstract inactiveSection: IStyle with get, set
        abstract valueLabel: IStyle with get, set

module __components_Slider_SliderPage =
    type IComponentDemoPageProps = __components_Slider_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SliderPage: SliderPageStatic

    type [<AllowNullLiteral>] SliderPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SliderPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SliderPage

module __components_SpinButton_SpinButton_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonStatus: obj

module __components_SpinButton_SpinButton_classNames =
    type ISpinButtonStyles = __components_SpinButton_SpinButton_types.ISpinButtonStyles
    type KeyboardSpinDirection = __components_SpinButton_SpinButton.KeyboardSpinDirection
    type Position = __utilities_positioning.Position

    type [<AllowNullLiteral>] IExports =
        abstract getClassNames: (ISpinButtonStyles -> bool -> bool -> KeyboardSpinDirection -> Position -> ISpinButtonClassNames)

    type [<AllowNullLiteral>] ISpinButtonClassNames =
        abstract root: string with get, set
        abstract labelWrapper: string with get, set
        abstract icon: string with get, set
        abstract label: string with get, set
        abstract spinButtonWrapper: string with get, set
        abstract input: string with get, set
        abstract arrowBox: string with get, set

module __components_SpinButton_SpinButton =
    type BaseComponent = Utilities.BaseComponent
    type ISpinButton = __components_SpinButton_SpinButton_types.ISpinButton
    type ISpinButtonProps = __components_SpinButton_SpinButton_types.ISpinButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract SpinButton: SpinButtonStatic

    type [<RequireQualifiedAccess>] KeyboardSpinDirection =
        | Down = -1
        | NotSpinning = 0
        | Up = 1

    type [<AllowNullLiteral>] ISpinButtonState =
        /// Is true when the control has focus.
        abstract isFocused: bool with get, set
        /// the value of the spin button
        abstract value: string with get, set
        /// keyboard spin direction, used to style the up or down button
        /// as active when up/down arrow is pressed
        abstract keyboardSpinDirection: KeyboardSpinDirection with get, set
        /// The calculated precision for the value.
        abstract precision: float with get, set

    type [<AllowNullLiteral>] SpinButton =
        inherit BaseComponent<ISpinButtonProps, ISpinButtonState>
        inherit ISpinButton
        abstract defaultProps: ISpinButtonProps with get, set
        abstract _input: obj with get, set
        abstract _inputId: obj with get, set
        abstract _labelId: obj with get, set
        abstract _lastValidValue: obj with get, set
        abstract _spinningByMouse: obj with get, set
        abstract _onValidate: obj option with get, set
        abstract _onIncrement: obj option with get, set
        abstract _onDecrement: obj option with get, set
        abstract _currentStepFunctionHandle: obj with get, set
        abstract _initialStepDelay: obj with get, set
        abstract _stepDelay: obj with get, set
        /// Invoked when a component is receiving new props. This method is not called for the initial render.
        abstract componentWillReceiveProps: newProps: ISpinButtonProps -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _onFocus: obj with get, set
        abstract _onBlur: obj with get, set
        /// Gets the value of the spin button.
        abstract value: string option
        /// Validate function to use if one is not passed in
        abstract _defaultOnValidate: obj with get, set
        /// Increment function to use if one is not passed in
        abstract _defaultOnIncrement: obj with get, set
        /// Increment function to use if one is not passed in
        abstract _defaultOnDecrement: obj with get, set
        abstract _onChange: unit -> unit
        /// This is used when validating text entry
        /// in the input (not when changed via the buttons)
        abstract _validate: obj with get, set
        /// The method is needed to ensure we are updating the actual input value.
        /// without this our value will never change (and validation will not have the correct number)
        abstract _onInputChange: obj with get, set
        /// Update the value with the given stepFunction
        abstract _updateValue: obj with get, set
        /// Stop spinning (clear any currently pending update and set spinning to false)
        abstract _stop: obj with get, set
        /// Handle keydown on the text field. We need to update
        /// the value when up or down arrow are depressed
        abstract _handleKeyDown: obj with get, set
        /// Make sure that we have stopped spinning on keyUp
        /// if the up or down arrow fired this event
        abstract _handleKeyUp: obj with get, set
        abstract _onIncrementMouseDown: obj with get, set
        abstract _onDecrementMouseDown: obj with get, set

    type [<AllowNullLiteral>] SpinButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ISpinButtonProps -> SpinButton

module __components_SpinButton_SpinButton_styles =
    type ITheme = Styling.ITheme
    type IButtonStyles = Button.IButtonStyles
    type ISpinButtonStyles = __components_SpinButton_SpinButton_types.ISpinButtonStyles

    type [<AllowNullLiteral>] IExports =
        abstract getArrowButtonStyles: (ITheme -> bool -> obj option -> IButtonStyles)
        abstract getStyles: (ITheme -> obj option -> ISpinButtonStyles)

module __components_SpinButton_SpinButton_types =
    type Position = __utilities_positioning.Position
    type IIconProps = Icon.IIconProps
    type ITheme = Styling.ITheme
    type IStyle = Styling.IStyle
    type ISpinButtonClassNames = __components_SpinButton_SpinButton_classNames.ISpinButtonClassNames
    type KeyboardSpinDirection = __components_SpinButton_SpinButton.KeyboardSpinDirection
    type IButtonStyles = Button.IButtonStyles
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] ISpinButton =
        /// The value of the SpinButton. Use this if you intend to pass in a new value as a result of onChange events.
        /// This value is mutually exclusive to defaultValue. Use one or the other.
        abstract value: string option with get, set
        /// Sets focus to the spin button.
        abstract focus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] ISpinButtonProps =
        /// Gets the component ref.
        abstract componentRef: (ISpinButton option -> unit) option with get, set
        /// The initial value of the SpinButton. Use this if you intend for the SpinButton to be an uncontrolled component.
        /// This value is mutually exclusive to value. Use one or the other.
        abstract defaultValue: string option with get, set
        /// The value of the SpinButton. Use this if you intend to pass in a new value as a result of onChange events.
        /// This value is mutually exclusive to defaultValue. Use one or the other.
        abstract value: string option with get, set
        /// The min value of the SpinButton.
        abstract min: float option with get, set
        /// The max value of the SpinButton.
        abstract max: float option with get, set
        /// The difference between the two adjacent values of the SpinButton.
        /// This value is sued to calculate the precision of the input if no
        /// precision is given. The precision calculated this way will always
        /// be >= 0.
        abstract step: float option with get, set
        /// A description of the SpinButton for the benefit of screen readers.
        abstract ariaLabel: string option with get, set
        /// A title for the SpinButton used for a more descriptive name that's also visible on its tooltip.
        abstract title: string option with get, set
        /// Whether or not the SpinButton is disabled.
        abstract disabled: bool option with get, set
        /// Optional className for SpinButton.
        abstract className: string option with get, set
        /// Descriptive label for the SpinButton.
        abstract label: string with get, set
        abstract labelPosition: Position option with get, set
        /// Icon that goes along with the label for the whole SpinButton
        abstract iconProps: IIconProps option with get, set
        /// This callback is triggered when the value inside the SpinButton should be validated.
        abstract onValidate: (string -> U2<string, unit>) option with get, set
        /// This callback is triggered when the increment button is pressed or if the user presses up arrow with focus on the input of the spinButton
        abstract onIncrement: (string -> U2<string, unit>) option with get, set
        /// This callback is triggered when the decrement button is pressed or if the user presses down arrow with focus on the input of the spinButton
        abstract onDecrement: (string -> U2<string, unit>) option with get, set
        /// A callback for when the user put focus on the picker
        abstract onFocus: React.FocusEventHandler<HTMLInputElement> option with get, set
        /// A callback for when the user moves the focus away from the picker
        abstract onBlur: React.FocusEventHandler<HTMLInputElement> option with get, set
        /// Icon for the increment button of the spinButton
        abstract incrementButtonIcon: IIconProps option with get, set
        /// Icon for the decrement button of the spinButton
        abstract decrementButtonIcon: IIconProps option with get, set
        /// Custom styling for individual elements within the button DOM.
        abstract styles: obj option with get, set
        /// Custom function for providing the classNames for the spinbutton. Can be used to provide
        /// all styles for the component instead of applying them on top of the default styles.
        abstract getClassNames: (ITheme -> bool -> bool -> KeyboardSpinDirection -> Position -> ISpinButtonClassNames) option with get, set
        /// Custom styles for the upArrow button.
        /// 
        /// Note: The buttons are in a checked state when arrow keys are used to
        /// incremenent/decrement the spinButton. Use rootChecked instead of rootPressed
        /// for styling when that is the case.
        abstract upArrowButtonStyles: obj option with get, set
        /// Custom styles for the downArrow button.
        /// 
        /// Note: The buttons are in a checked state when arrow keys are used to
        /// incremenent/decrement the spinButton. Use rootChecked instead of rootPressed
        /// for styling when that is the case.
        abstract downArrowButtonStyles: obj option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Accessibile label text for the increment button for the benefit of the screen reader.
        abstract incrementButtonAriaLabel: string option with get, set
        /// Accessibile label text for the decrement button for the benefit of the screen reader.
        abstract decrementButtonAriaLabel: string option with get, set
        /// To how many decimal places the value should be rounded to.
        /// The default value is calculated based on the precision of step.
        /// IE: if step = 1, precision = 0. step = 0.0089, precision = 4. step = 300, precision = 2. step = 23.00, precision = 2.
        abstract precision: float option with get, set
        /// The position in the parent set (if in a set) for aria-posinset.
        abstract ariaPositionInSet: float option with get, set
        /// The total size of the parent set (if in a set) for aria-setsize.
        abstract ariaSetSize: float option with get, set
        /// Optional keytip for this spin button
        abstract keytipProps: IKeytipProps option with get, set

    type [<AllowNullLiteral>] ISpinButtonStyles =
        /// Styles for the root of the spin button component.
        abstract root: IStyle with get, set
        /// Style for the label wrapper element of the component
        /// The label wrapper contains the icon and the label.
        abstract labelWrapper: IStyle with get, set
        /// Style override when the label is positioned at the start.
        abstract labelWrapperStart: IStyle with get, set
        /// Style override when the label is positioned at the end.
        abstract labelWrapperEnd: IStyle with get, set
        /// Style override when the label is positioned at the top.
        abstract labelWrapperTop: IStyle with get, set
        /// Style override when the label is positioned at the bottom.
        abstract labelWrapperBottom: IStyle with get, set
        /// Style for the icon.
        abstract icon: IStyle with get, set
        /// Style for the icon.
        abstract iconDisabled: IStyle with get, set
        /// Style for the label text
        abstract label: IStyle with get, set
        /// Style for the label text
        abstract labelDisabled: IStyle with get, set
        /// Style for spinButtonWrapper when enabled.
        abstract spinButtonWrapper: IStyle with get, set
        /// Style override when label is positioned at the top/bottom.
        abstract spinButtonWrapperTopBottom: IStyle with get, set
        /// Style override when spinButton is enabled/hovered.
        abstract spinButtonWrapperHovered: IStyle with get, set
        /// Style override when spinButton is enabled/focused.
        abstract spinButtonWrapperFocused: IStyle with get, set
        /// Style override when spinButton is disabled.
        abstract spinButtonWrapperDisabled: IStyle with get, set
        /// Styles for the input.
        abstract input: IStyle with get, set
        /// Style override for ::selection
        abstract inputTextSelected: IStyle with get, set
        /// Style override when spinButton is disabled.
        abstract inputDisabled: IStyle with get, set
        /// Styles for the arrowButtonsContainer
        abstract arrowButtonsContainer: IStyle with get, set
        /// Style override for the arrowButtonsContainer when spin button is disabled.
        abstract arrowButtonsContainerDisabled: IStyle with get, set

module __components_SpinButton_SpinButtonPage =
    type IComponentDemoPageProps = __components_SpinButton_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonPage: SpinButtonPageStatic

    type [<AllowNullLiteral>] SpinButtonPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonPage

module __components_Spinner_interfaces =

    type [<RequireQualifiedAccess>] SpinnerType =
        | Normal = 0
        | Large = 1

    type [<RequireQualifiedAccess>] SpinnerSize =
        | XSmall = 0
        | Small = 1
        | Medium = 2
        | Large = 3

module __components_Spinner_Spinner_base =
    type ISpinnerProps = __components_Spinner_Spinner_types.ISpinnerProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract SpinnerBase: SpinnerBaseStatic

    type [<AllowNullLiteral>] SpinnerBase =
        inherit BaseComponent<ISpinnerProps, obj option>
        abstract defaultProps: ISpinnerProps with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinnerBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinnerBase

module __components_Spinner_Spinner_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract SpinnerStatus: obj

module __components_Spinner_Spinner =
    type ISpinnerProps = __components_Spinner_Spinner_types.ISpinnerProps

    type [<AllowNullLiteral>] IExports =
        abstract Spinner: (ISpinnerProps -> JSX.Element)

module __components_Spinner_Spinner_styles =
    type ISpinnerStyleProps = __components_Spinner_Spinner_types.ISpinnerStyleProps
    type ISpinnerStyles = __components_Spinner_Spinner_types.ISpinnerStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ISpinnerStyleProps -> ISpinnerStyles)

module __components_Spinner_Spinner_types =
    type ITheme = Styling.ITheme
    type IStyle = Styling.IStyle
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] ISpinner =
        interface end

    type [<AllowNullLiteral>] ISpinnerProps =
        inherit React.HTMLAttributes<HTMLElement>
        /// Optional callback to access the ISpinner interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ISpinner option -> unit) option with get, set
        /// Deprecated and will be removed at >= 2.0.0. Use SpinnerSize instead.
        abstract ``type``: SpinnerType option with get, set
        /// The size of Spinner to render. { extraSmall, small, medium, large }
        abstract size: SpinnerSize option with get, set
        /// The label to show next to the Spinner. Label updates will be announced to the screen readers.
        /// Use ariaLive to control politeness level.
        abstract label: string option with get, set
        /// Additional CSS class(es) to apply to the Spinner.
        abstract className: string option with get, set
        /// Politeness setting for label update announcement.
        abstract ariaLive: U3<string, string, string> option with get, set
        /// Alternative status label for screen reader
        abstract ariaLabel: string option with get, set
        /// Theme (provided through customization.)
        abstract theme: ITheme option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<ISpinnerStyleProps, ISpinnerStyles> option with get, set

    type [<RequireQualifiedAccess>] SpinnerSize =
        | XSmall = 0
        | Small = 1
        | Medium = 2
        | Large = 3

    type [<RequireQualifiedAccess>] SpinnerType =
        | Normal = 0
        | Large = 1

    type [<AllowNullLiteral>] ISpinnerStyleProps =
        abstract theme: ITheme with get, set
        abstract size: SpinnerSize option with get, set
        abstract className: string option with get, set

    type [<AllowNullLiteral>] ISpinnerStyles =
        abstract root: IStyle option with get, set
        abstract circle: IStyle option with get, set
        abstract label: IStyle option with get, set
        abstract screenReaderText: IStyle option with get, set

module __components_Spinner_SpinnerPage =
    type IComponentDemoPageProps = __components_Spinner_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SpinnerPage: SpinnerPageStatic

    type [<AllowNullLiteral>] SpinnerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinnerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinnerPage

module __components_Sticky_Sticky =
    module PropTypes = Prop_types
    type BaseComponent = Utilities.BaseComponent
    type IStickyProps = __components_Sticky_Sticky_types.IStickyProps

    type [<AllowNullLiteral>] IExports =
        abstract Sticky: StickyStatic

    type [<AllowNullLiteral>] IStickyState =
        abstract isStickyTop: bool with get, set
        abstract isStickyBottom: bool with get, set

    type [<AllowNullLiteral>] IStickyContext =
        abstract scrollablePane: PropTypes.Requireable<obj> with get, set

    type [<AllowNullLiteral>] Sticky =
        inherit BaseComponent<IStickyProps, IStickyState>
        abstract defaultProps: IStickyProps with get, set
        abstract contextTypes: IStickyContext with get, set
        abstract context: obj with get, set
        abstract distanceFromTop: float with get, set
        abstract _root: obj with get, set
        abstract _stickyContentTop: obj with get, set
        abstract _stickyContentBottom: obj with get, set
        abstract _nonStickyContent: obj with get, set
        abstract root: HTMLDivElement option
        abstract stickyContentTop: HTMLDivElement option
        abstract stickyContentBottom: HTMLDivElement option
        abstract nonStickyContent: HTMLDivElement option
        abstract canStickyTop: bool
        abstract canStickyBottom: bool
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract componentDidUpdate: prevProps: IStickyProps * prevState: IStickyState -> unit
        abstract shouldComponentUpdate: nextProps: IStickyProps * nextState: IStickyState -> bool
        abstract render: unit -> JSX.Element
        abstract addSticky: stickyContent: HTMLDivElement -> unit
        abstract resetSticky: unit -> unit
        abstract setDistanceFromTop: container: HTMLDivElement -> unit
        abstract _getContentStyles: isSticky: obj -> unit
        abstract _getStickyPlaceholderHeight: isSticky: obj -> unit
        abstract _getNonStickyPlaceholderHeight: unit -> unit
        abstract _onScrollEvent: obj with get, set
        abstract _getStickyDistanceFromTop: obj with get, set
        abstract _getStickyDistanceFromTopForFooter: obj with get, set
        abstract _getNonStickyDistanceFromTop: obj with get, set
        abstract _getBackground: unit -> unit

    type [<AllowNullLiteral>] StickyStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IStickyProps -> Sticky

module __components_Sticky_Sticky_types =
    type Sticky = __components_Sticky_Sticky.Sticky

    type [<AllowNullLiteral>] IStickyProps =
        inherit React.Props<Sticky>
        /// Gets ref to component interface.
        abstract componentRef: (IStickyProps option -> unit) option with get, set
        /// Class name to apply to the sticky element if component is sticky.
        abstract stickyClassName: string option with get, set
        /// color to apply as 'background-color' style for sticky element.
        abstract stickyBackgroundColor: string option with get, set
        /// Region to render sticky component in.
        abstract stickyPosition: StickyPositionType option with get, set

    type [<RequireQualifiedAccess>] StickyPositionType =
        | Both = 0
        | Header = 1
        | Footer = 2

module __components_SwatchColorPicker_ColorPickerGridCell_base =
    type IColorPickerGridCellProps = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorPickerGridCellProps

    type [<AllowNullLiteral>] IExports =
        abstract ColorPickerGridCellBase: ColorPickerGridCellBaseStatic

    type [<AllowNullLiteral>] ColorPickerGridCellBase =
        inherit React.Component<IColorPickerGridCellProps, obj>
        abstract defaultProps: IColorPickerGridCellProps with get, set
        abstract _classNames: obj with get, set
        abstract render: unit -> JSX.Element
        /// Render the core of a color cell
        abstract _onRenderColorOption: obj with get, set
        /// <summary>Validate if the cell's color is white or not to apply whiteCell style</summary>
        /// <param name="inputColor">- The color of the current cell</param>
        abstract _isWhiteCell: inputColor: obj -> unit
        /// Method to override the getClassNames func in a button.
        abstract _getClassNames: obj with get, set

    type [<AllowNullLiteral>] ColorPickerGridCellBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ColorPickerGridCellBase

module __components_SwatchColorPicker_ColorPickerGridCell =
    type IColorPickerGridCellProps = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorPickerGridCellProps

    type [<AllowNullLiteral>] IExports =
        abstract ColorPickerGridCell: (IColorPickerGridCellProps -> JSX.Element)

module __components_SwatchColorPicker_ColorPickerGridCell_styles =
    type IColorPickerGridCellStyleProps = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorPickerGridCellStyleProps
    type IColorPickerGridCellStyles = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorPickerGridCellStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IColorPickerGridCellStyleProps -> IColorPickerGridCellStyles)

module __components_SwatchColorPicker_ColorPickerGridCell_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IColorPickerGridCellProps =
        /// Item to render
        abstract item: IColorCellProps with get, set
        /// Arbitrary unique string associated with this option
        abstract id: string with get, set
        /// The label for this item.
        /// Visible text if this item is a header,
        /// tooltip if is this item is normal
        abstract label: string option with get, set
        /// The CSS-compatible string to describe the color
        abstract color: string option with get, set
        /// Index for this option
        abstract index: float option with get, set
        /// The theme object to use for styling.
        abstract theme: ITheme option with get, set
        /// Wheter or not colorOption should be rendered as a circle or square.
        abstract circle: bool option with get, set
        /// Optional, if the this option should be disabled
        abstract disabled: bool option with get, set
        /// Optional, if the cell is currently selected
        abstract selected: bool with get, set
        /// The on click handler
        abstract onClick: (IColorCellProps -> unit) option with get, set
        /// Optional, the onHover handler
        abstract onHover: (IColorCellProps -> unit) option with get, set
        /// Optional, the onFocus handler
        abstract onFocus: (IColorCellProps -> unit) option with get, set
        /// Optional styles for the component.
        abstract getStyles: IStyleFunction<IColorPickerGridCellStyleProps, IColorPickerGridCellStyles> option with get, set
        /// Optional, mouseEnter handler.
        abstract onMouseEnter: (React.MouseEvent<HTMLButtonElement> -> bool) option with get, set
        /// Optional, mouseMove handler
        abstract onMouseMove: (React.MouseEvent<HTMLButtonElement> -> bool) option with get, set
        /// Optional, mouseLeave handler
        abstract onMouseLeave: (React.MouseEvent<HTMLButtonElement> -> unit) option with get, set
        /// Optional, onWheel handler
        abstract onWheel: (React.MouseEvent<HTMLButtonElement> -> unit) option with get, set
        /// Optional, onkeydown handler
        abstract onKeyDown: (React.KeyboardEvent<HTMLButtonElement> -> unit) option with get, set

    type [<AllowNullLiteral>] IColorCellProps =
        /// Arbitrary unique string associated with this option
        abstract id: string with get, set
        /// The label for this item.
        /// Visible text if this item is a header,
        /// tooltip if is this item is normal
        abstract label: string option with get, set
        /// The CSS-compatible string to describe the color
        abstract color: string option with get, set
        /// Index for this option
        abstract index: float option with get, set

    /// Properties required to build the styles for the color picker component.
    type [<AllowNullLiteral>] IColorPickerGridCellStyleProps =
        /// Theme to apply to the cell.
        abstract theme: ITheme with get, set
        /// Whether the component is disabled or not.
        abstract disabled: bool option with get, set
        /// Whether the cell is currently selected or not.
        abstract selected: bool option with get, set
        /// Whether the svg color element should be rendered as a circle or not.
        abstract circle: bool option with get, set
        /// Whether the color being rendered is white or not. If it is white we show a border around it.
        abstract isWhite: bool option with get, set

    /// Styles for the Color Picker Component.
    type [<AllowNullLiteral>] IColorPickerGridCellStyles =
        /// Style to apply to a colorCell in the color picker.
        abstract colorCell: IStyle with get, set
        /// Style to apply to the svg element that renders the color.
        abstract svg: IStyle with get, set

module __components_SwatchColorPicker_SwatchColorPicker_base =
    type BaseComponent = Utilities.BaseComponent
    type ISwatchColorPicker = __components_SwatchColorPicker_SwatchColorPicker_types.ISwatchColorPicker
    type ISwatchColorPickerProps = __components_SwatchColorPicker_SwatchColorPicker_types.ISwatchColorPickerProps

    type [<AllowNullLiteral>] IExports =
        abstract SwatchColorPickerBase: SwatchColorPickerBaseStatic

    type [<AllowNullLiteral>] ISwatchColorPickerState =
        abstract selectedIndex: float option with get, set

    type [<AllowNullLiteral>] SwatchColorPickerBase =
        inherit BaseComponent<ISwatchColorPickerProps, ISwatchColorPickerState>
        inherit ISwatchColorPicker
        abstract defaultProps: ISwatchColorPickerProps with get, set
        abstract _id: obj with get, set
        abstract _cellFocused: obj with get, set
        abstract navigationIdleTimeoutId: obj with get, set
        abstract isNavigationIdle: obj with get, set
        abstract navigationIdleDelay: obj
        abstract async: obj with get, set
        abstract componentWillReceiveProps: newProps: ISwatchColorPickerProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element option
        /// When the whole swatchColorPicker is blurred,
        /// make sure to clear the pending focused stated
        abstract _onSwatchColorPickerBlur: obj with get, set
        /// <summary>Get the selected item's index</summary>
        /// <param name="items">- The items to search</param>
        /// <param name="selectedId">- The selected item's id to find</param>
        abstract _getSelectedIndex: items: obj * selectedId: obj -> unit
        /// Render a color cell
        abstract _renderOption: obj with get, set
        /// Callback passed to the GridCell that will manage triggering the onCellHovered callback for mouseEnter
        abstract _onMouseEnter: obj with get, set
        /// Callback passed to the GridCell that will manage Hover/Focus updates
        abstract _onMouseMove: obj with get, set
        /// Callback passed to the GridCell that will manage Hover/Focus updates
        abstract _onMouseLeave: obj with get, set
        /// Callback to make sure we don't update the hovered element during mouse wheel
        abstract _onWheel: obj with get, set
        /// Callback that
        abstract _onKeyDown: obj with get, set
        /// Sets a timeout so we won't process any mouse "hover" events
        /// while navigating (via mouseWheel or arrowKeys)
        abstract setNavigationTimeout: obj with get, set
        /// Callback passed to the GridCell class that will trigger the onCellHovered callback of the SwatchColorPicker
        /// NOTE: This will not be triggered if shouldFocusOnHover === true
        abstract _onGridCellHovered: obj with get, set
        /// Callback passed to the GridCell class that will trigger the onCellFocus callback of the SwatchColorPicker
        abstract _onGridCellFocused: obj with get, set
        /// Handle the click on a cell
        abstract _onCellClick: obj with get, set

    type [<AllowNullLiteral>] SwatchColorPickerBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ISwatchColorPickerProps -> SwatchColorPickerBase

module __components_SwatchColorPicker_SwatchColorPicker_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract SwatchColorPickerStatus: obj

module __components_SwatchColorPicker_SwatchColorPicker =
    type ISwatchColorPickerProps = __components_SwatchColorPicker_SwatchColorPicker_types.ISwatchColorPickerProps

    type [<AllowNullLiteral>] IExports =
        abstract SwatchColorPicker: (ISwatchColorPickerProps -> JSX.Element)

module __components_SwatchColorPicker_SwatchColorPicker_styles =
    type ISwatchColorPickerStyleProps = __components_SwatchColorPicker_SwatchColorPicker_types.ISwatchColorPickerStyleProps
    type ISwatchColorPickerStyles = __components_SwatchColorPicker_SwatchColorPicker_types.ISwatchColorPickerStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ISwatchColorPickerStyleProps -> ISwatchColorPickerStyles)

module __components_SwatchColorPicker_SwatchColorPicker_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction
    type IColorCellProps = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorCellProps
    type IColorPickerGridCellStyleProps = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorPickerGridCellStyleProps
    type IColorPickerGridCellStyles = __components_SwatchColorPicker_ColorPickerGridCell_types.IColorPickerGridCellStyles

    type [<AllowNullLiteral>] ISwatchColorPicker =
        interface end

    type [<AllowNullLiteral>] ISwatchColorPickerProps =
        /// Gets the component ref.
        abstract componentRef: (ISwatchColorPicker option -> unit) option with get, set
        /// the number of columns for the swatch color picker
        abstract columnCount: float with get, set
        /// The id for the swatch color picker
        abstract id: string option with get, set
        /// Additional class name to provide on the root element
        abstract className: string option with get, set
        /// The shape of the color cells, defaults to circle
        abstract cellShape: U2<string, string> option with get, set
        /// The id of color cell that is currently selected
        abstract selectedId: string option with get, set
        /// The color cells that will be made available to the user
        abstract colorCells: ResizeArray<IColorCellProps> with get, set
        /// Callback issued when the user changes the color.
        /// Note, if no id or color is given, there is no selected cell
        /// (e.g. the user executed the currently selected cell to unselect it)
        abstract onColorChanged: (string -> string -> unit) option with get, set
        /// Callback issued when the user hovers over a color cell.
        /// Note, if no id or color is given, cells are not longer being hovered
        abstract onCellHovered: (string -> string -> unit) option with get, set
        /// Callback issued when the user focuses a color cell.
        /// Note, if no id or color is given, cells are not longer being focused
        abstract onCellFocused: (string -> string -> unit) option with get, set
        /// Is this swatch color picker disabled?
        abstract disabled: bool option with get, set
        /// The optional position this grid is in the parent set (index in a parent menu, for example)
        abstract positionInSet: float option with get, set
        /// The optional size of the parent set (size of parent menu, for example)
        abstract setSize: float option with get, set
        /// Should focus cycle to the beginning of once the user navigates past the end (and visa vsersa).
        /// This prop is only relevant if doNotcontainWithinFocusZone is not true
        abstract shouldFocusCircularNavigate: bool option with get, set
        /// If true do not contain the grid inside of a FocusZone.
        /// If false contain the grid inside of a FocusZone.
        abstract doNotContainWithinFocusZone: bool option with get, set
        /// Theme to apply to the component.
        abstract theme: ITheme option with get, set
        /// Optional styles for the component.
        abstract getStyles: IStyleFunction<ISwatchColorPickerStyleProps, ISwatchColorPickerStyles> option with get, set
        /// Optional styles for the component.
        abstract getColorGridCellStyles: IStyleFunction<IColorPickerGridCellStyleProps, IColorPickerGridCellStyles> option with get, set
        /// Optional, whether to update focus when a cell is hovered.
        abstract focusOnHover: bool option with get, set
        /// Selector to focus on mouseLeave
        /// SHOULD ONLY BE USED IN CONJUNCTION WITH focusOnHover
        abstract mouseLeaveParentSelector: string option with get, set

    /// Properties required to build the styles for the color picker component.
    type [<AllowNullLiteral>] ISwatchColorPickerStyleProps =
        /// Theme to apply to the container
        abstract theme: ITheme with get, set
        /// Custom className to apply to the container.
        abstract className: string option with get, set

    /// Styles for the Color Picker Component.
    type [<AllowNullLiteral>] ISwatchColorPickerStyles =
        /// Style applied to the container grid of the swatchColorPicker
        abstract root: IStyle with get, set
        /// Style for the table cells of the grid.
        abstract tableCell: IStyle with get, set
        /// Optional, style for the FocusZone container for the grid
        abstract focusedContainer: IStyle option with get, set

module __components_SwatchColorPicker_SwatchColorPickerPage =
    type IComponentDemoPageProps = __components_SwatchColorPicker_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SwatchColorPickerPage: SwatchColorPickerPageStatic

    type [<AllowNullLiteral>] SwatchColorPickerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SwatchColorPickerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SwatchColorPickerPage

module __components_TeachingBubble_TeachingBubble_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleStatus: obj

module __components_TeachingBubble_TeachingBubble =
    type BaseComponent = Utilities.BaseComponent
    type ITeachingBubbleProps = __components_TeachingBubble_TeachingBubble_types.ITeachingBubbleProps
    type DirectionalHint = __common_DirectionalHint.DirectionalHint

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubble: TeachingBubbleStatic

    type [<AllowNullLiteral>] ITeachingBubbleState =
        abstract isTeachingBubbleVisible: bool option with get, set

    type [<AllowNullLiteral>] TeachingBubble =
        inherit BaseComponent<ITeachingBubbleProps, ITeachingBubbleState>
        abstract defaultProps: obj with get, set
        abstract _defaultCalloutProps: obj with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TeachingBubbleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ITeachingBubbleProps -> TeachingBubble

module __components_TeachingBubble_TeachingBubble_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract bounceAnimation: obj
        abstract opacityFadeIn: obj
        abstract bodyContent: obj
        abstract headerIsLarge: obj
        abstract headerIsSmall: obj
        abstract headline: obj
        abstract headerIsCondensed: obj
        abstract body: obj
        abstract subText: obj
        abstract closeButton: obj
        abstract footer: obj
        abstract wideCallout: obj
        abstract primaryButton: obj
        abstract secondaryButton: obj

module __components_TeachingBubble_TeachingBubble_types =
    type TeachingBubble = __components_TeachingBubble_TeachingBubble.TeachingBubble
    type TeachingBubbleContent = __components_TeachingBubble_TeachingBubbleContent.TeachingBubbleContent
    type IImageProps = Image.IImageProps
    type IButtonProps = Button.IButtonProps
    type IAccessiblePopupProps = __common_IAccessiblePopupProps.IAccessiblePopupProps
    type ICalloutProps = Callout.ICalloutProps

    type [<AllowNullLiteral>] ITeachingBubble =
        interface end

    /// TeachingBubble component props.
    type [<AllowNullLiteral>] ITeachingBubbleProps =
        inherit React.Props<U2<TeachingBubble, TeachingBubbleContent>>
        inherit IAccessiblePopupProps
        /// Optional callback to access the ISlider interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ITeachingBubble option -> unit) option with get, set
        /// Properties to pass through for Callout, reference detail properties in ICalloutProps
        abstract calloutProps: ICalloutProps option with get, set
        /// A headline for the Teaching Bubble.
        abstract headline: string option with get, set
        /// A variation with smaller bold headline and no margins.
        abstract hasCondensedHeadline: bool option with get, set
        /// Does the TeachingBubble have a close button in the top right corner?
        abstract hasCloseIcon: bool option with get, set
        /// An Image for the Teaching Bubble.
        abstract illustrationImage: IImageProps option with get, set
        /// The Primary interaction button
        abstract primaryButtonProps: IButtonProps option with get, set
        /// The Secondary interaction button
        abstract secondaryButtonProps: IButtonProps option with get, set
        /// Element to anchor the TeachingBubble to.
        abstract targetElement: HTMLElement option with get, set
        /// Callback when the TeachingBubble tries to close.
        abstract onDismiss: (obj option -> unit) option with get, set
        /// Whether or not the Teaching Bubble is wide, with image on the left side.
        abstract isWide: bool option with get, set
        /// A variation with smaller bold headline and margins to the body (hasCondensedHeadline takes precedence if it is also set to true).
        abstract hasSmallHeadline: bool option with get, set

module __components_TeachingBubble_TeachingBubbleContent =
    type BaseComponent = Utilities.BaseComponent
    type ITeachingBubbleProps = __components_TeachingBubble_TeachingBubble_types.ITeachingBubbleProps
    type ITeachingBubbleState = __components_TeachingBubble_TeachingBubble.ITeachingBubbleState
    type ImageFit = Image.ImageFit

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleContent: TeachingBubbleContentStatic

    type [<AllowNullLiteral>] TeachingBubbleContent =
        inherit BaseComponent<ITeachingBubbleProps, ITeachingBubbleState>
        abstract defaultProps: obj with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TeachingBubbleContentStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ITeachingBubbleProps -> TeachingBubbleContent

module __components_TeachingBubble_TeachingBubblePage =
    type IComponentDemoPageProps = __components_TeachingBubble_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubblePage: TeachingBubblePageStatic

    type [<AllowNullLiteral>] TeachingBubblePage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TeachingBubblePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TeachingBubblePage

module __components_TextField_TextField_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldStatus: obj

module __components_TextField_TextField =
    type ITextField = __components_TextField_TextField_types.ITextField
    type ITextFieldProps = __components_TextField_TextField_types.ITextFieldProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract TextField: TextFieldStatic

    type [<AllowNullLiteral>] ITextFieldState =
        abstract value: string option with get, set
        /// Is true when the control has focus. 
        abstract isFocused: bool option with get, set
        /// The validation error message.
        /// 
        /// - If there is no validation error or we have not validated the input value, errorMessage is an empty string.
        /// - If we have done the validation and there is validation error, errorMessage is the validation error message.
        abstract errorMessage: string option with get, set

    type [<AllowNullLiteral>] TextField =
        inherit BaseComponent<ITextFieldProps, ITextFieldState>
        inherit ITextField
        abstract defaultProps: ITextFieldProps with get, set
        abstract _id: obj with get, set
        abstract _descriptionId: obj with get, set
        abstract _delayedValidate: obj with get, set
        abstract _isMounted: obj with get, set
        abstract _lastValidation: obj with get, set
        abstract _latestValue: obj with get, set
        abstract _latestValidateValue: obj with get, set
        abstract _isDescriptionAvailable: obj with get, set
        abstract _textElement: obj with get, set
        /// Gets the current value of the text field.
        abstract value: string option
        abstract componentDidMount: unit -> unit
        abstract componentWillReceiveProps: newProps: ITextFieldProps -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        /// Sets focus on the text field
        abstract focus: unit -> unit
        /// Selects the text field
        abstract select: unit -> unit
        /// Sets the selection start of the text field to a specified value
        abstract setSelectionStart: value: float -> unit
        /// Sets the selection end of the text field to a specified value
        abstract setSelectionEnd: value: float -> unit
        /// Gets the selection start of the text field
        abstract selectionStart: float option
        /// Gets the selection end of the text field
        abstract selectionEnd: float option
        /// <summary>Sets the start and end positions of a selection in a text field.</summary>
        /// <param name="start">Index of the start of the selection.</param>
        /// <param name="end">Index of the end of the selection.</param>
        abstract setSelectionRange: start: float * ``end``: float -> unit
        abstract _onFocus: ev: obj -> unit
        abstract _onBlur: ev: obj -> unit
        abstract _onRenderLabel: obj with get, set
        abstract _onRenderDescription: obj with get, set
        abstract _onRenderAddon: props: obj -> unit
        abstract _onRenderPrefix: props: obj -> unit
        abstract _onRenderSuffix: props: obj -> unit
        abstract _getTextElementClassName: unit -> unit
        abstract _errorMessage: obj
        abstract _renderTextArea: unit -> unit
        abstract _renderInput: unit -> unit
        abstract _onInputChange: ``event``: obj -> unit
        abstract _validate: value: obj -> unit
        abstract _notifyAfterValidate: value: obj * errorMessage: obj -> unit
        abstract _adjustInputHeight: unit -> unit

    type [<AllowNullLiteral>] TextFieldStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ITextFieldProps -> TextField

module __components_TextField_TextField_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract screenReaderOnly: obj
        abstract fieldGroup: obj
        abstract fieldGroupIsFocused: obj
        abstract field: obj
        abstract invalid: obj
        abstract rootIsDisabled: obj
        abstract fieldPrefixSuffix: obj
        abstract hasIcon: obj
        abstract rootIsRequiredLabel: obj
        abstract rootIsRequiredPlaceholderOnly: obj
        abstract rootIsActive: obj
        abstract icon: obj
        abstract description: obj
        abstract rootIsBorderless: obj
        abstract rootIsUnderlined: obj
        abstract wrapper: obj
        abstract rootIsMultiline: obj
        abstract errorMessage: obj
        abstract fieldIsUnresizable: obj
        abstract hidden: obj

module __components_TextField_TextField_types =
    type IRenderFunction = Utilities.IRenderFunction
    type IIconProps = Icon.IIconProps

    type [<AllowNullLiteral>] ITextField =
        /// Gets the current value of the input. 
        abstract value: string option with get, set
        /// Sets focus to the input. 
        abstract focus: (unit -> unit) with get, set
        /// Select the value of the text field. 
        abstract select: (unit -> unit) with get, set
        /// Sets the selection start of the text field to a specified value. 
        abstract setSelectionStart: (float -> unit) with get, set
        /// Sets the selection end of the text field to a specified value. 
        abstract setSelectionEnd: (float -> unit) with get, set
        /// Sets the start and end positions of a selection in a text field.
        abstract setSelectionRange: (float -> float -> unit) with get, set
        /// Gets the selection start of the text field. Returns -1 if there is no selection. 
        abstract selectionStart: float option with get, set
        /// Gets the selection end of the text field. Returns -1 if there is no selection. 
        abstract selectionEnd: float option with get, set

    /// TextField component props.
    type [<AllowNullLiteral>] ITextFieldProps =
        inherit React.AllHTMLAttributes<U2<HTMLInputElement, HTMLTextAreaElement>>
        /// Optional callback to access the ITextField interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ITextField option -> unit) option with get, set
        /// Whether or not the textfield is a multiline textfield.
        abstract multiline: bool option with get, set
        /// Whether or not the multiline textfield is resizable.
        abstract resizable: bool option with get, set
        /// Whether or not to auto adjust textField height. Applies only to multiline textfield.
        abstract autoAdjustHeight: bool option with get, set
        /// Whether or not the textfield is underlined.
        abstract underlined: bool option with get, set
        /// Whether or not the textfield is borderless.
        abstract borderless: bool option with get, set
        /// Label for the textfield.
        abstract label: string option with get, set
        /// Optional custom renderer for the label.
        abstract onRenderLabel: IRenderFunction<ITextFieldProps> option with get, set
        /// The textfield input description
        abstract description: string option with get, set
        /// Optional custom renderer for the description.
        abstract onRenderDescription: IRenderFunction<ITextFieldProps> option with get, set
        abstract addonString: string option with get, set
        /// String for prefix
        abstract prefix: string option with get, set
        /// String for suffix
        abstract suffix: string option with get, set
        abstract onRenderAddon: IRenderFunction<ITextFieldProps> option with get, set
        /// Custom render function for prefix.
        abstract onRenderPrefix: IRenderFunction<ITextFieldProps> option with get, set
        /// Custom render function for suffix.
        abstract onRenderSuffix: IRenderFunction<ITextFieldProps> option with get, set
        /// Optional icon props for an icon.
        abstract iconProps: IIconProps option with get, set
        /// Default value of the textfield, if any. Only provide this if the textfield is an uncontrolled component;
        /// otherwise, use the "value" property.
        abstract defaultValue: string option with get, set
        /// Current value of the textfield. Only provide this if the textfield is a controlled component where you
        /// are maintaining its current state; otherwise, use the "defaultValue" property.
        abstract value: string option with get, set
        /// Disabled state of the textfield.
        abstract disabled: bool option with get, set
        /// If set, this will display an error message for the text field.
        abstract errorMessage: string option with get, set
        /// Callback for the onChanged event.
        abstract onChanged: (obj option -> unit) option with get, set
        /// Callback for the onBeforeChange event.
        abstract onBeforeChange: (obj option -> unit) option with get, set
        /// Callback for the onNotifyValidationResult event.
        abstract onNotifyValidationResult: (string -> string option -> unit) option with get, set
        /// The method is used to get the validation error message and determine whether the input value is valid or not.
        /// 
        ///    When it returns string:
        ///    - If valid, it returns empty string.
        ///    - If invalid, it returns the error message string and the text field will
        ///      show a red border and show an error message below the text field.
        /// 
        ///    When it returns Promise<string>:
        ///    - The resolved value is display as error message.
        ///    - The rejected, the value is thrown away.
        abstract onGetErrorMessage: (string -> U2<string, PromiseLike<string>> option) option with get, set
        /// Text field will start to validate after users stop typing for `deferredValidationTime` milliseconds.
        abstract deferredValidationTime: float option with get, set
        /// Optional class name that is added to the container of the component.
        abstract className: string option with get, set
        /// Optional class name that is added specifically to the input/textarea element.
        abstract inputClassName: string option with get, set
        /// Aria Label for textfield, if any.
        abstract ariaLabel: string option with get, set
        /// Run validation only on input focus
        abstract validateOnFocusIn: bool option with get, set
        /// Run validation only on input focus out
        abstract validateOnFocusOut: bool option with get, set
        /// Optional flag to disable onload validation
        abstract validateOnLoad: bool option with get, set
        abstract iconClass: string option with get, set
        /// Whether the input field should have autocomplete enabled.
        /// This tells the browser to display options based on earlier typed values.
        abstract autoComplete: U2<string, string> option with get, set
        /// The masking string that defines the mask's behavior.
        /// A backslash will escape any character.
        /// Special format characters are:
        /// '9': [0-9]
        /// 'a': [a-zA-Z]
        /// '*': [a-zA-Z0-9]
        abstract mask: string option with get, set
        /// The character to show in place of unfilled characters of the mask.
        abstract maskChar: string option with get, set
        /// An object defining the format characters and corresponding regexp values.
        /// Default format characters: {
        ///   '9': /[0-9]/,
        ///   'a': /[a-zA-Z]/,
        ///   '*': /[a-zA-Z0-9]/
        /// }
        abstract maskFormat: obj option with get, set
        /// Deprecated property. Serves no function.
        abstract componentId: string option with get, set

module __components_TextField_TextFieldPage =
    type IComponentDemoPageProps = __components_TextField_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldPage: TextFieldPageStatic

    type [<AllowNullLiteral>] TextFieldPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldPage

module __components_Theme_defaultTheme =

    type [<AllowNullLiteral>] IExports =
        abstract defaultPalette: ResizeArray<obj>
        abstract defaultSemanticColors: ResizeArray<obj>

module __components_Theme_ThemePage =
    type IComponentDemoPageProps = __components_Theme_@uifabric_example_app_base.IComponentDemoPageProps
    type IThemePageState = __components_Theme_ThemePage_types.IThemePageState

    type [<AllowNullLiteral>] IExports =
        abstract ThemePage: ThemePageStatic

    type [<AllowNullLiteral>] ThemePage =
        inherit React.Component<IComponentDemoPageProps, IThemePageState>
        abstract render: unit -> JSX.Element
        abstract _colorList: obj with get, set
        abstract _onSwatchClicked: item: obj * index: obj * list: obj * ev: obj -> unit
        abstract _onColorChanged: index: obj * newColor: obj -> unit
        abstract _onPickerDismiss: unit -> unit

    type [<AllowNullLiteral>] ThemePageStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IComponentDemoPageProps -> ThemePage

module __components_Theme_ThemePage_styles =
    type IThemePageStyleProps = __components_Theme_ThemePage_types.IThemePageStyleProps
    type IThemePageStyles = __components_Theme_ThemePage_types.IThemePageStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IThemePageStyleProps -> IThemePageStyles)

module __components_Theme_ThemePage_types =
    type IStyle = Styling.IStyle

    type [<AllowNullLiteral>] IThemePagePalette =
        abstract key: string with get, set
        abstract name: string with get, set
        abstract value: string with get, set
        abstract description: string with get, set

    type [<AllowNullLiteral>] IThemePageState =
        abstract palette: ResizeArray<IThemePagePalette> with get, set
        abstract semanticColors: ResizeArray<IThemePagePalette> with get, set
        abstract colorPickerProps: obj option with get, set
        abstract activeList: string option with get, set

    type [<AllowNullLiteral>] IThemePageStyleProps =
        interface end

    type [<AllowNullLiteral>] IThemePageStyles =
        abstract colorSwatch: IStyle with get, set
        abstract swatch: IStyle with get, set
        abstract colorValue: IStyle with get, set

module __components_ThemeGenerator_IThemeRules =
    type IThemeSlotRule = __components_ThemeGenerator_IThemeSlotRule.IThemeSlotRule

    type [<AllowNullLiteral>] IThemeRules =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> IThemeSlotRule with get, set

module __components_ThemeGenerator_IThemeSlotRule =
    type IColor = __utilities_color_colors.IColor
    type Shade = __utilities_color_shades.Shade

    type [<AllowNullLiteral>] IThemeSlotRule =
        abstract name: string with get, set
        abstract color: IColor option with get, set
        abstract value: string option with get, set
        abstract inherits: IThemeSlotRule option with get, set
        abstract asShade: Shade option with get, set
        abstract isBackgroundShade: bool option with get, set
        abstract isCustomized: bool option with get, set
        abstract dependentRules: ResizeArray<IThemeSlotRule> with get, set

module __components_ThemeGenerator_ThemeGenerator =
    type IColor = __utilities_color_colors.IColor
    type IThemeSlotRule = __components_ThemeGenerator_IThemeSlotRule.IThemeSlotRule
    type IThemeRules = __components_ThemeGenerator_IThemeRules.IThemeRules

    type [<AllowNullLiteral>] IExports =
        abstract ThemeGenerator: ThemeGeneratorStatic

    type [<AllowNullLiteral>] ThemeGenerator =
        interface end

    type [<AllowNullLiteral>] ThemeGeneratorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ThemeGenerator
        abstract setSlot: rule: IThemeSlotRule * color: U2<string, IColor> * ?isInverted: bool * ?isCustomization: bool * ?overwriteCustomColor: bool -> unit
        abstract insureSlots: slotRules: IThemeRules * isInverted: bool -> unit
        abstract getThemeAsJson: slotRules: IThemeRules -> obj option
        abstract getThemeAsSass: slotRules: IThemeRules -> obj option
        abstract getThemeForPowerShell: slotRules: IThemeRules -> obj option
        abstract _setSlot: rule: obj * color: obj * isInverted: obj * isCustomization: obj * ?overwriteCustomColor: obj -> unit

module __components_ThemeGenerator_ThemeGeneratorPage =
    type BaseComponent = __components_ThemeGenerator_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IThemeSlotRule = __components_ThemeGenerator_office_ui_fabric_react_lib_ThemeGenerator.IThemeSlotRule
    type IThemeRules = __components_ThemeGenerator_office_ui_fabric_react_lib_ThemeGenerator.IThemeRules

    type [<AllowNullLiteral>] IExports =
        abstract ThemeGeneratorPage: ThemeGeneratorPageStatic

    type [<AllowNullLiteral>] IThemeGeneratorPageState =
        abstract themeRules: IThemeRules with get, set
        abstract colorPickerSlotRule: IThemeSlotRule option with get, set
        abstract colorPickerElement: HTMLElement option with get, set
        abstract colorPickerVisible: bool with get, set

    type [<AllowNullLiteral>] ThemeGeneratorPage =
        inherit BaseComponent<obj, IThemeGeneratorPageState>
        abstract _semanticSlotColorChangeTimeout: obj with get, set
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _colorPickerOnDismiss: obj with get, set
        abstract _semanticSlotRuleChanged: obj with get, set
        abstract _onSwatchClick: obj with get, set
        abstract _slotWidget: obj with get, set
        abstract _fabricSlotWidget: obj with get, set
        abstract _colorSquareSwatchWidget: slotRule: obj -> unit
        abstract _accessibilityRow: obj with get, set
        abstract _outputSection: obj with get, set
        abstract _makeNewTheme: obj with get, set
        abstract _baseColorSlotPicker: obj with get, set

    type [<AllowNullLiteral>] ThemeGeneratorPageStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ThemeGeneratorPageStaticProps -> ThemeGeneratorPage

    type [<AllowNullLiteral>] ThemeGeneratorPageStaticProps =
        interface end

module __components_ThemeGenerator_ThemeRulesStandard =
    type IThemeRules = __components_ThemeGenerator_IThemeRules.IThemeRules

    type [<AllowNullLiteral>] IExports =
        abstract themeRulesStandardCreator: unit -> IThemeRules

    type [<RequireQualifiedAccess>] BaseSlots =
        | PrimaryColor = 0
        | BackgroundColor = 1
        | ForegroundColor = 2

    type [<RequireQualifiedAccess>] FabricSlots =
        | ThemePrimary = 0
        | ThemeLighterAlt = 1
        | ThemeLighter = 2
        | ThemeLight = 3
        | ThemeTertiary = 4
        | ThemeSecondary = 5
        | ThemeDarkAlt = 6
        | ThemeDark = 7
        | ThemeDarker = 8
        | NeutralLighterAlt = 9
        | NeutralLighter = 10
        | NeutralLight = 11
        | NeutralQuaternaryAlt = 12
        | NeutralQuaternary = 13
        | NeutralTertiaryAlt = 14
        | NeutralTertiary = 15
        | NeutralSecondary = 16
        | NeutralPrimaryAlt = 17
        | NeutralPrimary = 18
        | NeutralDark = 19
        | Black = 20
        | White = 21

    type [<RequireQualifiedAccess>] SemanticColorSlots =
        | BodyBackground = 0
        | BodyText = 1
        | DisabledBackground = 2
        | DisabledText = 3

module __components_Toggle_Toggle_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract ToggleStatus: obj

module __components_Toggle_Toggle_classNames =
    type ITheme = Styling.ITheme
    type IToggleStyles = __components_Toggle_Toggle_types.IToggleStyles

    type [<AllowNullLiteral>] IExports =
        abstract getClassNames: (ITheme -> IToggleStyles -> string -> bool -> bool -> IToggleClassNames)

    type [<AllowNullLiteral>] IToggleClassNames =
        abstract root: string option with get, set
        abstract label: string option with get, set
        abstract container: string option with get, set
        abstract pill: string option with get, set
        abstract thumb: string option with get, set
        abstract text: string option with get, set

module __components_Toggle_Toggle =
    type BaseComponent = Utilities.BaseComponent
    type IToggleProps = __components_Toggle_Toggle_types.IToggleProps
    type IToggle = __components_Toggle_Toggle_types.IToggle

    type [<AllowNullLiteral>] IExports =
        abstract Toggle: ToggleStatic

    type [<AllowNullLiteral>] IToggleState =
        abstract isChecked: bool with get, set

    type [<AllowNullLiteral>] Toggle =
        inherit BaseComponent<IToggleProps, IToggleState>
        inherit IToggle
        abstract _id: obj with get, set
        abstract _toggleButton: obj with get, set
        /// Gets the current checked state of the toggle.
        abstract ``checked``: bool
        abstract componentWillReceiveProps: newProps: IToggleProps -> unit
        abstract render: unit -> JSX.Element
        abstract focus: unit -> unit
        abstract _onClick: obj with get, set
        abstract _noop: unit -> unit

    type [<AllowNullLiteral>] ToggleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IToggleProps -> Toggle

module __components_Toggle_Toggle_types =
    type Toggle = __components_Toggle_Toggle.Toggle
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IToggle =
        abstract focus: (unit -> unit) with get, set

    /// Toggle component props.
    type [<AllowNullLiteral>] IToggleProps =
        inherit React.HTMLAttributes<U2<HTMLElement, Toggle>>
        /// Optional callback to access the IToggle interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (IToggle option -> unit) option with get, set
        /// A label for the toggle.
        abstract label: string option with get, set
        /// Text to display when toggle is ON.
        abstract onText: string option with get, set
        /// Text to display when toggle is OFF.
        abstract offText: string option with get, set
        /// Text for screen-reader to announce when toggle is ON.
        abstract onAriaLabel: string option with get, set
        /// Text for screen-reader to announce when toggle is OFF.
        abstract offAriaLabel: string option with get, set
        /// Checked state of the toggle. If you are maintaining state yourself, use this property. Otherwise refer to 'defaultChecked'.
        abstract ``checked``: bool option with get, set
        /// Initial state of the toggle. If you want the toggle to maintain its own state, use this. Otherwise refer to 'checked'.
        abstract defaultChecked: bool option with get, set
        /// Optional disabled flag.
        abstract disabled: bool option with get, set
        /// onchange callback.
        abstract onChanged: (bool -> unit) option with get, set
        /// Theme provided by HOC.
        abstract theme: ITheme option with get, set
        /// Custom styles for this component
        abstract styles: IToggleStyles option with get, set
        /// Optional keytip for this toggle
        abstract keytipProps: IKeytipProps option with get, set

    type [<AllowNullLiteral>] IToggleStyles =
        /// Style for the root element in the default enabled/unchecked state.
        abstract root: IStyle option with get, set
        abstract label: IStyle option with get, set
        /// Style for the container wrapping switch and the state (on/off) text.
        abstract container: IStyle option with get, set
        /// Style for the toggle "pill" element, which is inside of the container and contains the thumb.
        abstract pill: IStyle option with get, set
        /// Style override for the pill element when enabled/checked.
        abstract pillChecked: IStyle option with get, set
        /// Style override for the pill element when enabled/unchecked/hovered.
        abstract pillHovered: IStyle option with get, set
        /// Style override for the pill element when enabled/checked/hovered.
        abstract pillCheckedHovered: IStyle option with get, set
        /// Style override for the pill element when disabled/unchecked.
        abstract pillDisabled: IStyle option with get, set
        /// Style override for the pill element when disabled/checked.
        abstract pillCheckedDisabled: IStyle option with get, set
        /// Style for the thumb element inside of the pill, in the normal unchecked enabled state.
        abstract thumb: IStyle option with get, set
        /// Style override for the thumb when enabled/unchecked/hovered.
        abstract thumbHovered: IStyle option with get, set
        /// Style override for the thumb when enabled/checked.
        abstract thumbChecked: IStyle option with get, set
        /// Style override for the thumb when enabled/checked/hovered.
        abstract thumbCheckedHovered: IStyle option with get, set
        /// Style override for the thumb when disabled/unchecked.
        abstract thumbDisabled: IStyle option with get, set
        /// Style override for the thumb when disabled/checked.
        abstract thumbCheckedDisabled: IStyle option with get, set
        /// Style for the text indicating the on/off state of the control.
        abstract text: IStyle option with get, set

module __components_Toggle_TogglePage =
    type IComponentDemoPageProps = __components_Toggle_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract TogglePage: TogglePageStatic

    type [<AllowNullLiteral>] TogglePage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TogglePageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TogglePage

module __components_Tooltip_Tooltip_base =
    type BaseComponent = Utilities.BaseComponent
    type ITooltipProps = __components_Tooltip_Tooltip_types.ITooltipProps

    type [<AllowNullLiteral>] IExports =
        abstract TooltipBase: TooltipBaseStatic

    type [<AllowNullLiteral>] TooltipBase =
        inherit BaseComponent<ITooltipProps, obj option>
        abstract defaultProps: obj with get, set
        abstract _classNames: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onRenderContent: obj with get, set

    type [<AllowNullLiteral>] TooltipBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TooltipBase

module __components_Tooltip_Tooltip_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract TooltipStatus: obj

module __components_Tooltip_Tooltip =
    type ITooltipProps = __components_Tooltip_Tooltip_types.ITooltipProps

    type [<AllowNullLiteral>] IExports =
        abstract Tooltip: (ITooltipProps -> JSX.Element)

module __components_Tooltip_Tooltip_styles =
    type ITooltipStyleProps = __components_Tooltip_Tooltip_types.ITooltipStyleProps
    type ITooltipStyles = __components_Tooltip_Tooltip_types.ITooltipStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITooltipStyleProps -> ITooltipStyles)

module __components_Tooltip_Tooltip_types =
    type TooltipBase = __components_Tooltip_Tooltip_base.TooltipBase
    type ICalloutProps = Callout.ICalloutProps
    type IRenderFunction = Utilities.IRenderFunction
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] ITooltip =
        interface end

    /// Tooltip component props.
    type [<AllowNullLiteral>] ITooltipProps =
        inherit React.HTMLAttributes<U2<HTMLDivElement, TooltipBase>>
        /// Optional callback to access the ITooltip interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ITooltip option -> unit) option with get, set
        /// Properties to pass through for Callout, reference detail properties in ICalloutProps
        abstract calloutProps: ICalloutProps option with get, set
        /// String to be passed to the tooltip
        abstract content: string option with get, set
        /// Render function to populate content area
        abstract onRenderContent: IRenderFunction<ITooltipProps> option with get, set
        /// Length of delay. Can be set to zero if you do not want a delay.
        abstract delay: TooltipDelay option with get, set
        /// Max width of tooltip
        abstract maxWidth: string option with get, set
        /// Element to anchor the Tooltip to.
        abstract targetElement: HTMLElement option with get, set
        /// Indicator of how the tooltip should be anchored to its targetElement.
        abstract directionalHint: DirectionalHint option with get, set
        /// How the element should be positioned in RTL layouts.
        /// If not specified, a mirror of `directionalHint` will be used instead
        abstract directionalHintForRTL: DirectionalHint option with get, set
        /// Theme to apply to the component.
        abstract theme: ITheme option with get, set
        /// Call to provide customized styling that will layer on top of the variant rules.
        abstract getStyles: IStyleFunction<ITooltipStyleProps, ITooltipStyles> option with get, set

    type [<RequireQualifiedAccess>] TooltipDelay =
        | Zero = 0
        | Medium = 1
        | Long = 2

    type [<AllowNullLiteral>] ITooltipStyleProps =
        /// Accept theme prop.
        abstract theme: ITheme with get, set
        /// Accept custom classNames
        abstract className: string option with get, set
        /// Delay before tooltip appears.
        abstract delay: TooltipDelay option with get, set
        /// Maximum width of tooltip.
        abstract maxWidth: string option with get, set

    type [<AllowNullLiteral>] ITooltipStyles =
        /// Style for the root element.
        abstract root: IStyle with get, set
        /// Style for the content element.
        abstract content: IStyle with get, set
        /// Style for the subtext element.
        abstract subText: IStyle with get, set

module __components_Tooltip_TooltipHost =
    type BaseComponent = Utilities.BaseComponent
    type ITooltipHostProps = __components_Tooltip_TooltipHost_types.ITooltipHostProps
    type TooltipDelay = __components_Tooltip_Tooltip_types.TooltipDelay

    type [<AllowNullLiteral>] IExports =
        abstract TooltipHost: TooltipHostStatic

    type [<AllowNullLiteral>] ITooltipHostState =
        abstract isTooltipVisible: bool with get, set

    type [<AllowNullLiteral>] TooltipHost =
        inherit BaseComponent<ITooltipHostProps, ITooltipHostState>
        abstract defaultProps: obj with get, set
        abstract _tooltipHost: obj with get, set
        abstract _closingTimer: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getTargetElement: unit -> unit
        abstract _onTooltipMouseEnter: obj with get, set
        abstract _onTooltipMouseLeave: obj with get, set
        abstract _clearDismissTimer: obj with get, set
        abstract _hideTooltip: obj with get, set
        abstract _toggleTooltip: isTooltipVisible: obj -> unit

    type [<AllowNullLiteral>] TooltipHostStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ITooltipHostProps -> TooltipHost

module __components_Tooltip_TooltipHost_scss =

    type [<AllowNullLiteral>] IExports =
        abstract host: obj

module __components_Tooltip_TooltipHost_types =
    type TooltipHost = __components_Tooltip_TooltipHost.TooltipHost
    type TooltipDelay = __components_Tooltip_Tooltip_types.TooltipDelay
    type ITooltipProps = __components_Tooltip_Tooltip_types.ITooltipProps
    type ICalloutProps = Callout.ICalloutProps
    type DirectionalHint = __common_DirectionalHint.DirectionalHint

    type [<AllowNullLiteral>] ITooltipHost =
        interface end

    type [<RequireQualifiedAccess>] TooltipOverflowMode =
        | Parent = 0
        | Self = 1

    /// Tooltip component props.
    type [<AllowNullLiteral>] ITooltipHostProps =
        inherit React.HTMLAttributes<U2<HTMLDivElement, TooltipHost>>
        /// Optional callback to access the ITooltipHost interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ITooltipHost option -> unit) option with get, set
        /// Additional properties to pass through for Callout, reference detail properties in ICalloutProps
        abstract calloutProps: ICalloutProps option with get, set
        /// Additional properties to pass through for Tooltip, reference detail properties in ITooltipProps
        abstract tooltipProps: ITooltipProps option with get, set
        /// Whether or not to mark the container as described by the tooltip.
        /// If not specified, the caller should mark as element as described by the tooltip id.
        abstract setAriaDescribedBy: bool option with get, set
        /// Length of delay
        abstract delay: TooltipDelay option with get, set
        /// String to be passed to the tooltip
        abstract content: string option with get, set
        /// Indicator of how the tooltip should be anchored to its targetElement.
        abstract directionalHint: DirectionalHint option with get, set
        /// How the element should be positioned in RTL layouts.
        /// If not specified, a mirror of `directionalHint` will be used instead
        abstract directionalHintForRTL: DirectionalHint option with get, set
        /// Only show if there is overflow. If set, the tooltip hosts observes  and only shows the tooltip if this element has overflow.
        /// It also uses the parent as target element for the tooltip.
        abstract overflowMode: TooltipOverflowMode option with get, set
        /// Optional class name to apply to tooltip host.
        abstract hostClassName: string option with get, set
        /// Optionally a number of milliseconds to delay closing the tooltip, so that
        /// the user has time to hover over the tooltip and interact with it. Hovering
        /// over the tooltip will count as hovering over the host, so that the tooltip
        /// will stay open if the user is actively interacting with it.
        abstract closeDelay: float option with get, set
        /// Notifies when tooltip becomes visible or hidden, whatever the trigger was.
        abstract onTooltipToggle: isTooltipVisible: bool -> unit

module __components_Tooltip_TooltipPage =
    type IComponentDemoPageProps = __components_Tooltip_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract TooltipPage: TooltipPageStatic

    type [<AllowNullLiteral>] TooltipPage =
        inherit React.Component<IComponentDemoPageProps, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TooltipPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TooltipPage

module __demo_ComponentStatus_AllComponents_checklist =
    type IComponentStatusProps = __demo_ComponentStatus_ComponentStatus_types.IComponentStatusProps

    type [<AllowNullLiteral>] IExports =
        abstract AllComponentsStatus: IComponentStatusState

    type [<AllowNullLiteral>] IComponentStatusState =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> IComponentStatusProps with get, set

module __demo_ComponentStatus_ComponentStatus =
    type IComponentStatusProps = __demo_ComponentStatus_ComponentStatus_types.IComponentStatusProps

    type [<AllowNullLiteral>] IExports =
        abstract ComponentStatus: ComponentStatusStatic

    type [<AllowNullLiteral>] ComponentStatus =
        inherit React.Component<IComponentStatusProps, obj>
        abstract defaultProps: IComponentStatusProps with get, set
        abstract render: unit -> JSX.Element
        abstract _definebadgeAnchor: subject: obj * state: obj -> unit
        abstract _badgeAnchor: ariaLabel: obj * color: obj * subject: obj * status: obj -> unit
        abstract _badgeURL: color: obj * subject: obj * status: obj -> unit
        abstract _colorForComponentStateStatus: testCoverageStatus: obj -> unit

    type [<AllowNullLiteral>] ComponentStatusStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ComponentStatus

module __demo_ComponentStatus_ComponentStatus_types =

    type [<AllowNullLiteral>] IComponentStatusProps =
        abstract keyboardAccessibilitySupport: ChecklistStatus with get, set
        abstract markupSupport: ChecklistStatus with get, set
        abstract highContrastSupport: ChecklistStatus with get, set
        abstract rtlSupport: ChecklistStatus with get, set
        abstract testCoverage: ChecklistStatus with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ChecklistStatus =
        | [<CompiledName "Unknown">] Unknown
        | [<CompiledName "Not applicable">] NotApplicable
        | [<CompiledName "Pass">] Pass
        | [<CompiledName "Fail">] Fail
        | [<CompiledName "No tests">] None
        | [<CompiledName "Poor">] Poor
        | [<CompiledName "Fair">] Fair
        | [<CompiledName "Good">] Good

module __demo_ComponentStatus_ComponentStatusPage =

    type [<AllowNullLiteral>] IExports =
        abstract ComponentStatusPage: ComponentStatusPageStatic

    type [<AllowNullLiteral>] ComponentStatusPage =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _renderOverView: unit -> unit
        abstract _renderComponents: unit -> unit
        abstract _renderComponent: componentName: obj -> unit
        abstract _renderStatusesInfo: unit -> unit
        abstract _renderStatusInfo: statusInfo: obj -> unit
        abstract _createLink: information: obj -> unit

    type [<AllowNullLiteral>] ComponentStatusPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ComponentStatusPage

module __demo_ComponentStatus_ComponentStatusState =

    type [<AllowNullLiteral>] IExports =
        abstract ComponentStatusInfoState: ResizeArray<IComponentStatusInfoState>

    type [<AllowNullLiteral>] IComponentStatusInfoState =
        abstract name: string with get, set
        abstract description: string with get, set
        abstract success: string with get, set
        abstract link: InformationLink option with get, set

    type [<AllowNullLiteral>] InformationLink =
        abstract link: string with get, set
        abstract renderedText: string with get, set

module __utilities_color_colors =

    type [<AllowNullLiteral>] IExports =
        abstract MAX_COLOR_SATURATION: obj
        abstract MAX_COLOR_HUE: obj
        abstract MAX_COLOR_VALUE: obj
        abstract MAX_COLOR_RGBA: obj
        abstract cssColor: color: string -> IRGB option
        abstract rgb2hex: r: float * g: float * b: float -> string
        abstract hsv2hex: h: float * s: float * v: float -> string
        abstract rgb2hsv: r: float * g: float * b: float -> IHSV
        abstract hsl2hsv: h: float * s: float * l: float -> IHSV
        abstract hsv2hsl: h: float * s: float * v: float -> obj
        abstract hsl2rgb: h: float * s: float * l: float -> IRGB
        abstract hsv2rgb: h: float * s: float * v: float -> IRGB
        abstract getColorFromString: inputColor: string -> IColor option
        abstract getColorFromRGBA: rgba: GetColorFromRGBARgba -> IColor
        abstract getFullColorString: color: IColor -> string
        abstract updateSV: color: IColor * s: float * v: float -> IColor
        abstract updateH: color: IColor * h: float -> IColor
        abstract updateA: color: IColor * a: float -> IColor

    type [<AllowNullLiteral>] GetColorFromRGBARgba =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract a: float with get, set

    type [<AllowNullLiteral>] IRGB =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract a: float option with get, set

    type [<AllowNullLiteral>] IHSV =
        abstract h: float with get, set
        abstract s: float with get, set
        abstract v: float with get, set

    type [<AllowNullLiteral>] IHSL =
        abstract h: float with get, set
        abstract s: float with get, set
        abstract l: float with get, set

    type [<AllowNullLiteral>] IColor =
        inherit IRGB
        inherit IHSV
        abstract hex: string with get, set
        abstract str: string with get, set

module __utilities_color_colorValues =

    type [<AllowNullLiteral>] IExports =
        abstract COLOR_VALUES: obj

module __utilities_color_shades =
    type IColor = __utilities_color_colors.IColor

    type [<AllowNullLiteral>] IExports =
        /// <summary>Returns true if the argument is a valid Shade value</summary>
        /// <param name="shade">The Shade value to validate.</param>
        abstract isValidShade: ?shade: Shade -> bool
        abstract isDark: color: IColor -> bool
        /// <summary>Given a color and a shade specification, generates the requested shade of the color.
        /// Logic:
        /// if white
        ///   darken via tables defined above
        /// if black
        ///   lighten
        /// if light
        ///   strongen
        /// if dark
        ///   soften
        /// else default
        ///   soften or strongen depending on shade#</summary>
        /// <param name="color">The base color whose shade is to be computed</param>
        /// <param name="shade">The shade of the base color to compute</param>
        /// <param name="isInverted">Default false. Whether the given theme is inverted (reverse strongen/soften logic)</param>
        abstract getShade: color: IColor * shade: Shade * ?isInverted: bool -> IColor option
        abstract getBackgroundShade: color: IColor * shade: Shade * ?isInverted: bool -> IColor option
        abstract getContrastRatio: color1: IColor * color2: IColor -> float

    type [<RequireQualifiedAccess>] Shade =
        | Unshaded = 0
        | Shade1 = 1
        | Shade2 = 2
        | Shade3 = 3
        | Shade4 = 4
        | Shade5 = 5
        | Shade6 = 6
        | Shade7 = 7
        | Shade8 = 8

module __utilities_contextualMenu_contextualMenuUtility =
    type IContextualMenuItem = _.IContextualMenuItem

    type [<AllowNullLiteral>] IExports =
        /// <summary>Determines the effective checked state of a menu item.</summary>
        /// <param name="item">to get the check state of.</param>
        abstract getIsChecked: item: IContextualMenuItem -> bool option
        abstract hasSubmenu: item: IContextualMenuItem -> bool
        abstract isItemDisabled: item: IContextualMenuItem -> bool

module __utilities_dateMath_DateMath =
    type DayOfWeek = __utilities_dateValues_DateValues.DayOfWeek
    type FirstWeekOfYear = __utilities_dateValues_DateValues.FirstWeekOfYear
    type DateRangeType = __utilities_dateValues_DateValues.DateRangeType

    type [<AllowNullLiteral>] IExports =
        /// <summary>Returns a date offset from the given date by the specified number of days.</summary>
        /// <param name="date">- The origin date</param>
        /// <param name="days">- The number of days to offset. 'days' can be negative.</param>
        abstract addDays: date: DateTime * days: float -> DateTime
        /// <summary>Returns a date offset from the given date by the specified number of weeks.</summary>
        /// <param name="date">- The origin date</param>
        /// <param name="weeks">- The number of weeks to offset. 'weeks' can be negative.</param>
        abstract addWeeks: date: DateTime * weeks: float -> DateTime
        /// <summary>Returns a date offset from the given date by the specified number of months.
        /// The method tries to preserve the day-of-month; however, if the new month does not have enough days
        /// to contain the original day-of-month, we'll use the last day of the new month.</summary>
        /// <param name="date">- The origin date</param>
        /// <param name="months">- The number of months to offset. 'months' can be negative.</param>
        abstract addMonths: date: DateTime * months: float -> DateTime
        /// <summary>Returns a date offset from the given date by the specified number of years.
        /// The method tries to preserve the day-of-month; however, if the new month does not have enough days
        /// to contain the original day-of-month, we'll use the last day of the new month.</summary>
        /// <param name="date">- The origin date</param>
        /// <param name="years">- The number of years to offset. 'years' can be negative.</param>
        abstract addYears: date: DateTime * years: float -> DateTime
        /// <summary>Returns a date that is the first day of the month of the provided date.</summary>
        /// <param name="date">- The origin date</param>
        abstract getMonthStart: date: DateTime -> DateTime
        /// <summary>Returns a date that is the last day of the month of the provided date.</summary>
        /// <param name="date">- The origin date</param>
        abstract getMonthEnd: date: DateTime -> DateTime
        /// <summary>Returns a date that is the first day of the year of the provided date.</summary>
        /// <param name="date">- The origin date</param>
        abstract getYearStart: date: DateTime -> DateTime
        /// <summary>Returns a date that is the last day of the year of the provided date.</summary>
        /// <param name="date">- The origin date</param>
        abstract getYearEnd: date: DateTime -> DateTime
        /// <summary>Returns a date that is a copy of the given date, aside from the month changing to the given month.
        ///   The method tries to preserve the day-of-month; however, if the new month does not have enough days
        /// to contain the original day-of-month, we'll use the last day of the new month.</summary>
        /// <param name="date">- The origin date</param>
        /// <param name="month">- The 0-based index of the month to set on the date.</param>
        abstract setMonth: date: DateTime * month: float -> DateTime
        /// Compares two dates, and returns true if the two dates (not accounting for time-of-day) are equal.
        abstract compareDates: date1: DateTime * date2: DateTime -> bool
        /// <summary>Compare the date parts of two dates</summary>
        /// <param name="date1">- The first date to compare</param>
        /// <param name="date2">- The second date to compare</param>
        abstract compareDatePart: date1: DateTime * date2: DateTime -> Number
        /// <summary>Gets the date range array including the specified date. The date range array is calculated as the list
        /// of dates accounting for the specified first day of the week and date range type.</summary>
        /// <param name="date">- The input date</param>
        /// <param name="dateRangeType">- The desired date range type, i.e., day, week, month, etc.</param>
        /// <param name="firstDayOfWeek">- The first day of the week.</param>
        /// <param name="workWeekDays">- The allowed days in work week. If not provided, assumes all days are allowed.</param>
        abstract getDateRangeArray: date: DateTime * dateRangeType: DateRangeType * firstDayOfWeek: DayOfWeek * ?workWeekDays: ResizeArray<DayOfWeek> -> ResizeArray<DateTime>
        /// <summary>Checks whether the specified date is in the given date range.</summary>
        /// <param name="date">- The origin date</param>
        /// <param name="dateRange">- An array of dates to do the lookup on</param>
        abstract isInDateRangeArray: date: DateTime * dateRange: ResizeArray<DateTime> -> bool
        /// Returns the week number for a date.
        /// Week numbers are 1 - 52 (53) in a year
        abstract getWeekNumbersInMonth: weeksInMonth: float * firstDayOfWeek: DayOfWeek * firstWeekOfYear: FirstWeekOfYear * navigatedDate: DateTime -> ResizeArray<float>
        /// <summary>Returns the week number for a date.
        /// Week numbers are 1 - 52 (53) in a year</summary>
        /// <param name="date">- A date to find the week number for.</param>
        /// <param name="firstDayOfWeek">- The first day of the week (0-6, Sunday = 0)</param>
        /// <param name="firstWeekOfYear">- The first week of the year (1-2)</param>
        abstract getWeekNumber: date: DateTime * firstDayOfWeek: DayOfWeek * firstWeekOfYear: FirstWeekOfYear -> float

module __utilities_dateValues_DateValues =

    type [<RequireQualifiedAccess>] DayOfWeek =
        | Sunday = 0
        | Monday = 1
        | Tuesday = 2
        | Wednesday = 3
        | Thursday = 4
        | Friday = 5
        | Saturday = 6

    type [<RequireQualifiedAccess>] MonthOfYear =
        | January = 0
        | February = 1
        | March = 2
        | April = 3
        | May = 4
        | June = 5
        | July = 6
        | August = 7
        | September = 8
        | October = 9
        | November = 10
        | December = 11

    type [<RequireQualifiedAccess>] FirstWeekOfYear =
        | FirstDay = 0
        | FirstFullWeek = 1
        | FirstFourDayWeek = 2

    type [<RequireQualifiedAccess>] DateRangeType =
        | Day = 0
        | Week = 1
        | Month = 2
        | WorkWeek = 3

module __utilities_dateValues_TimeConstants =

    type [<AllowNullLiteral>] IExports =
        abstract TimeConstants: obj

module __utilities_decorators_BaseDecorator =
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract BaseDecorator: BaseDecoratorStatic

    type [<AllowNullLiteral>] BaseDecorator<'TProps, 'TState> =
        inherit BaseComponent<'TProps, 'TState>
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract _composedComponentInstance: React.Component<'TProps, 'TState> with get, set
        abstract _hoisted: obj with get, set
        /// Updates the ref to the component composed by the decorator, which will also take care of hoisting
        /// (and unhoisting as appropriate) methods from said component.
        /// 
        /// Pass this method as the argument to the 'ref' property of the composed component.
        abstract _updateComposedComponentRef: composedComponentInstance: React.Component<'TProps, 'TState> -> unit

    type [<AllowNullLiteral>] BaseDecoratorStatic =
        [<Emit "new $0($1...)">] abstract Create: props: 'TProps -> BaseDecorator<'TProps, 'TState>

module __utilities_decorators_withContainsFocus =

    type [<AllowNullLiteral>] IExports =
        abstract withContainsFocus: ComposedComponent: obj -> obj option

module __utilities_decorators_withResponsiveMode =

    type [<AllowNullLiteral>] IExports =
        /// Allows a server rendered scenario to provide a default responsive mode.
        abstract setResponsiveMode: responsiveMode: ResponsiveMode option -> unit
        abstract withResponsiveMode: ComposedComponent: obj -> obj option

    type [<AllowNullLiteral>] IWithResponsiveModeState =
        abstract responsiveMode: ResponsiveMode option with get, set

    type [<RequireQualifiedAccess>] ResponsiveMode =
        | Small = 0
        | Medium = 1
        | Large = 2
        | XLarge = 3
        | XxLarge = 4
        | XxxLarge = 5

module __utilities_decorators_withViewport =

    type [<AllowNullLiteral>] IExports =
        abstract withViewport: ComposedComponent: obj -> obj option

    type [<AllowNullLiteral>] IViewport =
        abstract width: float with get, set
        abstract height: float with get, set

    type [<AllowNullLiteral>] IWithViewportState =
        abstract viewport: IViewport option with get, set

    type [<AllowNullLiteral>] IWithViewportProps =
        abstract skipViewportMeasures: bool option with get, set

module __utilities_dragdrop_DragDropHelper =
    type EventGroup = Utilities.EventGroup
    type IDragDropHelper = __utilities_dragdrop_interfaces.IDragDropHelper
    type IDragDropOptions = __utilities_dragdrop_interfaces.IDragDropOptions
    type ISelection = __utilities_selection_interfaces.ISelection

    type [<AllowNullLiteral>] IExports =
        abstract DragDropHelper: DragDropHelperStatic

    type [<AllowNullLiteral>] IDragDropHelperParams =
        abstract selection: ISelection with get, set
        abstract minimumPixelsForDrag: float option with get, set

    type [<AllowNullLiteral>] DragDropHelper =
        inherit IDragDropHelper
        abstract _dragEnterCounts: obj with get, set
        abstract _distanceSquaredForDrag: obj
        abstract _isDragging: obj with get, set
        abstract _dragData: obj with get, set
        abstract _selection: obj with get, set
        abstract _activeTargets: obj with get, set
        abstract _events: obj with get, set
        abstract _lastId: obj with get, set
        abstract dispose: unit -> unit
        abstract subscribe: root: HTMLElement * events: EventGroup * dragDropOptions: IDragDropOptions -> obj
        abstract unsubscribe: root: HTMLElement * key: string -> unit
        abstract _onDragEnd: target: obj * ``event``: obj -> unit
        /// clear drag data when mouse up on body
        abstract _onMouseUp: ``event``: obj -> unit
        /// clear drag data when mouse up outside of the document
        abstract _onDocumentMouseUp: ``event``: obj -> unit
        /// when mouse move over a new drop target while dragging some items,
        /// fire dragleave on the old target and fire dragenter to the new target
        /// The target will handle style change on dragenter and dragleave events.
        abstract _onMouseMove: target: obj * ``event``: obj -> unit
        /// when mouse leave a target while dragging some items, fire dragleave to the target
        abstract _onMouseLeave: target: obj * ``event``: obj -> unit
        /// when mouse down on a draggable item, we start to track dragdata.
        abstract _onMouseDown: target: obj * ``event``: obj -> unit
        /// determine whether the child target is a descendant of the parent
        abstract _isChild: parent: obj * child: obj -> unit
        abstract _isDraggable: target: obj -> unit
        abstract _isDroppable: target: obj -> unit

    type [<AllowNullLiteral>] DragDropHelperStatic =
        [<Emit "new $0($1...)">] abstract Create: ``params``: IDragDropHelperParams -> DragDropHelper

module __utilities_dragdrop_interfaces =
    type EventGroup = Utilities.EventGroup

    type [<AllowNullLiteral>] IDragDropHelper =
        abstract subscribe: (HTMLElement -> EventGroup -> IDragDropOptions -> obj) with get, set
        abstract unsubscribe: (HTMLElement -> string -> unit) with get, set
        abstract dispose: (unit -> unit) with get, set

    type [<AllowNullLiteral>] IDragDropEvents =
        abstract canDrop: (IDragDropContext -> IDragDropContext -> bool) option with get, set
        abstract canDrag: (obj option -> bool) option with get, set
        abstract onDragEnter: (obj option -> DragEvent -> string) option with get, set
        abstract onDragLeave: (obj option -> DragEvent -> unit) option with get, set
        abstract onDrop: (obj option -> DragEvent -> unit) option with get, set
        abstract onDragStart: (obj option -> float -> ResizeArray<obj option> -> MouseEvent -> unit) option with get, set
        abstract onDragEnd: (obj option -> DragEvent -> unit) option with get, set

    type [<AllowNullLiteral>] IDragDropContext =
        abstract data: obj option with get, set
        abstract index: float with get, set
        abstract isGroup: bool option with get, set

    type [<AllowNullLiteral>] IDragDropTarget =
        abstract root: React.ReactInstance with get, set
        abstract options: IDragDropOptions with get, set
        abstract key: string with get, set

    type [<AllowNullLiteral>] IDragDropOptions =
        abstract key: string option with get, set
        abstract eventMap: ResizeArray<obj> option with get, set
        abstract selectionIndex: float with get, set
        abstract context: IDragDropContext with get, set
        abstract updateDropState: (bool -> DragEvent -> unit) with get, set
        abstract canDrop: (IDragDropContext -> IDragDropContext -> bool) option with get, set
        abstract canDrag: (obj option -> bool) option with get, set
        abstract onDragStart: (obj option -> float -> ResizeArray<obj option> -> MouseEvent -> unit) option with get, set
        abstract onDrop: (obj option -> DragEvent -> unit) option with get, set
        abstract onDragEnd: (obj option -> DragEvent -> unit) option with get, set
        abstract onDragOver: (obj option -> DragEvent -> unit) option with get, set

    type [<AllowNullLiteral>] IDragDropEvent =
        abstract isHandled: bool option with get, set

module __utilities_grid_Grid_base =
    type BaseComponent = Utilities.BaseComponent
    type IGrid = __utilities_grid_Grid_types.IGrid
    type IGridProps = __utilities_grid_Grid_types.IGridProps

    type [<AllowNullLiteral>] IExports =
        abstract GridBase: GridBaseStatic

    type [<AllowNullLiteral>] GridBase =
        inherit BaseComponent<IGridProps, obj>
        inherit IGrid
        abstract _id: obj with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] GridBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IGridProps -> GridBase

module __utilities_grid_Grid =
    type IGridProps = __utilities_grid_Grid_types.IGridProps

    type [<AllowNullLiteral>] IExports =
        abstract Grid: (IGridProps -> JSX.Element)

module __utilities_grid_Grid_styles =
    type IGridStyleProps = __utilities_grid_Grid_types.IGridStyleProps
    type IGridStyles = __utilities_grid_Grid_types.IGridStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IGridStyleProps -> IGridStyles)

module __utilities_grid_Grid_types =
    type IStyle = Styling.IStyle
    type ITheme = Styling.ITheme
    type IStyleFunction = Utilities.IStyleFunction

    type [<AllowNullLiteral>] IGrid =
        interface end

    type [<AllowNullLiteral>] IGridProps =
        /// Gets the component ref.
        abstract componentRef: (IGrid option -> unit) option with get, set
        /// The items to turn into a grid
        abstract items: ResizeArray<obj option> with get, set
        /// The number of columns
        abstract columnCount: float with get, set
        /// Custom renderer for the individual items
        abstract onRenderItem: (obj option -> float -> JSX.Element) with get, set
        /// Boolean indicating if the focus should support circular navigation.
        /// This prop is only relevant if doNotcontainWithinFocusZone is not true
        abstract shouldFocusCircularNavigate: bool option with get, set
        /// If true do not contain the grid inside of a FocusZone.
        /// If false contain the grid inside of a FocusZone.
        abstract doNotContainWithinFocusZone: bool option with get, set
        /// Optional, class name for the FocusZone container for the grid
        abstract containerClassName: string option with get, set
        /// Optional, handler for when the grid should blur
        abstract onBlur: (unit -> unit) option with get, set
        /// The optional position this grid is in the parent set (index in a parent menu, for example)
        abstract positionInSet: float option with get, set
        /// The optional size of the parent set (size of parent menu, for example)
        abstract setSize: float option with get, set
        /// Theme to apply to the component.
        abstract theme: ITheme option with get, set
        /// Optional styles for the component.
        abstract getStyles: IStyleFunction<IGridStyleProps, IGridStyles> option with get, set

    /// Properties required to build the styles for the grid component.
    type [<AllowNullLiteral>] IGridStyleProps =
        /// Theme to apply to the grid
        abstract theme: ITheme with get, set

    /// Styles for the Grid Component.
    type [<AllowNullLiteral>] IGridStyles =
        /// Style for the table container of a grid.
        abstract root: IStyle with get, set
        /// Style for the table cells of the grid.
        abstract tableCell: IStyle with get, set
        /// Optional, style for the FocusZone container for the grid
        abstract focusedContainer: IStyle option with get, set

module __utilities_grid_GridCell =
    type IGridCellProps = __utilities_grid_GridCell_types.IGridCellProps

    type [<AllowNullLiteral>] IExports =
        abstract GridCell: GridCellStatic

    type [<AllowNullLiteral>] GridCell<'T, 'P> =
        inherit React.Component<'P, obj>
        abstract defaultProps: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onClick: obj with get, set
        abstract _onMouseEnter: obj with get, set
        abstract _onMouseMove: obj with get, set
        abstract _onMouseLeave: obj with get, set
        abstract _onFocus: obj with get, set

    type [<AllowNullLiteral>] GridCellStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> GridCell<'T, 'P>

module __utilities_grid_GridCell_types =
    type IButtonClassNames = __components_Button_BaseButton_classNames.IButtonClassNames
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IGridCellProps<'T> =
        /// The option that will be made available to the user
        abstract item: 'T with get, set
        /// Arbitrary unique string associated with this option
        abstract id: string with get, set
        /// Optional, if the this option should be diabled
        abstract disabled: bool option with get, set
        /// Optional, if the cell is currently selected
        abstract selected: bool option with get, set
        /// The on click handler
        abstract onClick: ('T -> unit) option with get, set
        /// The render callback to handle rendering the item
        abstract onRenderItem: ('T -> JSX.Element) with get, set
        /// Optional, the onHover handler
        abstract onHover: ('T -> unit) option with get, set
        /// Optional, the onFocus handler
        abstract onFocus: ('T -> unit) option with get, set
        /// The accessible role for this option
        abstract role: string option with get, set
        /// Optional, className(s) to apply
        abstract className: string option with get, set
        /// Optional, the CSS class used for when the cell is disabled
        abstract cellDisabledStyle: ResizeArray<string> option with get, set
        /// Optional, the CSS class used for when the cell is selected
        abstract cellIsSelectedStyle: ResizeArray<string> option with get, set
        /// Index for this option
        abstract index: float option with get, set
        /// The label for this item.
        /// Visible text if this item is a header,
        /// tooltip if is this item is normal
        abstract label: string option with get, set
        /// Method to provide the classnames to style a button.
        /// The default value for this prop is the getClassnames func
        /// defined in BaseButton.classnames.
        abstract getClassNames: (ITheme -> string -> string -> string option -> string option -> bool -> bool -> bool -> bool option -> IButtonClassNames) option with get, set
        /// Optional, mouseEnter handler.
        abstract onMouseEnter: (React.MouseEvent<HTMLButtonElement> -> bool) option with get, set
        /// Optional, mouseMove handler
        abstract onMouseMove: (React.MouseEvent<HTMLButtonElement> -> bool) option with get, set
        /// Optional, mouseLeave handler
        abstract onMouseLeave: (React.MouseEvent<HTMLButtonElement> -> unit) option with get, set
        /// Optional, onWheel handler
        abstract onWheel: (React.MouseEvent<HTMLButtonElement> -> unit) option with get, set
        /// Optional, onkeydown handler
        abstract onKeyDown: (React.KeyboardEvent<HTMLButtonElement> -> unit) option with get, set

module __utilities_groupedList_GroupedListUtility =
    type IGroup = __components_GroupedList_GroupedList_types.IGroup

    type [<AllowNullLiteral>] IExports =
        abstract GetGroupCount: (ResizeArray<IGroup> option -> float)

module __utilities_keytips_IKeytipTransitionKey =

    type [<AllowNullLiteral>] IExports =
        /// <summary>Tests for equality between two IKeytipTransitionKeys.</summary>
        /// <param name="key1">- First IKeytipTransitionKey.</param>
        /// <param name="key2">- Second IKeytipTransitionKey.</param>
        abstract transitionKeysAreEqual: key1: IKeytipTransitionKey * key2: IKeytipTransitionKey -> bool
        /// <summary>Tests if 'key' is present in 'keys'.</summary>
        /// <param name="keys">- Array of IKeytipTransitionKey.</param>
        /// <param name="key">- IKeytipTransitionKey to find in 'keys'.</param>
        abstract transitionKeysContain: keys: ResizeArray<IKeytipTransitionKey> * key: IKeytipTransitionKey -> bool

    type [<RequireQualifiedAccess>] KeytipTransitionModifier =
        | Shift = 16
        | Ctrl = 17
        | Alt = 18
        | Meta = 91

    type [<AllowNullLiteral>] IKeytipTransitionKey =
        abstract key: string with get, set
        abstract modifierKeys: ResizeArray<KeytipTransitionModifier> option with get, set

module __utilities_keytips_KeytipConfig =
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IExports =
        /// <summary>Builds a map of ID -> IKeytipProps</summary>
        /// <param name="config">- IKeytipConfig object</param>
        abstract buildKeytipConfigMap: config: IKeytipConfig -> IKeytipConfigMap
        /// <summary>Constructs a keytip from an IKeytipConfigItem and puts it in the configMap</summary>
        /// <param name="configMap">- IKeytipConfigMap to store the keytip in</param>
        /// <param name="parentSequence">- string of the parent keytip</param>
        /// <param name="keytip">- IKeytipConfigItem data</param>
        abstract constructKeytip: configMap: IKeytipConfigMap * parentSequence: ResizeArray<string> * keytip: IKeytipConfigItem -> unit

    type [<AllowNullLiteral>] IKeytipConfig =
        abstract keytips: ResizeArray<IKeytipConfigItem> with get, set

    type [<AllowNullLiteral>] IKeytipConfigItem =
        /// Key Sequence for this keytip only
        /// If sequence is not defined it will be derived from the content string
        abstract sequence: string option with get, set
        /// Content for the keytip
        abstract content: string with get, set
        /// Identifier for the keytip, to be used to access in the configMap
        abstract id: string with get, set
        /// Optional props in IKeytipProps
        abstract optionalProps: obj option with get, set
        /// Children keytips of this keytip
        abstract children: ResizeArray<IKeytipConfigItem> option with get, set

    type [<AllowNullLiteral>] IKeytipConfigMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: id: string -> IKeytipProps with get, set

module __utilities_keytips_KeytipConstants =

    type [<AllowNullLiteral>] IExports =
        abstract KTP_PREFIX: obj
        abstract KTP_SEPARATOR: obj
        abstract KTP_FULL_PREFIX: string
        abstract DATAKTP_TARGET: obj
        abstract DATAKTP_EXECUTE_TARGET: obj
        abstract KTP_LAYER_ID: obj
        abstract KTP_ARIA_SEPARATOR: obj

    module KeytipEvents =

        type [<AllowNullLiteral>] IExports =
            abstract KEYTIP_ADDED: obj
            abstract KEYTIP_REMOVED: obj
            abstract KEYTIP_UPDATED: obj
            abstract PERSISTED_KEYTIP_ADDED: obj
            abstract PERSISTED_KEYTIP_REMOVED: obj
            abstract PERSISTED_KEYTIP_EXECUTE: obj
            abstract ENTER_KEYTIP_MODE: obj
            abstract EXIT_KEYTIP_MODE: obj

module __utilities_keytips_KeytipManager =
    type IKeytipProps = Keytip.IKeytipProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipManager: KeytipManagerStatic

    type [<AllowNullLiteral>] IUniqueKeytip =
        abstract uniqueID: string with get, set
        abstract keytip: IKeytipProps with get, set

    /// This class is responsible for handling registering, updating, and unregistering of keytips
    type [<AllowNullLiteral>] KeytipManager =
        abstract _instance: obj with get, set
        abstract keytips: ResizeArray<IUniqueKeytip> with get, set
        abstract persistedKeytips: ResizeArray<IUniqueKeytip> with get, set
        abstract inKeytipMode: bool with get, set
        abstract shouldEnterKeytipMode: bool with get, set
        /// <summary>Registers a keytip</summary>
        /// <param name="keytipProps">- Keytip to register</param>
        /// <param name="persisted">- T/F if this keytip should be persisted, default is false</param>
        abstract register: keytipProps: IKeytipProps * ?persisted: bool -> string
        /// <summary>Update a keytip</summary>
        /// <param name="keytipProps">- Keytip to update</param>
        /// <param name="uniqueID">- Unique ID of this keytip</param>
        abstract update: keytipProps: IKeytipProps * uniqueID: string -> unit
        /// <summary>Unregisters a keytip</summary>
        /// <param name="keytipToRemove">- IKeytipProps of the keytip to remove</param>
        /// <param name="uniqueID">- Unique ID of this keytip</param>
        /// <param name="persisted">- T/F if this keytip should be persisted, default is false</param>
        abstract unregister: keytipToRemove: IKeytipProps * uniqueID: string * ?persisted: bool -> unit
        /// Manual call to enter keytip mode
        abstract enterKeytipMode: unit -> unit
        /// Manual call to exit keytip mode
        abstract exitKeytipMode: unit -> unit
        /// Gets all IKeytipProps from this.keytips
        abstract getKeytips: unit -> ResizeArray<IKeytipProps>
        /// <summary>Adds the overflowSetSequence to the keytipProps if its parent keytip also has it</summary>
        /// <param name="keytipProps">- Keytip props to add overflowSetSequence to if necessary</param>
        abstract addParentOverflow: keytipProps: IKeytipProps -> IKeytipProps
        /// <summary>Public function to bind for overflow items that have a submenu</summary>
        /// <param name="overflowButtonSequences"></param>
        /// <param name="keytipSequences"></param>
        abstract menuExecute: overflowButtonSequences: ResizeArray<string> * keytipSequences: ResizeArray<string> -> unit
        /// <summary>Creates an IUniqueKeytip object</summary>
        /// <param name="keytipProps">- IKeytipProps</param>
        /// <param name="uniqueID">- Unique ID, will default to the next unique ID if not passed</param>
        abstract _getUniqueKtp: keytipProps: obj * ?uniqueID: obj -> unit

    /// This class is responsible for handling registering, updating, and unregistering of keytips
    type [<AllowNullLiteral>] KeytipManagerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> KeytipManager
        /// Static function to get singleton KeytipManager instance
        abstract getInstance: unit -> KeytipManager

module __utilities_keytips_KeytipUtils =

    type [<AllowNullLiteral>] IExports =
        /// <summary>Converts a whole set of KeySequences into one keytip ID, which will be the ID for the last keytip sequence specified
        /// keySequences should not include the initial keytip 'start' sequence.</summary>
        /// <param name="keySequences">- Full path of IKeySequences for one keytip.</param>
        abstract sequencesToID: keySequences: ResizeArray<string> -> string
        /// <summary>Merges an overflow sequence with a key sequence.</summary>
        /// <param name="keySequences">- Full sequence for one keytip.</param>
        /// <param name="overflowKeySequences">- Full overflow keytip sequence.</param>
        abstract mergeOverflows: keySequences: ResizeArray<string> * overflowKeySequences: ResizeArray<string> -> ResizeArray<string>
        /// <summary>Constructs the data-ktp-target attribute selector from a full key sequence.</summary>
        /// <param name="keySequences">- Full string[] for a Keytip.</param>
        abstract ktpTargetFromSequences: keySequences: ResizeArray<string> -> string
        /// <summary>Constructs the data-ktp-execute-target attribute selector from a keytip ID.</summary>
        /// <param name="keytipId">- ID of the Keytip.</param>
        abstract ktpTargetFromId: keytipId: string -> string
        /// <summary>Gets the aria-describedby value to put on the component with this keytip.</summary>
        /// <param name="keySequences">- KeySequences of the keytip.</param>
        abstract getAriaDescribedBy: keySequences: ResizeArray<string> -> string

module __utilities_positioning_positioning =
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type FullRectangle = Utilities.Rectangle
    type IRectangle = Utilities.IRectangle
    type IPositionDirectionalHintData = __utilities_positioning_positioning_types.IPositionDirectionalHintData
    type IPositionedData = __utilities_positioning_positioning_types.IPositionedData
    type IPoint = __utilities_positioning_positioning_types.IPoint
    type ICalloutPositionedInfo = __utilities_positioning_positioning_types.ICalloutPositionedInfo
    type IPositionProps = __utilities_positioning_positioning_types.IPositionProps
    type RectangleEdge = __utilities_positioning_positioning_types.RectangleEdge
    type IRelativePositions = __utilities_positioning_positioning_types.IRelativePositions

    type [<AllowNullLiteral>] IExports =
        abstract Rectangle: RectangleStatic
        abstract __positioningTestPackage: obj
        /// <param name="props"></param>
        /// <param name="hostElement"></param>
        /// <param name="elementToPosition"></param>
        abstract _getRelativePositions: props: IPositionProps * hostElement: HTMLElement * elementToPosition: HTMLElement -> IRelativePositions
        /// <param name="props"></param>
        /// <param name="hostElement"></param>
        /// <param name="calloutElement"></param>
        abstract getRelativePositions: props: IPositionProps * hostElement: HTMLElement * calloutElement: HTMLElement -> IRelativePositions
        /// <summary>Used to position an element relative to the given positioning props.
        /// If positioning has been completed before, previousPositioningData
        /// can be passed to ensure that the positioning element repositions based on
        /// its previous targets rather than starting with directionalhint.</summary>
        /// <param name="props"></param>
        /// <param name="hostElement"></param>
        /// <param name="elementToPosition"></param>
        /// <param name="previousPositions"></param>
        abstract positionElement: props: IPositionProps * hostElement: HTMLElement * elementToPosition: HTMLElement * ?previousPositions: IPositionedData -> IPositionedData
        abstract positionCallout: props: IPositionProps * hostElement: HTMLElement * elementToPosition: HTMLElement * ?previousPositions: ICalloutPositionedInfo -> ICalloutPositionedInfo
        /// Get's the maximum height that a rectangle can have in order to fit below or above a target.
        /// If the directional hint specifies a left or right edge (i.e. leftCenter) it will limit the height to the topBorder
        /// of the target given.
        /// If no bounds are provided then the window is treated as the bounds.
        abstract getMaxHeight: target: U3<Element, MouseEvent, IPoint> * targetEdge: DirectionalHint * ?gapSpace: float * ?bounds: IRectangle * ?coverTarget: bool -> float

    type [<AllowNullLiteral>] Rectangle =
        inherit FullRectangle
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U3<float, bool, obj option> with get, set

    type [<AllowNullLiteral>] RectangleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Rectangle

    /// Do not call methods from this directly, use either positionCallout or positionElement or make another function that
    /// utilizes them.
    /// START Private functions and interfaces
    type [<AllowNullLiteral>] IElementPosition =
        abstract elementRectangle: Rectangle with get, set
        abstract targetEdge: RectangleEdge with get, set
        abstract alignmentEdge: RectangleEdge option with get, set

    type [<AllowNullLiteral>] IElementPositionInfo =
        inherit IElementPosition
        abstract targetRectangle: Rectangle with get, set

module __utilities_positioning_positioning_types =
    type DirectionalHint = __common_DirectionalHint.DirectionalHint
    type IPoint = __utilities_positioning_positioning_types.IPoint
    type IRectangle = Utilities.IRectangle

    type [<RequireQualifiedAccess>] RectangleEdge =
        | Top = 1
        | Bottom = -1
        | Left = 2
        | Right = -2

    type [<RequireQualifiedAccess>] Position =
        | Top = 0
        | Bottom = 1
        | Start = 2
        | End = 3

    type [<AllowNullLiteral>] IPositionProps =
        abstract target: U3<Element, MouseEvent, IPoint> option with get, set
        /// how the element should be positioned 
        abstract directionalHint: DirectionalHint option with get, set
        /// How the element should be positioned in RTL layouts.
        /// If not specified, a mirror of `directionalHint` will be used instead
        abstract directionalHintForRTL: DirectionalHint option with get, set
        /// The gap between the callout and the target 
        abstract gapSpace: float option with get, set
        abstract beakWidth: float option with get, set
        /// The bounding rectangle for which  the contextual menu can appear in.
        abstract bounds: IRectangle option with get, set
        abstract isBeakVisible: bool option with get, set
        /// If true the position returned will have the menu element cover the target.
        /// If false then it will position next to the target;
        abstract coverTarget: bool option with get, set
        /// If true the position will not change edges in an attempt to fit the rectangle within bounds.
        /// It will still attempt to align it to whatever bounds are given.
        abstract directionalHintFixed: bool option with get, set

    type [<AllowNullLiteral>] ICalloutPositionProps =
        inherit IPositionProps
        /// The width of the beak.
        abstract beakWidth: float option with get, set
        abstract isBeakVisible: bool option with get, set

    type [<AllowNullLiteral>] IPositionedData =
        inherit IPositionDirectionalHintData
        /// The new position of the element.
        abstract elementPosition: IPosition with get, set
        /// The finalized target edge that element is aligning to. For instance RectangleEdge.bottom would mean
        /// that the bottom edge of the target is being aligned to by the RectangleEdge.top of the element
        /// that is being positioned.
        abstract targetEdge: RectangleEdge with get, set
        /// The finalized alignment edge that the element is aligning too. For instance, RectangleEdge.left means
        /// that the left edge of the target should be in line with the left edge of the element being positioned.
        abstract alignmentEdge: RectangleEdge option with get, set

    type [<AllowNullLiteral>] ICalloutPositionedInfo =
        inherit IPositionedData
        abstract beakPosition: ICalloutBeakPositionedInfo with get, set

    type [<AllowNullLiteral>] ICalloutBeakPositionedInfo =
        inherit IPositionedData
        abstract closestEdge: RectangleEdge with get, set

    /// Gives the position of some element on the page. Only a pair of vertical and horizontal edges need to be
    /// given. So top/left or bottom/left is sufficient.
    /// The number given is the distance in pixels from whatever host was given..
    /// So bottom: 100 would be 100px up from the bottom of the host while top: 100px from the top.
    type [<AllowNullLiteral>] IPosition =
        abstract top: float option with get, set
        abstract left: float option with get, set
        abstract bottom: float option with get, set
        abstract right: float option with get, set
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> float option with get, set

    type [<AllowNullLiteral>] ICalloutPositon =
        inherit IPosition

    type [<AllowNullLiteral>] IPoint =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] IPositionDirectionalHintData =
        abstract targetEdge: RectangleEdge with get, set
        abstract alignmentEdge: RectangleEdge option with get, set
        abstract isAuto: bool option with get, set

    type [<AllowNullLiteral>] IRelativePositions =
        abstract calloutPosition: ICalloutPositon with get, set
        abstract beakPosition: obj with get, set
        abstract directionalClassName: string with get, set
        abstract submenuDirection: DirectionalHint with get, set

module __utilities_router_Route =

    type [<AllowNullLiteral>] IExports =
        abstract Route: RouteStatic

    type [<AllowNullLiteral>] IRouteProps =
        abstract path: string option with get, set
        abstract ``component``: React.Component<obj option, obj option> option with get, set
        abstract getComponent: (obj option -> unit) option with get, set

    type [<AllowNullLiteral>] Route =
        inherit React.Component<obj option, obj option>

    type [<AllowNullLiteral>] RouteStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Route

module __utilities_router_Router =
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract Router: RouterStatic

    type [<AllowNullLiteral>] IRouterProps =
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        abstract replaceState: bool option with get, set
        abstract children: obj option with get, set
        abstract onNewRouteLoaded: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] Router =
        inherit BaseComponent<IRouterProps, obj>
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element option
        abstract _getPath: unit -> unit
        abstract _resolveRoute: ?path: obj * ?children: obj -> unit

    type [<AllowNullLiteral>] RouterStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Router

module __utilities_selectableOption_SelectableDroppableText_types =
    type IRenderFunction = Utilities.IRenderFunction
    type ICalloutProps = Callout.ICalloutProps
    type IPanelProps = Panel.IPanelProps
    type ISelectableOption = __utilities_selectableOption_SelectableOption_types.ISelectableOption

    type [<AllowNullLiteral>] ISelectableDroppableTextProps<'T> =
        inherit React.HTMLAttributes<'T>
        /// Optional callback to access the ISelectableDroppableText interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: ('T option -> unit) option with get, set
        /// Descriptive label for the ISelectableDroppableText
        abstract label: string option with get, set
        /// Aria Label for the ISelectableDroppableText for screen reader users.
        abstract ariaLabel: string option with get, set
        /// Id of the ISelectableDroppableText
        abstract id: string option with get, set
        /// If provided, additional class name to provide on the root element.
        abstract className: string option with get, set
        /// The key(s) that will be initially used to set a selected item.
        abstract defaultSelectedKey: U4<string, float, ResizeArray<string>, ResizeArray<float>> option with get, set
        /// The key(s) of the selected item. If you provide this, you must maintain selection
        /// state by observing onChange events and passing a new value in when changed.
        abstract selectedKey: U4<string, float, ResizeArray<string>, ResizeArray<float>> option with get, set
        /// Collection of options for this ISelectableDroppableText
        abstract options: obj option with get, set
        /// Callback issues when the selected option changes
        abstract onChanged: (ISelectableOption -> float -> unit) option with get, set
        /// Optional custom renderer for the ISelectableDroppableText container
        abstract onRenderContainer: IRenderFunction<ISelectableDroppableTextProps<'T>> option with get, set
        /// Optional custom renderer for the ISelectableDroppableText list
        abstract onRenderList: IRenderFunction<ISelectableDroppableTextProps<'T>> option with get, set
        /// Optional custom renderer for the ISelectableDroppableText options
        abstract onRenderItem: IRenderFunction<ISelectableOption> option with get, set
        /// Optional custom renderer for the ISelectableDroppableText option content
        abstract onRenderOption: IRenderFunction<ISelectableOption> option with get, set
        /// Whether or not the ISelectableDroppableText is disabled.
        abstract disabled: bool option with get, set
        /// Whether or not the ISelectableDroppableText is required.
        abstract required: bool option with get, set
        /// Custom properties for ISelectableDroppableText's Callout used to render options.
        abstract calloutProps: ICalloutProps option with get, set
        /// Custom properties for ISelectableDroppableText's Panel used to render options on small devices.
        abstract panelProps: IPanelProps option with get, set
        /// Descriptive label for the ISelectableDroppableText Error Message
        abstract errorMessage: string option with get, set

module __utilities_selectableOption_SelectableOption_types =

    type [<AllowNullLiteral>] ISelectableOption =
        /// Arbitrary string associated with this option.
        abstract key: U2<string, float> with get, set
        /// Text to render for this option
        abstract text: string with get, set
        /// Text to render for this option
        abstract itemType: SelectableOptionMenuItemType option with get, set
        /// Index for this option
        abstract index: float option with get, set
        /// The aria label for the dropdown option. If not present, the `text` will be used.
        abstract ariaLabel: string option with get, set
        /// If option is selected. 
        abstract selected: bool option with get, set
        /// Whether the option is disabled
        abstract disabled: bool option with get, set

    type [<RequireQualifiedAccess>] SelectableOptionMenuItemType =
        | Normal = 0
        | Divider = 1
        | Header = 2

module __utilities_selection_interfaces =

    type [<AllowNullLiteral>] IExports =
        abstract SELECTION_CHANGE: obj

    type [<AllowNullLiteral>] IObjectWithKey =
        abstract key: U2<string, float> option with get, set

    type [<RequireQualifiedAccess>] SelectionMode =
        | None = 0
        | Single = 1
        | Multiple = 2

    type [<AllowNullLiteral>] ISelection =
        abstract count: float with get, set
        abstract mode: SelectionMode with get, set
        abstract canSelectItem: (IObjectWithKey -> bool) with get, set
        abstract setChangeEvents: isEnabled: bool * ?suppressChange: bool -> unit
        abstract setItems: items: ResizeArray<IObjectWithKey> * shouldClear: bool -> unit
        abstract getItems: unit -> ResizeArray<IObjectWithKey>
        abstract getSelection: unit -> ResizeArray<IObjectWithKey>
        abstract getSelectedIndices: unit -> ResizeArray<float>
        abstract getSelectedCount: unit -> float
        abstract isRangeSelected: fromIndex: float * count: float -> bool
        abstract isAllSelected: unit -> bool
        abstract isKeySelected: key: string -> bool
        abstract isIndexSelected: index: float -> bool
        abstract isModal: unit -> bool
        abstract setAllSelected: isAllSelected: bool -> unit
        abstract setKeySelected: key: string * isSelected: bool * shouldAnchor: bool -> unit
        abstract setIndexSelected: index: float * isSelected: bool * shouldAnchor: bool -> unit
        abstract setModal: isModal: bool -> unit
        abstract selectToKey: key: string * ?clearSelection: bool -> unit
        abstract selectToIndex: index: float * ?clearSelection: bool -> unit
        abstract toggleAllSelected: unit -> unit
        abstract toggleKeySelected: key: string -> unit
        abstract toggleIndexSelected: index: float -> unit
        abstract toggleRangeSelected: fromIndex: float * count: float -> unit

    type [<RequireQualifiedAccess>] SelectionDirection =
        | Horizontal = 0
        | Vertical = 1

module __utilities_selection_Selection =
    type IObjectWithKey = __utilities_selection_interfaces.IObjectWithKey
    type ISelection = __utilities_selection_interfaces.ISelection
    type SelectionMode = __utilities_selection_interfaces.SelectionMode

    type [<AllowNullLiteral>] IExports =
        abstract Selection: SelectionStatic

    type [<AllowNullLiteral>] ISelectionOptions =
        abstract onSelectionChanged: (unit -> unit) option with get, set
        abstract getKey: (IObjectWithKey -> float -> U2<string, float>) option with get, set
        abstract canSelectItem: (IObjectWithKey -> bool) option with get, set
        abstract selectionMode: SelectionMode option with get, set

    type [<AllowNullLiteral>] Selection =
        inherit ISelection
        abstract count: float with get, set
        abstract mode: SelectionMode
        abstract _getKey: obj with get, set
        abstract _canSelectItem: obj with get, set
        abstract _changeEventSuppressionCount: obj with get, set
        abstract _items: obj with get, set
        abstract _selectedItems: obj with get, set
        abstract _selectedIndices: obj with get, set
        abstract _isAllSelected: obj with get, set
        abstract _exemptedIndices: obj with get, set
        abstract _exemptedCount: obj with get, set
        abstract _keyToIndexMap: obj with get, set
        abstract _anchoredIndex: obj with get, set
        abstract _onSelectionChanged: obj with get, set
        abstract _hasChanged: obj with get, set
        abstract _unselectableIndices: obj with get, set
        abstract _unselectableCount: obj with get, set
        abstract _isModal: obj with get, set
        abstract canSelectItem: item: IObjectWithKey -> bool
        abstract getKey: item: IObjectWithKey * ?index: float -> string
        abstract setChangeEvents: isEnabled: bool * ?suppressChange: bool -> unit
        abstract isModal: unit -> bool
        abstract setModal: isModal: bool -> unit
        /// Selection needs the items, call this method to set them. If the set
        /// of items is the same, this will re-evaluate selection and index maps.
        /// Otherwise, shouldClear should be set to true, so that selection is
        /// cleared.
        abstract setItems: items: ResizeArray<IObjectWithKey> * ?shouldClear: bool -> unit
        abstract getItems: unit -> ResizeArray<IObjectWithKey>
        abstract getSelection: unit -> ResizeArray<IObjectWithKey>
        abstract getSelectedCount: unit -> float
        abstract getSelectedIndices: unit -> ResizeArray<float>
        abstract isRangeSelected: fromIndex: float * count: float -> bool
        abstract isAllSelected: unit -> bool
        abstract isKeySelected: key: string -> bool
        abstract isIndexSelected: index: float -> bool
        abstract setAllSelected: isAllSelected: bool -> unit
        abstract setKeySelected: key: string * isSelected: bool * shouldAnchor: bool -> unit
        abstract setIndexSelected: index: float * isSelected: bool * shouldAnchor: bool -> unit
        abstract selectToKey: key: string * ?clearSelection: bool -> unit
        abstract selectToIndex: index: float * ?clearSelection: bool -> unit
        abstract toggleAllSelected: unit -> unit
        abstract toggleKeySelected: key: string -> unit
        abstract toggleIndexSelected: index: float -> unit
        abstract toggleRangeSelected: fromIndex: float * count: float -> unit
        abstract _updateCount: unit -> unit
        abstract _change: unit -> unit

    type [<AllowNullLiteral>] SelectionStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: ISelectionOptions -> Selection

module __utilities_selection_SelectionPage =
    type IComponentDemoPageProps = __utilities_selection_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SelectionPage: SelectionPageStatic

    type [<AllowNullLiteral>] SelectionPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SelectionPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SelectionPage

module __utilities_selection_SelectionZone =
    type BaseComponent = Utilities.BaseComponent
    type ISelection = __utilities_selection_interfaces.ISelection
    type SelectionMode = __utilities_selection_interfaces.SelectionMode
    type IObjectWithKey = __utilities_selection_interfaces.IObjectWithKey

    type [<AllowNullLiteral>] IExports =
        abstract SelectionZone: SelectionZoneStatic

    type [<AllowNullLiteral>] ISelectionZone =
        abstract ignoreNextFocus: (unit -> unit) with get, set

    type [<AllowNullLiteral>] ISelectionZoneProps =
        inherit React.Props<SelectionZone>
        abstract componentRef: (unit -> unit) option with get, set
        abstract selection: ISelection with get, set
        abstract layout: obj option with get, set
        abstract selectionMode: SelectionMode option with get, set
        abstract selectionPreservedOnEmptyClick: bool option with get, set
        abstract disableAutoSelectOnInputElements: bool option with get, set
        abstract enterModalOnTouch: bool option with get, set
        abstract isSelectedOnFocus: bool option with get, set
        abstract onItemInvoked: (IObjectWithKey -> float -> Event -> unit) option with get, set
        abstract onItemContextMenu: (obj option -> float -> Event -> U2<unit, bool>) option with get, set

    type [<AllowNullLiteral>] SelectionZone =
        inherit BaseComponent<ISelectionZoneProps, obj>
        abstract defaultProps: obj with get, set
        abstract _root: obj with get, set
        abstract _isCtrlPressed: obj with get, set
        abstract _isShiftPressed: obj with get, set
        abstract _isMetaPressed: obj with get, set
        abstract _shouldHandleFocus: obj with get, set
        abstract _shouldHandleFocusTimeoutId: obj with get, set
        abstract _isTouch: obj with get, set
        abstract _isTouchTimeoutId: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element
        /// In some cases, the consuming scenario requires to set focus on a row without having SelectionZone
        /// react to the event. Note that focus events in IE <= 11 will occur asynchronously after .focus() has
        /// been called on an element, so we need a flag to store the idea that we will bypass the "next"
        /// focus event that occurs. This method does that.
        abstract ignoreNextFocus: (unit -> unit) with get, set
        abstract _onMouseDownCapture: obj with get, set
        /// When we focus an item, for single/multi select scenarios, we should try to select it immediately
        /// as long as the focus did not originate from a mouse down/touch event. For those cases, we handle them
        /// specially.
        abstract _onFocus: obj with get, set
        abstract _onMouseDown: obj with get, set
        abstract _onTouchStartCapture: obj with get, set
        abstract _onClick: obj with get, set
        abstract _onContextMenu: obj with get, set
        abstract _isSelectionDisabled: target: obj -> unit
        /// In multi selection, if you double click within an item's root (but not within the invoke element or input elements),
        /// we should execute the invoke handler.
        abstract _onDoubleClick: obj with get, set
        abstract _onKeyDownCapture: obj with get, set
        abstract _onKeyDown: obj with get, set
        abstract _onToggleAllClick: ev: obj -> unit
        abstract _onToggleClick: ev: obj * index: obj -> unit
        abstract _onInvokeClick: ev: obj * index: obj -> unit
        abstract _onItemSurfaceClick: ev: obj * index: obj -> unit
        abstract _onInvokeMouseDown: ev: obj * index: obj -> unit
        abstract _tryClearOnEmptyClick: ev: obj -> unit
        abstract _clearAndSelectIndex: index: obj -> unit
        /// We need to track the modifier key states so that when focus events occur, which do not contain
        /// modifier states in the Event object, we know how to behave.
        abstract _updateModifiers: ev: obj -> unit
        abstract _findItemRoot: target: obj -> unit
        abstract _getItemIndex: itemRoot: obj -> unit
        abstract _shouldAutoSelect: element: obj -> unit
        abstract _hasAttribute: element: obj * attributeName: obj -> unit
        abstract _isInputElement: element: obj -> unit
        abstract _isNonHandledClick: element: obj -> unit
        abstract _handleNextFocus: handleFocus: obj -> unit
        abstract _setIsTouch: isTouch: obj -> unit
        abstract _getSelectionMode: unit -> unit

    type [<AllowNullLiteral>] SelectionZoneStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SelectionZone

module __components_ActivityItem_examples_ActivityItem_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ActivityItemBasicExample: ActivityItemBasicExampleStatic

    type [<AllowNullLiteral>] ActivityItemBasicExample =
        inherit React.Component<React.Props<ActivityItemBasicExample>, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityItemBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ActivityItemBasicExample

module __components_ActivityItem_examples_ActivityItem_Compact_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ActivityItemCompactExample: ActivityItemCompactExampleStatic

    type [<AllowNullLiteral>] ActivityItemCompactExample =
        inherit React.Component<React.Props<ActivityItemCompactExample>, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityItemCompactExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ActivityItemCompactExample

module __components_ActivityItem_examples_ActivityItem_Example_styles =
    type IStyle = Styling.IStyle

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IActivityItemExampleStyleProps -> IActivityItemExampleStyles)

    type [<AllowNullLiteral>] IActivityItemExampleStyleProps =
        interface end

    type [<AllowNullLiteral>] IActivityItemExampleStyles =
        abstract exampleRoot: IStyle option with get, set
        abstract nameText: IStyle option with get, set

module __components_ActivityItem_examples_ActivityItem_Persona_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ActivityItemPersonaExample: ActivityItemPersonaExampleStatic

    type [<AllowNullLiteral>] ActivityItemPersonaExample =
        inherit React.Component<React.Props<ActivityItemPersonaExample>, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActivityItemPersonaExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ActivityItemPersonaExample

module __components_Breadcrumb_examples_Breadcrumb_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract BreadcrumbBasicExample: BreadcrumbBasicExampleStatic

    type [<AllowNullLiteral>] BreadcrumbBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onBreadcrumbItemClicked: obj with get, set
        abstract _getCustomDivider: obj with get, set

    type [<AllowNullLiteral>] BreadcrumbBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: BreadcrumbBasicExampleStaticProps -> BreadcrumbBasicExample

    type [<AllowNullLiteral>] BreadcrumbBasicExampleStaticProps =
        interface end

module __components_Breadcrumb_examples_Breadcrumb_Static_Example =

    type [<AllowNullLiteral>] IExports =
        abstract BreadcrumbExample: BreadcrumbStaticExampleStatic

    type [<AllowNullLiteral>] BreadcrumbStaticExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onBreadcrumbItemClicked: obj with get, set
        abstract _returnUndefined: unit -> unit

    type [<AllowNullLiteral>] BreadcrumbStaticExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BreadcrumbStaticExample

module __components_Button_ActionButton_ActionButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ActionButton: ActionButtonStatic

    type [<AllowNullLiteral>] ActionButton =
        inherit BaseComponent<IButtonProps, obj>
        /// Tell BaseComponent to bypass resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ActionButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ActionButton

module __components_Button_ActionButton_ActionButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> IButtonStyles)

module __components_Button_CommandBarButton_CommandBarButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract CommandBarButton: CommandBarButtonStatic

    type [<AllowNullLiteral>] CommandBarButton =
        inherit BaseComponent<IButtonProps, obj>
        /// Tell BaseComponent to bypass resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CommandBarButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarButton

module __components_Button_CommandBarButton_CommandBarButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> string option -> string option -> IButtonStyles)

module __components_Button_CommandButton_CommandButton =
    type ActionButton = __components_Button_ActionButton_ActionButton.ActionButton

    type [<AllowNullLiteral>] IExports =
        abstract CommandButton: obj

module __components_Button_CompoundButton_CompoundButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract CompoundButton: CompoundButtonStatic

    type [<AllowNullLiteral>] CompoundButton =
        inherit BaseComponent<IButtonProps, obj>
        /// Tell BaseComponent to bypass resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CompoundButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CompoundButton

module __components_Button_CompoundButton_CompoundButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> bool option -> IButtonStyles)

module __components_Button_DefaultButton_DefaultButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract DefaultButton: DefaultButtonStatic

    type [<AllowNullLiteral>] DefaultButton =
        inherit BaseComponent<IButtonProps, obj>
        /// Tell BaseComponent to bypass resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DefaultButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DefaultButton

module __components_Button_DefaultButton_DefaultButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> bool option -> IButtonStyles)

module __components_Button_examples_Button_Action_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonActionExample: ButtonActionExampleStatic

    type [<AllowNullLiteral>] ButtonActionExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonActionExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ButtonActionExampleStaticProps -> ButtonActionExample

    type [<AllowNullLiteral>] ButtonActionExampleStaticProps =
        interface end

module __components_Button_examples_Button_Anchor_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonAnchorExample: ButtonAnchorExampleStatic

    type [<AllowNullLiteral>] ButtonAnchorExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonAnchorExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonAnchorExample

module __components_Button_examples_Button_Basic_Example_styles =
    type IStyle = Styling.IStyle

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: props: IButtonBasicExampleStyleProps -> IButtonBasicExampleStyles

    type [<AllowNullLiteral>] IButtonBasicExampleStyleProps =
        interface end

    type [<AllowNullLiteral>] IButtonBasicExampleStyles =
        abstract example: IStyle option with get, set
        abstract twoup: IStyle option with get, set

module __components_Button_examples_Button_Command_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonCommandExample: ButtonCommandExampleStatic

    type [<AllowNullLiteral>] ButtonCommandExample =
        inherit React.Component<IButtonProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonCommandExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonCommandExample

module __components_Button_examples_Button_CommandBar_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonCommandBarExample: ButtonCommandBarExampleStatic

    type [<AllowNullLiteral>] ButtonCommandBarExample =
        inherit React.Component<IButtonProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonCommandBarExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonCommandBarExample

module __components_Button_examples_Button_Compound_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonCompoundExample: ButtonCompoundExampleStatic

    type [<AllowNullLiteral>] ButtonCompoundExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonCompoundExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ButtonCompoundExampleStaticProps -> ButtonCompoundExample

    type [<AllowNullLiteral>] ButtonCompoundExampleStaticProps =
        interface end

module __components_Button_examples_Button_ContextualMenu_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonContextualMenuExample: ButtonContextualMenuExampleStatic

    type [<AllowNullLiteral>] ButtonContextualMenuExample =
        inherit React.Component<IButtonProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonContextualMenuExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonContextualMenuExample

module __components_Button_examples_Button_Default_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonDefaultExample: ButtonDefaultExampleStatic

    type [<AllowNullLiteral>] ButtonDefaultExample =
        inherit React.Component<IButtonProps, obj>
        abstract render: unit -> JSX.Element
        abstract _alertClicked: unit -> unit

    type [<AllowNullLiteral>] ButtonDefaultExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonDefaultExample

module __components_Button_examples_Button_Icon_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonIconExample: ButtonIconExampleStatic

    type [<AllowNullLiteral>] ButtonIconExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonIconExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonIconExample

module __components_Button_examples_Button_Primary_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonPrimaryExample: ButtonPrimaryExampleStatic

    type [<AllowNullLiteral>] ButtonPrimaryExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonPrimaryExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonPrimaryExample

module __components_Button_examples_Button_ScreenReader_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonScreenReaderExample: ButtonScreenReaderExampleStatic

    type [<AllowNullLiteral>] ButtonScreenReaderExample =
        inherit React.Component<IButtonProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonScreenReaderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonScreenReaderExample

module __components_Button_examples_Button_Split_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonSplitExample: ButtonSplitExampleStatic
        abstract ButtonSplitCustomExample: ButtonSplitCustomExampleStatic

    type [<AllowNullLiteral>] ButtonSplitExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonSplitExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonSplitExample

    type [<AllowNullLiteral>] ButtonSplitCustomExample =
        inherit React.Component<IButtonProps>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ButtonSplitCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ButtonSplitCustomExample

module __components_Button_examples_Button_Split_Example_styles =
    type IButtonStyles = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonStyles

    type [<AllowNullLiteral>] IExports =
        abstract getCustomSplitButtonStyles: (unit -> IButtonStyles)

module __components_Button_examples_Button_Swap_Example =
    type IButtonProps = __components_Button_examples_office_ui_fabric_react_lib_Button.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract ButtonSwapExample: ButtonSwapExampleStatic

    type [<AllowNullLiteral>] IButtonSwapExampleState =
        abstract isPrimary: bool with get, set

    type [<AllowNullLiteral>] ButtonSwapExample =
        inherit React.Component<IButtonProps, IButtonSwapExampleState>
        abstract buttonRef: obj with get, set
        abstract hasFocus: obj with get, set
        abstract componentWillUpdate: nextProps: IButtonProps * nextState: IButtonSwapExampleState -> unit
        abstract componentDidUpdate: prevProps: IButtonProps * prevState: IButtonSwapExampleState -> unit
        abstract render: unit -> JSX.Element
        abstract _setButtonRef: obj with get, set
        abstract _onClick: obj with get, set

    type [<AllowNullLiteral>] ButtonSwapExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IButtonProps -> ButtonSwapExample

module __components_Button_IconButton_IconButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract IconButton: IconButtonStatic

    type [<AllowNullLiteral>] IconButton =
        inherit BaseComponent<IButtonProps, obj>
        /// Tell BaseComponent to bypass resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] IconButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IconButton

module __components_Button_IconButton_IconButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> IButtonStyles)

module __components_Button_MessageBarButton_MessageBarButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract MessageBarButton: MessageBarButtonStatic

    type [<AllowNullLiteral>] MessageBarButton =
        inherit BaseComponent<IButtonProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] MessageBarButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MessageBarButton

module __components_Button_MessageBarButton_MessageBarButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> string option -> string option -> IButtonStyles)

module __components_Button_PrimaryButton_PrimaryButton =
    type BaseComponent = Utilities.BaseComponent
    type IButtonProps = __components_Button_Button_types.IButtonProps

    type [<AllowNullLiteral>] IExports =
        abstract PrimaryButton: PrimaryButtonStatic

    type [<AllowNullLiteral>] PrimaryButton =
        inherit BaseComponent<IButtonProps, obj>
        /// Set this BaseComponent._resolveComponentRef to false, bypassing resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PrimaryButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PrimaryButton

module __components_Button_SplitButton_SplitButton_classNames =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles

    type [<AllowNullLiteral>] IExports =
        abstract getClassNames: (IButtonStyles -> bool -> bool -> bool -> ISplitButtonClassNames)

    type [<AllowNullLiteral>] ISplitButtonClassNames =
        abstract root: string option with get, set
        abstract icon: string option with get, set
        abstract splitButtonContainer: string option with get, set
        abstract flexContainer: string option with get, set
        abstract divider: string option with get, set

module __components_Button_SplitButton_SplitButton_styles =
    type IButtonStyles = __components_Button_Button_types.IButtonStyles
    type ITheme = Styling.ITheme

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (ITheme -> IButtonStyles option -> IButtonStyles)

module __components_Calendar_examples_Calendar_Button_Example =

    type [<AllowNullLiteral>] IExports =
        abstract CalendarButtonExample: CalendarButtonExampleStatic

    type [<AllowNullLiteral>] ICalendarButtonExampleState =
        abstract showCalendar: bool with get, set
        abstract selectedDate: DateTime option with get, set

    type [<AllowNullLiteral>] ICalendarButtonExampleProps =
        abstract isDayPickerVisible: bool option with get, set
        abstract isMonthPickerVisible: bool option with get, set
        abstract highlightCurrentMonth: bool option with get, set
        abstract highlightSelectedMonth: bool option with get, set
        abstract buttonString: string option with get, set
        abstract showMonthPickerAsOverlay: bool option with get, set

    type [<AllowNullLiteral>] CalendarButtonExample =
        inherit React.Component<ICalendarButtonExampleProps, ICalendarButtonExampleState>
        abstract defaultProps: ICalendarButtonExampleProps with get, set
        abstract _calendarButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onClick: ``event``: obj -> unit
        abstract _onDismiss: unit -> unit
        abstract _onSelectDate: date: obj -> unit

    type [<AllowNullLiteral>] CalendarButtonExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalendarButtonExampleProps -> CalendarButtonExample

module __components_Calendar_examples_Calendar_Inline_Example =
    type DayOfWeek = __components_Calendar_examples_office_ui_fabric_react_lib_Calendar.DayOfWeek
    type DateRangeType = __components_Calendar_examples_office_ui_fabric_react_lib_Calendar.DateRangeType

    type [<AllowNullLiteral>] IExports =
        abstract CalendarInlineExample: CalendarInlineExampleStatic

    type [<AllowNullLiteral>] ICalendarInlineExampleState =
        abstract selectedDate: DateTime option with get, set
        abstract selectedDateRange: ResizeArray<DateTime> option with get, set

    type [<AllowNullLiteral>] ICalendarInlineExampleProps =
        abstract isMonthPickerVisible: bool option with get, set
        abstract dateRangeType: DateRangeType with get, set
        abstract autoNavigateOnSelection: bool with get, set
        abstract showGoToToday: bool with get, set
        abstract showNavigateButtons: bool option with get, set
        abstract highlightCurrentMonth: bool option with get, set
        abstract highlightSelectedMonth: bool option with get, set
        abstract isDayPickerVisible: bool option with get, set
        abstract showMonthPickerAsOverlay: bool option with get, set
        abstract showWeekNumbers: bool option with get, set
        abstract minDate: DateTime option with get, set
        abstract maxDate: DateTime option with get, set
        abstract showSixWeeksByDefault: bool option with get, set
        abstract workWeekDays: ResizeArray<DayOfWeek> option with get, set
        abstract firstDayOfWeek: DayOfWeek option with get, set

    type [<AllowNullLiteral>] CalendarInlineExample =
        inherit React.Component<ICalendarInlineExampleProps, ICalendarInlineExampleState>
        abstract render: unit -> JSX.Element
        abstract _onDismiss: unit -> unit
        abstract _goPrevious: unit -> unit
        abstract _goNext: unit -> unit
        abstract _onSelectDate: date: obj * dateRangeArray: obj -> unit

    type [<AllowNullLiteral>] CalendarInlineExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalendarInlineExampleProps -> CalendarInlineExample

module __components_Callout_examples_Callout_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract CalloutBasicExample: CalloutBasicExampleStatic

    type [<AllowNullLiteral>] ICalloutBasicExampleState =
        abstract isCalloutVisible: bool option with get, set

    type [<AllowNullLiteral>] CalloutBasicExample =
        inherit React.Component<obj, ICalloutBasicExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onShowMenuClicked: obj with get, set
        abstract _onCalloutDismiss: obj with get, set

    type [<AllowNullLiteral>] CalloutBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CalloutBasicExampleStaticProps -> CalloutBasicExample

    type [<AllowNullLiteral>] CalloutBasicExampleStaticProps =
        interface end

module __components_Callout_examples_Callout_Cover_Example =
    type DirectionalHint = __components_Callout_examples_office_ui_fabric_react_lib_Callout.DirectionalHint

    type [<AllowNullLiteral>] IExports =
        abstract CalloutCoverExample: CalloutCoverExampleStatic

    type [<AllowNullLiteral>] ICalloutCoverExampleState =
        abstract isCalloutVisible: bool option with get, set
        abstract directionalHint: DirectionalHint option with get, set

    type [<AllowNullLiteral>] CalloutCoverExample =
        inherit React.Component<obj, ICalloutCoverExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: unit -> unit
        abstract _onShowMenuClicked: unit -> unit
        abstract _onDirectionalChanged: option: obj -> unit

    type [<AllowNullLiteral>] CalloutCoverExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CalloutCoverExampleStaticProps -> CalloutCoverExample

    type [<AllowNullLiteral>] CalloutCoverExampleStaticProps =
        interface end

module __components_Callout_examples_Callout_Directional_Example =
    type DirectionalHint = __components_Callout_examples_office_ui_fabric_react_lib_Callout.DirectionalHint

    type [<AllowNullLiteral>] IExports =
        abstract CalloutDirectionalExample: CalloutDirectionalExampleStatic

    type [<AllowNullLiteral>] ICalloutDirectionalExampleState =
        abstract isCalloutVisible: bool option with get, set
        abstract directionalHint: DirectionalHint option with get, set
        abstract isBeakVisible: bool option with get, set
        abstract gapSpace: float option with get, set
        abstract beakWidth: float option with get, set

    type [<AllowNullLiteral>] CalloutDirectionalExample =
        inherit React.Component<obj, ICalloutDirectionalExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onCalloutDismiss: obj with get, set
        abstract _onShowMenuClicked: obj with get, set
        abstract _onShowBeakChange: obj with get, set
        abstract _onDirectionalChanged: obj with get, set
        abstract _onGapSlider: obj with get, set
        abstract _onBeakWidthSlider: obj with get, set

    type [<AllowNullLiteral>] CalloutDirectionalExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CalloutDirectionalExampleStaticProps -> CalloutDirectionalExample

    type [<AllowNullLiteral>] CalloutDirectionalExampleStaticProps =
        interface end

module __components_Callout_examples_Callout_Nested_Example =
    type ICommandBarItemProps = __components_Callout_examples_office_ui_fabric_react_lib_CommandBar.ICommandBarItemProps

    type [<AllowNullLiteral>] IExports =
        abstract CalloutNestedExample: CalloutNestedExampleStatic

    type [<AllowNullLiteral>] ICalloutNestedExampleProps =
        abstract items: ResizeArray<ICommandBarItemProps> with get, set

    type [<AllowNullLiteral>] CalloutNestedExample =
        inherit React.Component<ICalloutNestedExampleProps, obj>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: ev: obj -> unit

    type [<AllowNullLiteral>] CalloutNestedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ICalloutNestedExampleProps -> CalloutNestedExample

module __components_Checkbox_examples_Checkbox_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract CheckboxBasicExample: CheckboxBasicExampleStatic

    type [<AllowNullLiteral>] ICheckboxBasicExampleState =
        abstract isChecked: bool with get, set

    type [<AllowNullLiteral>] CheckboxBasicExample =
        inherit React.Component<obj, ICheckboxBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onCheckboxChange: ev: obj * isChecked: obj -> unit

    type [<AllowNullLiteral>] CheckboxBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CheckboxBasicExampleStaticProps -> CheckboxBasicExample

    type [<AllowNullLiteral>] CheckboxBasicExampleStaticProps =
        interface end

module __components_Checkbox_examples_Checkbox_ImplementationExamples =

    type [<AllowNullLiteral>] IExports =
        abstract CheckboxImplementationExamples: CheckboxImplementationExamplesStatic

    type [<AllowNullLiteral>] ICheckboxBasicExampleState =
        abstract isChecked: bool with get, set

    type [<AllowNullLiteral>] CheckboxImplementationExamples =
        inherit React.Component<obj, ICheckboxBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onCheckboxChange: ev: obj * isChecked: obj -> unit
        abstract _onControlledCheckboxChange: obj with get, set
        abstract _renderPersonaLabel: props: obj -> unit

    type [<AllowNullLiteral>] CheckboxImplementationExamplesStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CheckboxImplementationExamplesStaticProps -> CheckboxImplementationExamples

    type [<AllowNullLiteral>] CheckboxImplementationExamplesStaticProps =
        interface end

module __components_ChoiceGroup_examples_ChoiceGroup_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroupBasicExample: ChoiceGroupBasicExampleStatic

    /// Interface for ChoiceGroupBasicExample state.
    type [<AllowNullLiteral>] IChoiceGroupBasicExampleState =
        abstract imageKey: string with get, set

    type [<AllowNullLiteral>] ChoiceGroupBasicExample =
        inherit React.Component<obj, IChoiceGroupBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onChange: obj with get, set

    type [<AllowNullLiteral>] ChoiceGroupBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ChoiceGroupBasicExampleStaticProps -> ChoiceGroupBasicExample

    type [<AllowNullLiteral>] ChoiceGroupBasicExampleStaticProps =
        interface end

module __components_ChoiceGroup_examples_ChoiceGroup_Custom_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroupCustomExample: ChoiceGroupCustomExampleStatic

    type [<AllowNullLiteral>] ChoiceGroupCustomExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onChange: obj with get, set

    type [<AllowNullLiteral>] ChoiceGroupCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ChoiceGroupCustomExample

module __components_ChoiceGroup_examples_ChoiceGroup_Custom_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract dropdown: obj

module __components_ChoiceGroup_examples_ChoiceGroup_Icon_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroupIconExample: ChoiceGroupIconExampleStatic

    type [<AllowNullLiteral>] ChoiceGroupIconExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ChoiceGroupIconExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ChoiceGroupIconExample

module __components_ChoiceGroup_examples_ChoiceGroup_Image_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ChoiceGroupImageExample: ChoiceGroupImageExampleStatic

    /// Interface for ChoiceGroupImageExample state.
    type [<AllowNullLiteral>] IChoiceGroupImageExampleState =
        abstract selectedKey: string with get, set

    type [<AllowNullLiteral>] ChoiceGroupImageExample =
        inherit React.Component<obj, IChoiceGroupImageExampleState>
        abstract render: unit -> JSX.Element
        abstract _onImageChoiceGroupChange: ev: obj * option: obj -> unit

    type [<AllowNullLiteral>] ChoiceGroupImageExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ChoiceGroupImageExampleStaticProps -> ChoiceGroupImageExample

    type [<AllowNullLiteral>] ChoiceGroupImageExampleStaticProps =
        interface end

module __components_Coachmark_Beak_Beak =
    type BaseComponent = Utilities.BaseComponent
    type IBeakProps = __components_Coachmark_Beak_Beak_types.IBeakProps

    type [<AllowNullLiteral>] IExports =
        abstract Beak: BeakStatic

    type [<AllowNullLiteral>] IBeakState =
        abstract left: string option with get, set
        abstract top: string option with get, set

    type [<AllowNullLiteral>] Beak =
        inherit BaseComponent<IBeakProps, IBeakState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] BeakStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IBeakProps -> Beak

module __components_Coachmark_Beak_Beak_styles =
    type IStyle = Styling.IStyle
    type IBeakStylesProps = __components_Coachmark_Beak_Beak_types.IBeakStylesProps

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: props: IBeakStylesProps -> IBeakStyles

    type [<AllowNullLiteral>] IBeakStyles =
        /// Style for the root element in the default enabled/unchecked state.
        abstract root: IStyle option with get, set
        abstract beak: IStyle option with get, set

module __components_Coachmark_Beak_Beak_types =
    type Beak = __components_Coachmark_Beak_Beak.Beak

    type [<AllowNullLiteral>] IBeak =
        interface end

    type [<AllowNullLiteral>] IBeakProps =
        inherit React.Props<Beak>
        /// All props for your component are to be defined here.
        abstract componentRef: (IBeak option -> unit) option with get, set
        /// Beak width.
        abstract width: float option with get, set
        /// Beak height.
        abstract height: float option with get, set
        /// Color of the beak
        abstract color: string option with get, set
        /// Left position of the beak
        abstract left: string option with get, set
        /// Top position of the beak
        abstract top: string option with get, set

    type [<AllowNullLiteral>] IBeakStylesProps =
        abstract left: string option with get, set
        abstract top: string option with get, set
        abstract width: string option with get, set
        abstract height: string option with get, set

module __components_Coachmark_examples_Coachmark_Basic_Example =
    type IStyle = Styling.IStyle
    type BaseComponent = __components_Coachmark_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract CoachmarkBasicExample: CoachmarkBasicExampleStatic

    type [<AllowNullLiteral>] ICoachmarkBasicExampleState =
        abstract isVisible: bool option with get, set
        abstract isCoachmarkCollapsed: bool option with get, set
        abstract targetElement: HTMLElement option with get, set

    type [<AllowNullLiteral>] ICoachmarkBasicExampleStyles =
        /// Style for the root element in the default enabled/unchecked state.
        abstract root: IStyle option with get, set
        /// The example button container
        abstract buttonContainer: IStyle with get, set

    type [<AllowNullLiteral>] CoachmarkBasicExample =
        inherit BaseComponent<obj, ICoachmarkBasicExampleState>
        abstract _targetButton: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onShowMenuClicked: unit -> unit
        abstract _onCalloutDismiss: unit -> unit

    type [<AllowNullLiteral>] CoachmarkBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CoachmarkBasicExampleStaticProps -> CoachmarkBasicExample

    type [<AllowNullLiteral>] CoachmarkBasicExampleStaticProps =
        interface end

module __components_Coachmark_PositioningContainer_PositioningContainer =
    type IPositioningContainerTypes = __components_Coachmark_PositioningContainer_PositioningContainer_types.IPositioningContainerTypes
    type BaseComponent = Utilities.BaseComponent
    type IPositionedData = __components_Coachmark_PositioningContainer_office_ui_fabric_react_lib_utilities_positioning.IPositionedData

    type [<AllowNullLiteral>] IExports =
        abstract PositioningContainer: PositioningContainerStatic

    type [<AllowNullLiteral>] IPositioningContainerState =
        /// Current set of calcualted positions for the outermost parent container.
        abstract positions: IPositionedData option with get, set
        /// Tracks the current height offset and updates during
        /// the height animation when props.finalHeight is specified.
        abstract heightOffset: float option with get, set

    type [<AllowNullLiteral>] PositioningContainer =
        inherit BaseComponent<IPositioningContainerTypes, IPositioningContainerState>
        inherit PositioningContainer
        abstract defaultProps: IPositioningContainerTypes with get, set
        abstract _didSetInitialFocus: obj with get, set
        /// The primary positioned div.
        abstract _positionedHost: obj with get, set
        abstract _contentHost: obj with get, set
        /// Stores an instance of Window, used to check
        /// for server side rendering and if focus was lost.
        abstract _targetWindow: obj with get, set
        /// The bounds used when determing if and where the
        /// PositioningContainer should be placed.
        abstract _positioningBounds: obj with get, set
        /// The maximum height the PositioningContainer can grow to
        /// without going being the window or target bounds
        abstract _maxHeight: obj with get, set
        abstract _positionAttempts: obj with get, set
        abstract _target: obj with get, set
        abstract _setHeightOffsetTimer: obj with get, set
        abstract componentWillMount: unit -> unit
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract componentWillUpdate: newProps: IPositioningContainerTypes -> unit
        abstract render: unit -> JSX.Element option
        abstract dismiss: (U3<Event, React.KeyboardEvent<HTMLElement>, React.MouseEvent<HTMLElement>> option -> unit) with get, set
        abstract _dismissOnScroll: ev: Event -> unit
        abstract _dismissOnLostFocus: ev: Event -> unit
        abstract _setInitialFocus: (unit -> unit) with get, set
        abstract _onComponentDidMount: (unit -> unit) with get, set
        abstract _updateAsyncPosition: unit -> unit
        abstract _updatePosition: unit -> unit
        abstract _getBounds: unit -> unit
        /// Return the maximum height the container can grow to
        /// without going out of the specified bounds
        abstract _getMaxHeight: unit -> unit
        abstract _arePositionsEqual: positions: obj * newPosition: obj -> unit
        abstract _comparePositions: oldPositions: obj * newPositions: obj -> unit
        abstract _setTargetWindowAndElement: target: obj -> unit
        /// Animates the height if finalHeight was given.
        abstract _setHeightOffsetEveryFrame: unit -> unit
        abstract _getTarget: ?props: obj -> unit

    type [<AllowNullLiteral>] PositioningContainerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPositioningContainerTypes -> PositioningContainer

module __components_Coachmark_PositioningContainer_PositioningContainer_styles =
    type IStyle = Styling.IStyle

    type [<AllowNullLiteral>] IExports =
        abstract highContrastActive: styles: IStyle -> obj option
        abstract focusClear: unit -> obj option
        abstract getClassNames: (unit -> IPositioningContainerNames)

    type [<AllowNullLiteral>] IPositioningContainerStyles =
        /// Style for the root element in the default enabled/unchecked state.
        abstract root: IStyle option with get, set

    type [<AllowNullLiteral>] IPositioningContainerNames =
        /// Root html container for this component.
        abstract root: string with get, set
        abstract container: string with get, set
        abstract main: string with get, set
        abstract overFlowYHidden: string with get, set
        abstract beak: string option with get, set
        abstract beakCurtain: string option with get, set

module __components_Coachmark_PositioningContainer_PositioningContainer_types =
    type PositioningContainer = __components_Coachmark_PositioningContainer_PositioningContainer.PositioningContainer
    type DirectionalHint = __components_Coachmark_PositioningContainer_office_ui_fabric_react_lib_common_DirectionalHint.DirectionalHint
    type IPoint = Utilities.IPoint
    type IRectangle = Utilities.IRectangle
    type ICalloutPositon = __components_Coachmark_PositioningContainer_office_ui_fabric_react_lib_utilities_positioning.ICalloutPositon

    type [<AllowNullLiteral>] IPositioningContainer =
        interface end

    type [<AllowNullLiteral>] IPositionInfo =
        abstract calloutPosition: ICalloutPositon with get, set
        abstract beakPosition: obj with get, set
        abstract directionalClassName: string with get, set
        abstract submenuDirection: DirectionalHint with get, set

    type [<AllowNullLiteral>] IPositioningContainerTypes =
        inherit React.Props<PositioningContainer>
        /// All props for your component are to be defined here.
        abstract componentRef: (IPositioningContainer option -> unit) option with get, set
        /// The target that the positioningContainer should try to position itself based on.
        /// It can be either an HTMLElement a querySelector string of a valid HTMLElement
        /// or a MouseEvent. If MouseEvent is given then the origin point of the event will be used.
        abstract target: U4<HTMLElement, string, MouseEvent, IPoint> option with get, set
        /// How the element should be positioned
        abstract directionalHint: DirectionalHint option with get, set
        /// How the element should be positioned in RTL layouts.
        /// If not specified, a mirror of `directionalHint` will be used instead
        abstract directionalHintForRTL: DirectionalHint option with get, set
        /// The gap between the positioningContainer and the target
        abstract offsetFromTarget: float option with get, set
        /// Custom width for positioningContainer including borders. If value is 0, no width is applied.
        abstract positioningContainerWidth: float option with get, set
        /// The background color of the positioningContainer in hex format ie. #ffffff.
        abstract backgroundColor: string option with get, set
        /// The bounding rectangle for which  the contextual menu can appear in.
        abstract bounds: IRectangle option with get, set
        /// The minimum distance the positioningContainer will be away from the edge of the screen.
        ///   
        abstract minPagePadding: float option with get, set
        /// If true use a point rather than rectangle to position the positioningContainer.
        /// For example it can be used to position based on a click.
        abstract useTargetPoint: bool option with get, set
        /// Point used to position the positioningContainer
        abstract targetPoint: IPoint option with get, set
        /// If true then the onClose will not not dismiss on scroll
        abstract preventDismissOnScroll: bool option with get, set
        /// If true the position returned will have the menu element cover the target.
        /// If false then it will position next to the target;
        abstract coverTarget: bool option with get, set
        /// Aria role assigned to the positioningContainer (Eg. dialog, alertdialog).
        abstract role: string option with get, set
        /// Accessible label text for positioningContainer.
        abstract ariaLabel: string option with get, set
        /// Defines the element id referencing the element containing label text for positioningContainer.
        abstract ariaLabelledBy: string option with get, set
        /// Defines the element id referencing the element containing the description for the positioningContainer.
        abstract ariaDescribedBy: string option with get, set
        /// CSS class to apply to the positioningContainer.
        abstract className: string option with get, set
        /// Optional callback when the layer content has mounted.
        abstract onLayerMounted: (unit -> unit) option with get, set
        /// Optional callback that is called once the positioningContainer has been correctly positioned.
        abstract onPositioned: (unit -> unit) option with get, set
        /// Callback when the positioningContainer tries to close.
        abstract onDismiss: (obj option -> unit) option with get, set
        /// If true do not render on a new layer. If false render on a new layer.
        abstract doNotLayer: bool option with get, set
        /// If true the position will not change sides in an attempt to fit the positioningContainer within bounds.
        /// It will still attempt to align it to whatever bounds are given.
        abstract directionalHintFixed: bool option with get, set
        /// Specify the final height of the content.
        /// To be used when expanding the content dynamically so that positioningContainer can adjust its position.
        abstract finalHeight: float option with get, set
        /// If true then the positioningContainer will attempt to focus the first focusable element that it contains.
        /// If it doesn't find an element, no focus will be set and the method will return false.
        /// This means that it's the contents responsibility to either set focus or have
        /// focusable items.
        abstract setInitialFocus: bool option with get, set
        /// Set max height of positioningContainer
        /// When not set the positioningContainer will expand with contents up to the bottom of the screen
        abstract positioningContainerMaxHeight: float option with get, set

module __components_Coachmark_PositioningContainer_PositioningContainerPage =
    type IComponentDemoPageProps = __components_Coachmark_PositioningContainer_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract PositioningContainerPage: PositioningContainerPageStatic

    type [<AllowNullLiteral>] PositioningContainerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PositioningContainerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PositioningContainerPage

module __components_ColorPicker_examples_ColorPicker_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ColorPickerBasicExample: ColorPickerBasicExampleStatic

    type [<AllowNullLiteral>] IBasicColorPickerExampleState =
        abstract color: string with get, set

    type [<AllowNullLiteral>] ColorPickerBasicExample =
        inherit React.Component<obj option, IBasicColorPickerExampleState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ColorPickerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ColorPickerBasicExample

module __components_ComboBox_examples_ComboBox_Basic_Example =
    type IComboBoxOption = __components_ComboBox_examples_office_ui_fabric_react_lib_ComboBox.IComboBoxOption

    type [<AllowNullLiteral>] IExports =
        abstract ComboBoxBasicExample: ComboBoxBasicExampleStatic

    type [<AllowNullLiteral>] ComboBoxBasicExample =
        inherit React.Component<obj, obj>
        abstract _testOptions: obj with get, set
        abstract _fontMapping: obj with get, set
        abstract scaleOptions: obj with get, set
        abstract _basicCombobox: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onRenderFontOption: obj with get, set
        abstract _getOptions: obj with get, set
        abstract _getOptionsMulti: obj with get, set
        abstract _onChanged: obj with get, set
        abstract _onChangedMulti: obj with get, set
        abstract _updateSelectedOptionKeys: obj with get, set
        abstract _basicComboBoxOnClick: obj with get, set
        abstract _basicComboBoxComponentRef: obj with get, set

    type [<AllowNullLiteral>] ComboBoxBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ComboBoxBasicExampleStaticProps -> ComboBoxBasicExample

    type [<AllowNullLiteral>] ComboBoxBasicExampleStaticProps =
        interface end

module __components_ComboBox_examples_ComboBox_CustomStyled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ComboBoxCustomStyledExample: ComboBoxCustomStyledExampleStatic

    type [<AllowNullLiteral>] ComboBoxCustomStyledExample =
        inherit React.Component<obj option, obj option>
        abstract _testOptionsWithCustomStyling: obj with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ComboBoxCustomStyledExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ComboBoxCustomStyledExample

module __components_CommandBar_examples_CommandBar_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract CommandBarBasicExample: CommandBarBasicExampleStatic

    type [<AllowNullLiteral>] CommandBarBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CommandBarBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> CommandBarBasicExample

module __components_CommandBar_examples_CommandBar_Customization_Example =

    type [<AllowNullLiteral>] IExports =
        abstract CommandBarCustomizationExample: CommandBarCustomizationExampleStatic

    type [<AllowNullLiteral>] ISplitDropDownButtonState =
        abstract isContextMenuShown: bool with get, set

    type [<AllowNullLiteral>] CommandBarCustomizationExample =
        inherit React.Component<obj, ISplitDropDownButtonState>
        abstract container: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _renderSplitButtonMenuItem: obj with get, set
        abstract _onClickChevron: obj with get, set
        abstract _toggleDropDownMenuShown: obj with get, set

    type [<AllowNullLiteral>] CommandBarCustomizationExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: CommandBarCustomizationExampleStaticProps -> CommandBarCustomizationExample

    type [<AllowNullLiteral>] CommandBarCustomizationExampleStaticProps =
        interface end

module __components_CommandBar_examples_CommandBar_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract customButtonContainer: obj
        abstract icon: obj
        abstract themeDarkAltColor: obj
        abstract leftText: obj
        abstract splitter: obj
        abstract button: obj
        abstract darkerBG: obj

module __components_CommandBar_examples_CommandBar_NonFocusable_Example =

    type [<AllowNullLiteral>] IExports =
        abstract CommandBarNonFocusableItemsExample: CommandBarNonFocusableItemsExampleStatic

    type [<AllowNullLiteral>] CommandBarNonFocusableItemsExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] CommandBarNonFocusableItemsExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CommandBarNonFocusableItemsExample

module __components_CommandBar_examples_data_nonFocusable =

    type [<AllowNullLiteral>] IExports =
        abstract itemsNonFocusable: ResizeArray<U2<obj, obj>>
        abstract farItemsNonFocusable: ResizeArray<U2<obj, obj>>

module __components_CommandBar_examples_data =

    type [<AllowNullLiteral>] IExports =
        abstract items: ResizeArray<U5<obj, obj, obj, obj, obj>>
        abstract textOnlyItems: ResizeArray<obj>
        abstract iconOnlyItems: ResizeArray<U2<obj, obj>>
        abstract overflowItems: ResizeArray<obj>
        abstract farItems: ResizeArray<obj>

module __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuAnchor =
    type ContextualMenuItemWrapper = __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper.ContextualMenuItemWrapper

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuAnchor: ContextualMenuAnchorStatic

    type [<AllowNullLiteral>] ContextualMenuAnchor =
        inherit ContextualMenuItemWrapper
        abstract _anchor: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getSubmenuTarget: (unit -> HTMLElement option) with get, set
        abstract _onItemClick: (React.MouseEvent<HTMLElement> -> unit) with get, set

    type [<AllowNullLiteral>] ContextualMenuAnchorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuAnchor

module __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuButton =
    type ContextualMenuItemWrapper = __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper.ContextualMenuItemWrapper

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuButton: ContextualMenuButtonStatic

    type [<AllowNullLiteral>] ContextualMenuButton =
        inherit ContextualMenuItemWrapper
        abstract _btn: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getSubmenuTarget: (unit -> HTMLElement option) with get, set

    type [<AllowNullLiteral>] ContextualMenuButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuButton

module __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper =
    type BaseComponent = Utilities.BaseComponent
    type IContextualMenuItemWrapperProps = __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper_types.IContextualMenuItemWrapperProps
    type IContextualMenuItem = __components_ContextualMenu.IContextualMenuItem

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuItemWrapper: ContextualMenuItemWrapperStatic

    type [<AllowNullLiteral>] ContextualMenuItemWrapper =
        inherit BaseComponent<IContextualMenuItemWrapperProps, obj>
        abstract _onItemMouseEnter: (React.MouseEvent<HTMLElement> -> unit) with get, set
        abstract _onItemClick: (React.MouseEvent<HTMLElement> -> unit) with get, set
        abstract _onItemMouseLeave: (React.MouseEvent<HTMLElement> -> unit) with get, set
        abstract _onItemKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
        abstract _onItemMouseMove: (React.MouseEvent<HTMLElement> -> unit) with get, set
        abstract _getSubMenuId: (IContextualMenuItem -> string option) with get, set
        abstract _getSubmenuTarget: (unit -> HTMLElement option) with get, set

    type [<AllowNullLiteral>] ContextualMenuItemWrapperStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuItemWrapper

module __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper_types =
    type IContextualMenuItem = __components_ContextualMenu.IContextualMenuItem
    type IContextualMenuItemProps = __components_ContextualMenu.IContextualMenuItemProps
    type IMenuItemClassNames = __components_ContextualMenu_ContextualMenu_classNames.IMenuItemClassNames
    type ContextualMenuItemWrapper = __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper.ContextualMenuItemWrapper

    type [<AllowNullLiteral>] IContextualMenuItemWrapperProps =
        inherit React.Props<IContextualMenuItem>
        /// Optional callback to access the ContextualMenuSplitButton interface. Use this instead of ref for accessing
        /// the public methods and properties of the component.
        abstract componentRef: (ContextualMenuItemWrapper option -> unit) option with get, set
        /// The IContextualMenuItem that is used to render the item in the menu.
        abstract item: IContextualMenuItem with get, set
        /// CSS class to apply to the context menu.
        abstract classNames: IMenuItemClassNames with get, set
        /// The index number of the wrapper among all items in the contextual menu including things like dividers and headers.
        abstract index: float with get, set
        /// The index number of the wrapper among all items in the contextual menu excluding dividers and headers.
        abstract focusableElementIndex: float with get, set
        /// The total number of items in the contextual menu.
        abstract totalItemCount: float with get, set
        /// Whether or not if the item for the wrapper uses checkmarks.
        abstract hasCheckmarks: bool option with get, set
        /// Whether or not the item for the wrapper uses icons.
        abstract hasIcons: bool option with get, set
        /// Method to override the render of the individual menu items.
        abstract contextualMenuItemAs: U2<React.ComponentClass<IContextualMenuItemProps>, React.StatelessComponent<IContextualMenuItemProps>> option with get, set
        /// Callback for when the user's mouse enters the wrapper.
        abstract onItemMouseEnter: (IContextualMenuItem -> React.MouseEvent<HTMLElement> -> HTMLElement -> U2<bool, unit>) option with get, set
        /// Callback for when the user's mouse leaves the wrapper.
        abstract onItemMouseLeave: (IContextualMenuItem -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        /// Callback for when the user's mouse moves in the wrapper.
        abstract onItemMouseMove: (IContextualMenuItem -> React.MouseEvent<HTMLElement> -> HTMLElement -> unit) option with get, set
        /// Callback for the mousedown event on the icon button in the wrapper.
        abstract onItemMouseDown: (IContextualMenuItem -> React.MouseEvent<HTMLElement> -> unit) option with get, set
        /// Callback for when the click event on the primary button.
        abstract executeItemClick: (IContextualMenuItem -> U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> unit) option with get, set
        /// Callback for when the click event on the icon button from the wrapper.
        abstract onItemClick: (IContextualMenuItem -> U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> unit) option with get, set
        /// Callback for when the click event on the icon button which also takes in a specific HTMLElement that will be focused.
        abstract onItemClickBase: (IContextualMenuItem -> U2<React.MouseEvent<HTMLElement>, React.KeyboardEvent<HTMLElement>> -> HTMLElement -> unit) option with get, set
        /// Callback for keyboard events on the wrapper.
        abstract onItemKeyDown: (IContextualMenuItem -> React.KeyboardEvent<HTMLElement> -> unit) option with get, set
        /// Callback to get the subMenu ID for an IContextualMenuItem.
        abstract getSubMenuId: (IContextualMenuItem -> string option) option with get, set
        /// Key of the currently expanded subMenu.
        abstract expandedMenuItemKey: string option with get, set
        /// Callback for touch/pointer events on the split button.
        abstract onTap: (U2<React.TouchEvent<HTMLElement>, PointerEvent> -> unit) option with get, set
        /// This prop will get set by ContextualMenu and can be called to open this item's subMenu, if present.
        abstract openSubMenu: (obj option -> HTMLElement -> unit) option with get, set
        /// This prop will get set by ContextualMenu and can be called to close this item's subMenu, if present.
        abstract dismissSubMenu: (unit -> unit) option with get, set
        /// This prop will get set by ContextualMenu and can be called to close the menu this item belongs to.
        /// If dismissAll is true, all menus will be closed.
        abstract dismissMenu: (obj option -> bool -> unit) option with get, set

module __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuSplitButton =
    type ContextualMenuItemWrapper = __components_ContextualMenu_ContextualMenuItemWrapper_ContextualMenuItemWrapper.ContextualMenuItemWrapper

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuSplitButton: ContextualMenuSplitButtonStatic

    type [<AllowNullLiteral>] IContextualMenuSplitButtonState =
        interface end

    type [<AllowNullLiteral>] ContextualMenuSplitButton =
        inherit ContextualMenuItemWrapper
        abstract _splitButton: obj with get, set
        abstract _lastTouchTimeoutId: obj with get, set
        abstract _processingTouch: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element option
        abstract _onItemKeyDown: (React.KeyboardEvent<HTMLElement> -> unit) with get, set
        abstract _getSubmenuTarget: (unit -> HTMLElement option) with get, set
        abstract _renderSplitPrimaryButton: item: obj * classNames: obj * index: obj * hasCheckmarks: obj * hasIcons: obj -> unit
        abstract _renderSplitDivider: item: obj -> unit
        abstract _renderSplitIconButton: item: obj * classNames: obj * index: obj * keytipAttributes: obj -> unit
        abstract _onItemMouseEnterPrimary: obj with get, set
        abstract _onItemMouseEnterIcon: obj with get, set
        abstract _onItemMouseMovePrimary: obj with get, set
        abstract _onItemMouseMoveIcon: obj with get, set
        abstract _onIconItemClick: obj with get, set
        abstract _executeItemClick: obj with get, set
        abstract _onTouchStart: obj with get, set
        abstract _onPointerDown: obj with get, set
        abstract _handleTouchAndPointerEvent: ev: obj -> unit

    type [<AllowNullLiteral>] ContextualMenuSplitButtonStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuSplitButton

module __components_ContextualMenu_examples_ContextualMenu_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuBasicExample: ContextualMenuBasicExampleStatic

    type [<AllowNullLiteral>] ContextualMenuBasicExample =
        inherit React.Component
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuBasicExampleStaticProps -> ContextualMenuBasicExample

    type [<AllowNullLiteral>] ContextualMenuBasicExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_Checkmarks_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuCheckmarksExample: ContextualMenuCheckmarksExampleStatic

    type [<AllowNullLiteral>] IContextualMenuMultiselectExampleState =
        abstract selection: obj option with get, set

    type [<AllowNullLiteral>] ContextualMenuCheckmarksExample =
        inherit React.Component<obj, IContextualMenuMultiselectExampleState>
        abstract render: unit -> JSX.Element
        abstract _onToggleSelect: ?ev: obj * ?item: obj -> unit

    type [<AllowNullLiteral>] ContextualMenuCheckmarksExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuCheckmarksExampleStaticProps -> ContextualMenuCheckmarksExample

    type [<AllowNullLiteral>] ContextualMenuCheckmarksExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_Customization_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuCustomizationExample: ContextualMenuCustomizationExampleStatic

    type [<AllowNullLiteral>] ContextualMenuCustomizationExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _renderCharmMenuItem: obj with get, set
        abstract _renderCategoriesList: item: obj -> unit

    type [<AllowNullLiteral>] ContextualMenuCustomizationExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuCustomizationExample

module __components_ContextualMenu_examples_ContextualMenu_CustomizationWithNoWrap_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuCustomizationWithNoWrapExample: ContextualMenuCustomizationWithNoWrapExampleStatic

    type [<AllowNullLiteral>] ContextualMenuCustomizationWithNoWrapExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _renderCharmMenuItem: obj with get, set
        abstract _renderCategoriesList: item: obj -> unit

    type [<AllowNullLiteral>] ContextualMenuCustomizationWithNoWrapExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuCustomizationWithNoWrapExample

module __components_ContextualMenu_examples_ContextualMenu_CustomMenuItem_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuWithCustomMenuItemExample: ContextualMenuWithCustomMenuItemExampleStatic

    type [<AllowNullLiteral>] ContextualMenuWithCustomMenuItemExample =
        inherit React.Component
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuWithCustomMenuItemExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuWithCustomMenuItemExampleStaticProps -> ContextualMenuWithCustomMenuItemExample

    type [<AllowNullLiteral>] ContextualMenuWithCustomMenuItemExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_Directional_Example =
    type DirectionalHint = __components_ContextualMenu_examples_office_ui_fabric_react_lib_ContextualMenu.DirectionalHint

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuDirectionalExample: ContextualMenuDirectionalExampleStatic

    type [<AllowNullLiteral>] IContextualMenuDirectionalExampleState =
        abstract directionalHint: DirectionalHint option with get, set
        abstract directionalHintForRTL: DirectionalHint option with get, set
        abstract useDirectionalHintForRtl: bool option with get, set
        abstract isBeakVisible: bool option with get, set
        abstract gapSpace: float option with get, set
        abstract beakWidth: float option with get, set
        abstract edgeFixed: bool option with get, set

    type [<AllowNullLiteral>] ContextualMenuDirectionalExample =
        inherit React.Component<obj, IContextualMenuDirectionalExampleState>
        abstract render: unit -> JSX.Element
        abstract _onShowBeakChange: obj with get, set
        abstract _onUseRtlHintChange: obj with get, set
        abstract _onDirectionalChanged: obj with get, set
        abstract _onDirectionalRtlChanged: obj with get, set

    type [<AllowNullLiteral>] ContextualMenuDirectionalExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuDirectionalExampleStaticProps -> ContextualMenuDirectionalExample

    type [<AllowNullLiteral>] ContextualMenuDirectionalExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_Header_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuHeaderExample: ContextualMenuHeaderExampleStatic

    type [<AllowNullLiteral>] ContextualMenuHeaderExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuHeaderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuHeaderExample

module __components_ContextualMenu_examples_ContextualMenu_Icon_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuIconExample: ContextualMenuIconExampleStatic

    type [<AllowNullLiteral>] ContextualMenuIconExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuIconExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuIconExampleStaticProps -> ContextualMenuIconExample

    type [<AllowNullLiteral>] ContextualMenuIconExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_Icon_SecondaryText_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuIconSecondaryTextExample: ContextualMenuIconSecondaryTextExampleStatic

    type [<AllowNullLiteral>] ContextualMenuIconSecondaryTextExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuIconSecondaryTextExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuIconSecondaryTextExampleStaticProps -> ContextualMenuIconSecondaryTextExample

    type [<AllowNullLiteral>] ContextualMenuIconSecondaryTextExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_ScrollBar_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuWithScrollBarExample: ContextualMenuWithScrollBarExampleStatic

    type [<AllowNullLiteral>] ContextualMenuWithScrollBarExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuWithScrollBarExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ContextualMenuWithScrollBarExampleStaticProps -> ContextualMenuWithScrollBarExample

    type [<AllowNullLiteral>] ContextualMenuWithScrollBarExampleStaticProps =
        interface end

module __components_ContextualMenu_examples_ContextualMenu_Section_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuSectionExample: ContextualMenuSectionExampleStatic

    type [<AllowNullLiteral>] ContextualMenuSectionExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ContextualMenuSectionExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ContextualMenuSectionExample

module __components_ContextualMenu_examples_ContextualMenu_Submenu_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ContextualMenuSubmenuExample: ContextualMenuSubmenuExampleStatic

    type [<AllowNullLiteral>] IContextualMenuSubmenuExampleState =
        abstract hoverDelay: float with get, set

    type [<AllowNullLiteral>] ContextualMenuSubmenuExample =
        inherit React.Component<obj option, IContextualMenuSubmenuExampleState>
        abstract render: unit -> JSX.Element
        abstract _onHoverDelayChanged: obj with get, set

    type [<AllowNullLiteral>] ContextualMenuSubmenuExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> ContextualMenuSubmenuExample

module __components_ContextualMenu_examples_ContextualMenuExample_scss =

    type [<AllowNullLiteral>] IExports =
        abstract iconContainer: obj
        abstract logoFillIcon: obj
        abstract logoIcon: obj

module __components_DatePicker_examples_DatePicker_Basic_Example =
    type DayOfWeek = __components_DatePicker_examples_office_ui_fabric_react_lib_DatePicker.DayOfWeek

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerBasicExample: DatePickerBasicExampleStatic

    type [<AllowNullLiteral>] IDatePickerBasicExampleState =
        abstract firstDayOfWeek: DayOfWeek option with get, set

    type [<AllowNullLiteral>] DatePickerBasicExample =
        inherit React.Component<obj, IDatePickerBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onDropdownChanged: obj with get, set

    type [<AllowNullLiteral>] DatePickerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DatePickerBasicExampleStaticProps -> DatePickerBasicExample

    type [<AllowNullLiteral>] DatePickerBasicExampleStaticProps =
        interface end

module __components_DatePicker_examples_DatePicker_Bounded_Example =
    type DayOfWeek = __components_DatePicker_examples_office_ui_fabric_react_lib_DatePicker.DayOfWeek

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerBoundedExample: DatePickerBoundedExampleStatic

    type [<AllowNullLiteral>] IDatePickerRequiredExampleState =
        abstract firstDayOfWeek: DayOfWeek option with get, set

    type [<AllowNullLiteral>] DatePickerBoundedExample =
        inherit React.Component<obj, IDatePickerRequiredExampleState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DatePickerBoundedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DatePickerBoundedExampleStaticProps -> DatePickerBoundedExample

    type [<AllowNullLiteral>] DatePickerBoundedExampleStaticProps =
        interface end

module __components_DatePicker_examples_DatePicker_Format_Example =
    type DayOfWeek = __components_DatePicker_examples_office_ui_fabric_react_lib_DatePicker.DayOfWeek

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerFormatExample: DatePickerFormatExampleStatic

    type [<AllowNullLiteral>] IDatePickerFormatExampleState =
        abstract firstDayOfWeek: DayOfWeek option with get, set
        abstract value: DateTime option with get, set

    type [<AllowNullLiteral>] DatePickerFormatExample =
        inherit React.Component<obj, IDatePickerFormatExampleState>
        abstract render: unit -> JSX.Element
        abstract _onSelectDate: obj with get, set
        abstract _onClick: obj with get, set
        abstract _onFormatDate: obj with get, set
        abstract _onParseDateFromString: obj with get, set

    type [<AllowNullLiteral>] DatePickerFormatExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DatePickerFormatExampleStaticProps -> DatePickerFormatExample

    type [<AllowNullLiteral>] DatePickerFormatExampleStaticProps =
        interface end

module __components_DatePicker_examples_DatePicker_Input_Example =
    type DayOfWeek = __components_DatePicker_examples_office_ui_fabric_react_lib_DatePicker.DayOfWeek

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerInputExample: DatePickerInputExampleStatic

    type [<AllowNullLiteral>] IDatePickerInputExampleState =
        abstract firstDayOfWeek: DayOfWeek option with get, set
        abstract value: DateTime option with get, set

    type [<AllowNullLiteral>] DatePickerInputExample =
        inherit React.Component<obj, IDatePickerInputExampleState>
        abstract render: unit -> JSX.Element
        abstract _onSelectDate: obj with get, set
        abstract _onClick: obj with get, set

    type [<AllowNullLiteral>] DatePickerInputExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DatePickerInputExampleStaticProps -> DatePickerInputExample

    type [<AllowNullLiteral>] DatePickerInputExampleStaticProps =
        interface end

module __components_DatePicker_examples_DatePicker_Required_Example =
    type DayOfWeek = __components_DatePicker_examples_office_ui_fabric_react_lib_DatePicker.DayOfWeek

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerRequiredExample: DatePickerRequiredExampleStatic

    type [<AllowNullLiteral>] IDatePickerRequiredExampleState =
        abstract firstDayOfWeek: DayOfWeek option with get, set

    type [<AllowNullLiteral>] DatePickerRequiredExample =
        inherit React.Component<obj, IDatePickerRequiredExampleState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DatePickerRequiredExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DatePickerRequiredExampleStaticProps -> DatePickerRequiredExample

    type [<AllowNullLiteral>] DatePickerRequiredExampleStaticProps =
        interface end

module __components_DatePicker_examples_DatePicker_WeekNumbers_Example =
    type DayOfWeek = __components_DatePicker_examples_office_ui_fabric_react_lib_DatePicker.DayOfWeek

    type [<AllowNullLiteral>] IExports =
        abstract DatePickerWeekNumbersExample: DatePickerWeekNumbersExampleStatic

    type [<AllowNullLiteral>] IDatePickerBasicExampleState =
        abstract firstDayOfWeek: DayOfWeek option with get, set

    type [<AllowNullLiteral>] DatePickerWeekNumbersExample =
        inherit React.Component<obj, IDatePickerBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onDropdownChanged: obj with get, set

    type [<AllowNullLiteral>] DatePickerWeekNumbersExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DatePickerWeekNumbersExampleStaticProps -> DatePickerWeekNumbersExample

    type [<AllowNullLiteral>] DatePickerWeekNumbersExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_Advanced_Example =
    type IContextualMenuProps = __components_DetailsList_examples_office_ui_fabric_react_lib_ContextualMenu.IContextualMenuProps
    type CheckboxVisibility = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.CheckboxVisibility
    type ConstrainMode = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.ConstrainMode
    type LayoutMode = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.DetailsListLayoutMode
    type IColumn = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.IColumn
    type IGroup = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.IGroup
    type SelectionMode = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.SelectionMode

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListAdvancedExample: DetailsListAdvancedExampleStatic

    type [<AllowNullLiteral>] IDetailsListAdvancedExampleState =
        abstract canResizeColumns: bool option with get, set
        abstract checkboxVisibility: CheckboxVisibility option with get, set
        abstract columns: ResizeArray<IColumn> option with get, set
        abstract constrainMode: ConstrainMode option with get, set
        abstract contextualMenuProps: IContextualMenuProps option with get, set
        abstract groupItemLimit: float option with get, set
        abstract groups: ResizeArray<IGroup> option with get, set
        abstract isHeaderVisible: bool option with get, set
        abstract isLazyLoaded: bool option with get, set
        abstract isSortedDescending: bool option with get, set
        abstract items: ResizeArray<obj option> option with get, set
        abstract layoutMode: LayoutMode option with get, set
        abstract selectionMode: SelectionMode option with get, set
        abstract sortedColumnKey: string option with get, set

    type [<AllowNullLiteral>] DetailsListAdvancedExample =
        inherit React.Component<obj, IDetailsListAdvancedExampleState>
        abstract _isFetchingItems: obj with get, set
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDataMiss: index: obj -> unit
        abstract _onRenderMissingItem: obj with get, set
        abstract _onToggleLazyLoad: obj with get, set
        abstract _onToggleResizing: obj with get, set
        abstract _onLayoutChanged: obj with get, set
        abstract _onConstrainModeChanged: obj with get, set
        abstract _onSelectionChanged: obj with get, set
        abstract _onItemLimitChanged: obj with get, set
        abstract _getCommandItems: obj with get, set
        abstract _getContextualMenuProps: ev: obj * column: obj -> unit
        abstract _onItemInvoked: obj with get, set
        abstract _onItemContextMenu: obj with get, set
        abstract _onColumnClick: obj with get, set
        abstract _onColumnContextMenu: obj with get, set
        abstract _onContextualMenuDismissed: obj with get, set
        abstract _onSortColumn: obj with get, set
        abstract _onGroupByColumn: obj with get, set
        abstract _groupByKey: groups: obj * items: obj * key: obj -> unit
        abstract _groupItems: items: obj * columnKey: obj -> unit
        abstract _getGroups: groupedItems: obj * key: obj * ?parentGroup: obj -> unit
        abstract _getLeafGroupKey: key: obj * separator: obj -> unit
        abstract _onAddRow: obj with get, set
        abstract _onDeleteRow: obj with get, set
        abstract _buildColumns: items: obj * ?canResizeColumns: obj * ?onColumnClick: obj * ?sortedColumnKey: obj * ?isSortedDescending: obj * ?groupedColumnKey: obj * ?onColumnContextMenu: obj -> unit

    type [<AllowNullLiteral>] DetailsListAdvancedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListAdvancedExampleStaticProps -> DetailsListAdvancedExample

    type [<AllowNullLiteral>] DetailsListAdvancedExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListBasicExample: DetailsListBasicExampleStatic

    type [<AllowNullLiteral>] DetailsListBasicExample =
        inherit React.Component<obj, obj>
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getSelectionDetails: unit -> unit
        abstract _onChanged: obj with get, set
        abstract _onItemInvoked: item: obj -> unit

    type [<AllowNullLiteral>] DetailsListBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListBasicExampleStaticProps -> DetailsListBasicExample

    type [<AllowNullLiteral>] DetailsListBasicExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_Compact_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListCompactExample: DetailsListCompactExampleStatic

    type [<AllowNullLiteral>] DetailsListCompactExample =
        inherit React.Component<obj, obj>
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getSelectionDetails: unit -> unit
        abstract _onChanged: obj with get, set
        abstract _onItemInvoked: item: obj -> unit

    type [<AllowNullLiteral>] DetailsListCompactExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListCompactExampleStaticProps -> DetailsListCompactExample

    type [<AllowNullLiteral>] DetailsListCompactExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_CustomColumns_Example =
    type IColumn = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.IColumn

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListCustomColumnsExample: DetailsListCustomColumnsExampleStatic

    type [<AllowNullLiteral>] IDetailsListCustomColumnsExampleState =
        abstract sortedItems: ResizeArray<obj option> option with get, set
        abstract columns: ResizeArray<IColumn> option with get, set

    type [<AllowNullLiteral>] DetailsListCustomColumnsExample =
        inherit React.Component<obj, IDetailsListCustomColumnsExampleState>
        abstract render: unit -> JSX.Element
        abstract _onColumnClick: obj with get, set
        abstract _onColumnHeaderContextMenu: column: obj * ev: obj -> unit
        abstract _onItemInvoked: item: obj * index: obj -> unit

    type [<AllowNullLiteral>] DetailsListCustomColumnsExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListCustomColumnsExampleStaticProps -> DetailsListCustomColumnsExample

    type [<AllowNullLiteral>] DetailsListCustomColumnsExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_CustomGroupHeaders_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListCustomGroupHeadersExample: DetailsListCustomGroupHeadersExampleStatic

    type [<AllowNullLiteral>] DetailsListCustomGroupHeadersExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onToggleSelectGroup: props: obj -> unit
        abstract _onToggleCollapse: props: obj -> unit

    type [<AllowNullLiteral>] DetailsListCustomGroupHeadersExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListCustomGroupHeadersExampleStaticProps -> DetailsListCustomGroupHeadersExample

    type [<AllowNullLiteral>] DetailsListCustomGroupHeadersExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_CustomRows_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListCustomRowsExample: DetailsListCustomRowsExampleStatic

    type [<AllowNullLiteral>] DetailsListCustomRowsExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onRenderRow: obj with get, set
        abstract _onRenderCheck: obj with get, set

    type [<AllowNullLiteral>] DetailsListCustomRowsExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListCustomRowsExampleStaticProps -> DetailsListCustomRowsExample

    type [<AllowNullLiteral>] DetailsListCustomRowsExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_Documents_Example =
    type IColumn = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.IColumn

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListDocumentsExample: DetailsListDocumentsExampleStatic

    type [<AllowNullLiteral>] IDetailsListDocumentsExampleState =
        abstract columns: ResizeArray<IColumn> with get, set
        abstract items: ResizeArray<IDocument> with get, set
        abstract selectionDetails: string with get, set
        abstract isModalSelection: bool with get, set
        abstract isCompactMode: bool with get, set

    type [<AllowNullLiteral>] IDocument =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set
        abstract name: string with get, set
        abstract value: string with get, set
        abstract iconName: string with get, set
        abstract modifiedBy: string with get, set
        abstract dateModified: string with get, set
        abstract dateModifiedValue: float with get, set
        abstract fileSize: string with get, set
        abstract fileSizeRaw: float with get, set

    type [<AllowNullLiteral>] DetailsListDocumentsExample =
        inherit React.Component<obj option, IDetailsListDocumentsExampleState>
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract componentDidUpdate: previousProps: obj option * previousState: IDetailsListDocumentsExampleState -> unit
        abstract _onChangeCompactMode: obj with get, set
        abstract _onChangeModalSelection: obj with get, set
        abstract _onChangeText: obj with get, set
        abstract _onItemInvoked: item: obj -> unit
        abstract _randomDate: start: obj * ``end``: obj -> unit
        abstract _randomFileIcon: unit -> unit
        abstract _randomFileSize: unit -> unit
        abstract _getSelectionDetails: unit -> unit
        abstract _onColumnClick: obj with get, set
        abstract _sortItems: obj with get, set

    type [<AllowNullLiteral>] DetailsListDocumentsExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> DetailsListDocumentsExample

module __components_DetailsList_examples_DetailsList_DragDrop_Example =
    type IColumn = __components_DetailsList_examples_office_ui_fabric_react_lib_DetailsList.IColumn

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListDragDropExample: DetailsListDragDropExampleStatic

    type [<AllowNullLiteral>] DetailsListDragDropExample =
        inherit React.Component<obj, obj>
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _handleColumnReorder: draggedIndex: obj * targetIndex: obj -> unit
        abstract _getColumnReorderOptions: unit -> unit
        abstract _validateNumber: value: obj -> unit
        abstract _onChangeStartCountText: text: obj -> unit
        abstract _onChangeEndCountText: text: obj -> unit
        abstract _onChangeColumnReorderEnabled: ``checked``: obj -> unit
        abstract _getDragDropEvents: unit -> unit
        abstract _onItemInvoked: item: obj -> unit
        abstract _onRenderItemColumn: item: obj * index: obj * column: obj -> unit
        abstract _insertBeforeItem: item: obj -> unit

    type [<AllowNullLiteral>] DetailsListDragDropExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListDragDropExampleStaticProps -> DetailsListDragDropExample

    type [<AllowNullLiteral>] DetailsListDragDropExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_Grouped_Example =
    type BaseComponent = __components_DetailsList_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListGroupedExample: DetailsListGroupedExampleStatic

    type [<AllowNullLiteral>] DetailsListGroupedExample =
        inherit BaseComponent<obj, obj>
        abstract _root: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _addItem: obj with get, set
        abstract _onRenderColumn: item: obj * index: obj * column: obj -> unit

    type [<AllowNullLiteral>] DetailsListGroupedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DetailsListGroupedExampleStaticProps -> DetailsListGroupedExample

    type [<AllowNullLiteral>] DetailsListGroupedExampleStaticProps =
        interface end

module __components_DetailsList_examples_DetailsList_NavigatingFocus_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DetailsListNavigatingFocusExample: DetailsListNavigatingFocusExampleStatic

    type [<AllowNullLiteral>] IDetailsListNavigatingFocusExampleState =
        abstract items: obj option with get, set
        abstract initialFocusedIndex: float option with get, set

    type [<AllowNullLiteral>] DetailsListNavigatingFocusExample =
        inherit React.Component<obj, IDetailsListNavigatingFocusExampleState>
        abstract state: IDetailsListNavigatingFocusExampleState with get, set
        abstract _columns: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _navigate: obj with get, set

    type [<AllowNullLiteral>] DetailsListNavigatingFocusExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DetailsListNavigatingFocusExample

module __components_Dialog_examples_Dialog_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DialogBasicExample: DialogBasicExampleStatic

    type [<AllowNullLiteral>] DialogBasicExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showDialog: obj with get, set
        abstract _closeDialog: obj with get, set

    type [<AllowNullLiteral>] DialogBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DialogBasicExampleStaticProps -> DialogBasicExample

    type [<AllowNullLiteral>] DialogBasicExampleStaticProps =
        interface end

module __components_Dialog_examples_Dialog_Blocking_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DialogBlockingExample: DialogBlockingExampleStatic

    type [<AllowNullLiteral>] DialogBlockingExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showDialog: obj with get, set
        abstract _closeDialog: obj with get, set

    type [<AllowNullLiteral>] DialogBlockingExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DialogBlockingExampleStaticProps -> DialogBlockingExample

    type [<AllowNullLiteral>] DialogBlockingExampleStaticProps =
        interface end

module __components_Dialog_examples_Dialog_LargeHeader_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DialogLargeHeaderExample: DialogLargeHeaderExampleStatic

    type [<AllowNullLiteral>] DialogLargeHeaderExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showDialog: obj with get, set
        abstract _closeDialog: obj with get, set
        abstract _onChoiceChanged: unit -> unit

    type [<AllowNullLiteral>] DialogLargeHeaderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DialogLargeHeaderExampleStaticProps -> DialogLargeHeaderExample

    type [<AllowNullLiteral>] DialogLargeHeaderExampleStaticProps =
        interface end

module __components_Divider_examples_VerticalDivider_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract VerticalDividerBasicExample: VerticalDividerBasicExampleStatic

    type [<AllowNullLiteral>] VerticalDividerBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] VerticalDividerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> VerticalDividerBasicExample

module __components_Divider_examples_VerticalDivider_Custom_Example =

    type [<AllowNullLiteral>] IExports =
        abstract VerticalDividerCustomExample: VerticalDividerCustomExampleStatic

    type [<AllowNullLiteral>] VerticalDividerCustomExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] VerticalDividerCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> VerticalDividerCustomExample

module __components_DocumentCard_examples_data =

    type [<AllowNullLiteral>] IExports =
        abstract completeParts: ResizeArray<obj>

module __components_DocumentCard_examples_DocumentCard_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardBasicExample: DocumentCardBasicExampleStatic

    type [<AllowNullLiteral>] DocumentCardBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardBasicExample

module __components_DocumentCard_examples_DocumentCard_Compact_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardCompactExample: DocumentCardCompactExampleStatic

    type [<AllowNullLiteral>] DocumentCardCompactExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DocumentCardCompactExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardCompactExample

module __components_DocumentCard_examples_DocumentCard_Complete_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DocumentCardCompleteExample: DocumentCardCompleteExampleStatic

    type [<AllowNullLiteral>] DocumentCardCompleteExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onClick: unit -> unit

    type [<AllowNullLiteral>] DocumentCardCompleteExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DocumentCardCompleteExample

module __components_Dropdown_examples_Dropdown_Basic_Example =
    type IDropdownOption = __components_Dropdown_examples_office_ui_fabric_react_lib_Dropdown.IDropdownOption
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DropdownBasicExample: DropdownBasicExampleStatic

    type [<AllowNullLiteral>] DropdownBasicExample =
        inherit BaseComponent<obj, obj>
        abstract _basicDropdown: obj with get, set
        abstract render: unit -> JSX.Element
        abstract changeState: (IDropdownOption -> unit) with get, set
        abstract onChangeMultiSelect: (IDropdownOption -> unit) with get, set
        abstract copyArray: (ResizeArray<obj option> -> ResizeArray<obj option>) with get, set
        abstract _onSetFocusButtonClicked: obj with get, set
        abstract _log: str: obj -> unit

    type [<AllowNullLiteral>] DropdownBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DropdownBasicExampleStaticProps -> DropdownBasicExample

    type [<AllowNullLiteral>] DropdownBasicExampleStaticProps =
        interface end

module __components_Dropdown_examples_Dropdown_Custom_Example =

    type [<AllowNullLiteral>] IExports =
        abstract DropdownCustomExample: DropdownCustomExampleStatic

    type [<AllowNullLiteral>] DropdownCustomExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onRenderOption: obj with get, set
        abstract _onRenderTitle: obj with get, set
        abstract _onRenderPlaceHolder: obj with get, set
        abstract _onRenderCaretDown: obj with get, set

    type [<AllowNullLiteral>] DropdownCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DropdownCustomExampleStaticProps -> DropdownCustomExample

    type [<AllowNullLiteral>] DropdownCustomExampleStaticProps =
        interface end

module __components_Dropdown_examples_Dropdown_Error_Example =
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DropdownErrorExample: DropdownErrorExampleStatic

    type [<AllowNullLiteral>] DropdownErrorExample =
        inherit BaseComponent<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] DropdownErrorExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DropdownErrorExampleStaticProps -> DropdownErrorExample

    type [<AllowNullLiteral>] DropdownErrorExampleStaticProps =
        interface end

module __components_ExtendedPicker_examples_ExtendedPeoplePicker_Basic_Example =
    type BaseComponent = __components_ExtendedPicker_examples_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IPersonaProps = __components_ExtendedPicker_examples_office_ui_fabric_react_lib_Persona.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract ExtendedPeoplePickerTypesExample: ExtendedPeoplePickerTypesExampleStatic

    type [<AllowNullLiteral>] IPeoplePickerExampleState =
        abstract peopleList: ResizeArray<IPersonaProps> with get, set
        abstract mostRecentlyUsed: ResizeArray<IPersonaProps> with get, set
        abstract searchMoreAvailable: bool with get, set

    type [<AllowNullLiteral>] ExtendedPeoplePickerTypesExample =
        inherit BaseComponent<obj, IPeoplePickerExampleState>
        abstract _picker: obj with get, set
        abstract _floatingPickerProps: obj with get, set
        abstract _selectedItemsListProps: obj with get, set
        abstract _suggestionProps: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _renderExtendedPicker: unit -> unit
        abstract _renderHeader: unit -> unit
        abstract _onRenderFloatingPicker: props: obj -> unit
        abstract _onRenderSelectedItems: props: obj -> unit
        abstract _getEditingItemText: item: obj -> unit
        abstract _setComponentRef: obj with get, set
        abstract _onSetFocusButtonClicked: obj with get, set
        abstract _onExpandItem: obj with get, set
        abstract _onRemoveSuggestion: obj with get, set
        abstract _onFilterChanged: obj with get, set
        abstract _returnMostRecentlyUsed: obj with get, set
        abstract _onCopyItems: items: obj -> unit
        abstract _shouldShowForceResolve: obj with get, set
        abstract _shouldShowSuggestedContacts: obj with get, set
        abstract _listContainsPersona: persona: obj * personas: obj -> unit
        abstract _filterPersonasByText: filterText: obj -> unit
        abstract _doesTextStartWith: text: obj * filterText: obj -> unit
        abstract _removeDuplicates: personas: obj * possibleDupes: obj -> unit
        abstract _onInputChanged: obj with get, set
        abstract _getTextFromItem: persona: obj -> unit
        abstract _convertResultsToPromise: results: obj -> unit
        abstract _validateInput: obj with get, set
        abstract _getExpandedGroupItems: item: obj -> unit

    type [<AllowNullLiteral>] ExtendedPeoplePickerTypesExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ExtendedPeoplePickerTypesExampleStaticProps -> ExtendedPeoplePickerTypesExample

    type [<AllowNullLiteral>] ExtendedPeoplePickerTypesExampleStaticProps =
        interface end

module __components_ExtendedPicker_examples_ExtendedPeoplePicker_Basic_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract headerItem: obj
        abstract footerItem: obj

module __components_ExtendedPicker_examples_PeopleExampleData =
    type IExtendedPersonaProps = __components_SelectedItemsList.IExtendedPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract people: ResizeArray<obj>
        abstract mru: ResizeArray<IExtendedPersonaProps>
        abstract groupOne: ResizeArray<IExtendedPersonaProps>
        abstract groupTwo: ResizeArray<IExtendedPersonaProps>

module __components_ExtendedPicker_PeoplePicker_ExtendedPeoplePicker =
    type IPickerItemProps = Pickers.IPickerItemProps
    type IExtendedPersonaProps = SelectedItemsList.IExtendedPersonaProps
    type IPersonaProps = Persona.IPersonaProps
    type BaseExtendedPicker = __components_ExtendedPicker_BaseExtendedPicker.BaseExtendedPicker
    type IBaseExtendedPickerProps = __components_ExtendedPicker_BaseExtendedPicker_types.IBaseExtendedPickerProps

    type [<AllowNullLiteral>] IExports =
        abstract BaseExtendedPeoplePicker: BaseExtendedPeoplePickerStatic
        abstract ExtendedPeoplePicker: ExtendedPeoplePickerStatic

    type [<AllowNullLiteral>] IPeoplePickerItemProps =
        inherit IPickerItemProps<IExtendedPersonaProps>

    type [<AllowNullLiteral>] IExtendedPeoplePickerProps =
        inherit IBaseExtendedPickerProps<IPersonaProps>

    type [<AllowNullLiteral>] BaseExtendedPeoplePicker =
        inherit BaseExtendedPicker<IPersonaProps, IExtendedPeoplePickerProps>

    type [<AllowNullLiteral>] BaseExtendedPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BaseExtendedPeoplePicker

    type [<AllowNullLiteral>] ExtendedPeoplePicker =
        inherit BaseExtendedPeoplePicker

    type [<AllowNullLiteral>] ExtendedPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ExtendedPeoplePicker

module __components_ExtendedPicker_PeoplePicker_ExtendedPeoplePicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract resultContent: obj
        abstract resultItem: obj
        abstract peoplePickerPersona: obj
        abstract peoplePicker: obj
        abstract peoplePickerPersonaContent: obj

module __components_ExtendedPicker_PeoplePicker_ExtendedPeoplePickerPage =
    type IComponentDemoPageProps = __components_ExtendedPicker_PeoplePicker_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract ExtendedPeoplePickerPage: ExtendedPeoplePickerPageStatic

    type [<AllowNullLiteral>] ExtendedPeoplePickerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ExtendedPeoplePickerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ExtendedPeoplePickerPage

module __components_Facepile_examples_Facepile_AddFace_Example =

    type [<AllowNullLiteral>] IExports =
        abstract FacepileAddFaceExample: FacepileAddFaceExampleStatic

    type [<AllowNullLiteral>] IFacepileAddFaceExampleState =
        abstract numberOfFaces: float with get, set

    type [<AllowNullLiteral>] FacepileAddFaceExample =
        inherit React.Component<obj, IFacepileAddFaceExampleState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FacepileAddFaceExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: FacepileAddFaceExampleStaticProps -> FacepileAddFaceExample

    type [<AllowNullLiteral>] FacepileAddFaceExampleStaticProps =
        interface end

module __components_Facepile_examples_Facepile_Basic_Example =
    type PersonaSize = __components_Facepile_examples_office_ui_fabric_react_lib_Persona.PersonaSize

    type [<AllowNullLiteral>] IExports =
        abstract FacepileBasicExample: FacepileBasicExampleStatic

    type [<AllowNullLiteral>] IFacepileBasicExampleState =
        abstract numberOfFaces: obj option with get, set
        abstract imagesFadeIn: bool with get, set
        abstract personaSize: PersonaSize with get, set

    type [<AllowNullLiteral>] FacepileBasicExample =
        inherit React.Component<obj, IFacepileBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onChangeFadeIn: obj with get, set
        abstract _onChangePersonaNumber: obj with get, set
        abstract _onChangePersonaSize: obj with get, set

    type [<AllowNullLiteral>] FacepileBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: FacepileBasicExampleStaticProps -> FacepileBasicExample

    type [<AllowNullLiteral>] FacepileBasicExampleStaticProps =
        interface end

module __components_Facepile_examples_Facepile_Overflow_Example =
    type OverflowButtonType = __components_Facepile_examples_office_ui_fabric_react_lib_Facepile.OverflowButtonType

    type [<AllowNullLiteral>] IExports =
        abstract FacepileOverflowExample: FacepileOverflowExampleStatic

    type [<AllowNullLiteral>] IFacepileOverflowExampleState =
        abstract displayedPersonas: obj option with get, set
        abstract overflowButtonType: OverflowButtonType with get, set

    type [<AllowNullLiteral>] FacepileOverflowExample =
        inherit React.Component<obj, IFacepileOverflowExampleState>
        abstract render: unit -> JSX.Element
        abstract _onChangePersonaNumber: obj with get, set
        abstract _onChangeType: obj with get, set

    type [<AllowNullLiteral>] FacepileOverflowExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: FacepileOverflowExampleStaticProps -> FacepileOverflowExample

    type [<AllowNullLiteral>] FacepileOverflowExampleStaticProps =
        interface end

module __components_Facepile_examples_FacepileExampleData =
    type IFacepilePersona = __components_Facepile_examples_office_ui_fabric_react_lib_Facepile.IFacepilePersona

    type [<AllowNullLiteral>] IExports =
        abstract facepilePersonas: ResizeArray<IFacepilePersona>

module __components_FloatingPicker_PeoplePicker_FloatingPeoplePicker =
    type BaseFloatingPicker = __components_FloatingPicker_BaseFloatingPicker.BaseFloatingPicker
    type IBaseFloatingPickerProps = __components_FloatingPicker_BaseFloatingPicker_types.IBaseFloatingPickerProps
    type IPersonaProps = Persona.IPersonaProps
    type ISuggestionModel = Pickers.ISuggestionModel

    type [<AllowNullLiteral>] IExports =
        abstract BaseFloatingPeoplePicker: BaseFloatingPeoplePickerStatic
        abstract FloatingPeoplePicker: FloatingPeoplePickerStatic
        abstract createItem: name: string * isValid: bool -> ISuggestionModel<IPersonaProps>

    type [<AllowNullLiteral>] IPeopleFloatingPickerProps =
        inherit IBaseFloatingPickerProps<IPersonaProps>

    type [<AllowNullLiteral>] BaseFloatingPeoplePicker =
        inherit BaseFloatingPicker<IPersonaProps, IPeopleFloatingPickerProps>

    type [<AllowNullLiteral>] BaseFloatingPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BaseFloatingPeoplePicker

    type [<AllowNullLiteral>] FloatingPeoplePicker =
        inherit BaseFloatingPeoplePicker
        abstract defaultProps: obj option with get, set

    type [<AllowNullLiteral>] FloatingPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FloatingPeoplePicker

module __components_FloatingPicker_PeoplePicker_FloatingPeoplePickerPage =
    type IComponentDemoPageProps = __components_FloatingPicker_PeoplePicker_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract FloatingPeoplePickerPage: FloatingPeoplePickerPageStatic

    type [<AllowNullLiteral>] FloatingPeoplePickerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FloatingPeoplePickerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FloatingPeoplePickerPage

module __components_FloatingPicker_PeoplePicker_PeoplePicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract resultContent: obj
        abstract resultItem: obj
        abstract peoplePickerPersona: obj
        abstract peoplePicker: obj
        abstract peoplePickerPersonaContent: obj

module __components_FloatingPicker_Suggestions_Suggestions_types =
    type ISuggestionModel = Pickers.ISuggestionModel
    type IPersonaProps = Persona.IPersonaProps

    type [<AllowNullLiteral>] ISuggestionsCoreProps<'T> =
        inherit React.Props<obj option>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// How the suggestion should look in the suggestion list.
        abstract onRenderSuggestion: ('T -> 'T -> JSX.Element) option with get, set
        /// What should occur when a suggestion is clicked
        abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> obj option -> float -> unit) with get, set
        /// The list of Suggestions that will be displayed
        abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
        /// Function to fire when one of the optional remove buttons on a suggestion is clicked.
        abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> IPersonaProps -> float -> unit) option with get, set
        /// Screen reader message to read when there are suggestions available.
        abstract suggestionsAvailableAlertText: string option with get, set
        /// An ARIA label for the container that is the parent of the suggestions.
        abstract suggestionsContainerAriaLabel: string option with get, set
        /// the classname of the suggestionitem.
        abstract suggestionsItemClassName: string option with get, set
        /// Maximum number of suggestions to show in the full suggestion list.
        abstract resultsMaximumNumber: float option with get, set
        /// Indicates whether to show a button with each suggestion to remove that suggestion.
        abstract showRemoveButtons: bool option with get, set
        /// Indicates whether to loop around to the top or bottom of the the suggestions
        /// on calling nextSuggestion and previousSuggestion, respectively
        abstract shouldLoopSelection: bool with get, set

    type [<AllowNullLiteral>] ISuggestionsControlProps<'T> =
        inherit React.Props<obj option>
        inherit ISuggestionsCoreProps<'T>
        /// An ARIA label for the container that is the parent of the suggestions header items.
        abstract suggestionsHeaderContainerAriaLabel: string option with get, set
        /// An ARIA label for the container that is the parent of the suggestions footer items.
        abstract suggestionsFooterContainerAriaLabel: string option with get, set
        /// The header items props
        abstract headerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
        /// The footer items props
        abstract footerItemsProps: ResizeArray<ISuggestionsHeaderFooterProps> option with get, set
        /// Whether or not the first selectable item in the suggestions list should be selected
        abstract shouldSelectFirstItem: (unit -> bool) option with get, set
        /// The CSS classname of the suggestions list.
        abstract className: string option with get, set
        /// Completes the suggestion
        abstract completeSuggestion: (unit -> unit) with get, set

    type [<AllowNullLiteral>] ISuggestionsHeaderFooterProps =
        abstract renderItem: (unit -> JSX.Element) with get, set
        abstract onExecute: (unit -> unit) option with get, set
        abstract className: string option with get, set
        abstract ariaLabel: string option with get, set
        abstract shouldShow: (unit -> bool) with get, set

    type [<AllowNullLiteral>] ISuggestionsHeaderFooterItemProps =
        abstract componentRef: (unit -> unit) option with get, set
        abstract renderItem: (unit -> JSX.Element) with get, set
        abstract onExecute: (unit -> unit) option with get, set
        abstract isSelected: bool with get, set
        abstract id: string with get, set
        abstract className: string option with get, set

module __components_FloatingPicker_Suggestions_SuggestionsControl =
    type BaseComponent = Utilities.BaseComponent
    type IButton = Button.IButton
    type ISuggestionModel = Pickers.ISuggestionModel
    type ISuggestionsHeaderFooterItemProps = __components_FloatingPicker_Suggestions_Suggestions_types.ISuggestionsHeaderFooterItemProps
    type ISuggestionsControlProps = __components_FloatingPicker_Suggestions_Suggestions_types.ISuggestionsControlProps
    type SuggestionsCore = __components_FloatingPicker_Suggestions_SuggestionsCore.SuggestionsCore

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionsHeaderFooterItem: SuggestionsHeaderFooterItemStatic
        abstract SuggestionsControl: SuggestionsControlStatic

    type [<RequireQualifiedAccess>] SuggestionItemType =
        | Header = 0
        | Suggestion = 1
        | Footer = 2

    type [<AllowNullLiteral>] ISuggestionsControlState =
        abstract selectedHeaderIndex: float with get, set
        abstract selectedFooterIndex: float with get, set

    type [<AllowNullLiteral>] SuggestionsHeaderFooterItem =
        inherit BaseComponent<ISuggestionsHeaderFooterItemProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SuggestionsHeaderFooterItemStatic =
        [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsControlProps<T> -> SuggestionsHeaderFooterItem

    /// Class when used with SuggestionsStore, renders a suggestions control with customizable headers and footers
    type [<AllowNullLiteral>] SuggestionsControl<'T> =
        inherit BaseComponent<ISuggestionsControlProps<'T>, ISuggestionsControlState>
        abstract _forceResolveButton: IButton with get, set
        abstract _searchForMoreButton: IButton with get, set
        abstract _selectedElement: HTMLDivElement with get, set
        abstract _suggestions: SuggestionsCore<'T> with get, set
        abstract SuggestionsOfProperType: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract componentWillReceiveProps: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract currentSuggestion: ISuggestionModel<'T>
        abstract hasSuggestionSelected: unit -> bool
        abstract hasSelection: unit -> bool
        abstract executeSelectedAction: unit -> unit
        abstract removeSuggestion: ?index: float -> unit
        /// <summary>Handles the key down, returns true, if the event was handled, false otherwise</summary>
        /// <param name="keyCode">The keyCode to handle</param>
        abstract handleKeyDown: keyCode: float -> bool
        abstract scrollSelected: unit -> unit
        abstract renderHeaderItems: unit -> JSX.Element option
        abstract renderFooterItems: unit -> JSX.Element option
        abstract _renderSuggestions: unit -> JSX.Element
        /// Selects the next selectable item
        abstract selectNextItem: itemType: SuggestionItemType * ?originalItemType: SuggestionItemType -> unit
        /// Selects the previous selectable item
        abstract selectPreviousItem: itemType: SuggestionItemType * ?originalItemType: SuggestionItemType -> unit
        /// Resets the selected state and selects the first selectable item
        abstract resetSelectedItem: unit -> unit
        /// Selects the first item
        abstract selectFirstItem: unit -> unit
        /// Selects the last item
        abstract selectLastItem: unit -> unit
        /// <summary>Selects the next item in the suggestion item type group, given the current index
        /// If none is able to be selected, returns false, otherwise returns true</summary>
        /// <param name="itemType">The suggestion item type</param>
        /// <param name="currentIndex">The current index, default is -1</param>
        abstract _selectNextItemOfItemType: itemType: obj * ?currentIndex: obj -> unit
        /// <summary>Selects the previous item in the suggestion item type group, given the current index
        /// If none is able to be selected, returns false, otherwise returns true</summary>
        /// <param name="itemType">The suggestion item type</param>
        /// <param name="currentIndex">The current index. If none is provided, the default is the items length of specified type</param>
        abstract _selectPreviousItemOfItemType: itemType: obj * ?currentIndex: obj -> unit
        abstract _getCurrentIndexForType: itemType: obj -> unit
        abstract _getNextItemSectionType: itemType: obj -> unit
        abstract _getPreviousItemSectionType: itemType: obj -> unit

    /// Class when used with SuggestionsStore, renders a suggestions control with customizable headers and footers
    type [<AllowNullLiteral>] SuggestionsControlStatic =
        [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsControlProps<'T> -> SuggestionsControl<'T>

module __components_FloatingPicker_Suggestions_SuggestionsControl_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract actionButton: obj
        abstract buttonSelected: obj
        abstract suggestionsTitle: obj
        abstract suggestionsSpinner: obj
        abstract itemButton: obj

module __components_FloatingPicker_Suggestions_SuggestionsCore =
    type BaseComponent = Utilities.BaseComponent
    type ISuggestionModel = Pickers.ISuggestionModel
    type ISuggestionsCoreProps = __components_FloatingPicker_Suggestions_Suggestions_types.ISuggestionsCoreProps

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionsCore: SuggestionsCoreStatic

    /// Class when used with SuggestionsStore, renders a basic suggestions control
    type [<AllowNullLiteral>] SuggestionsCore<'T> =
        inherit BaseComponent<ISuggestionsCoreProps<'T>, obj>
        abstract currentIndex: float with get, set
        abstract currentSuggestion: ISuggestionModel<'T> option with get, set
        abstract _selectedElement: HTMLDivElement with get, set
        abstract SuggestionsItemOfProperType: obj with get, set
        /// Increments the selected suggestion index
        abstract nextSuggestion: unit -> bool
        /// Decrements the selected suggestion index
        abstract previousSuggestion: unit -> bool
        abstract getCurrentItem: unit -> ISuggestionModel<'T>
        abstract getSuggestionAtIndex: index: float -> ISuggestionModel<'T>
        abstract hasSuggestionSelected: unit -> bool
        abstract removeSuggestion: index: float -> unit
        abstract deselectAllSuggestions: unit -> unit
        abstract setSelectedSuggestion: index: float -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract scrollSelected: unit -> unit
        abstract _onClickTypedSuggestionsItem: item: obj * index: obj -> unit
        abstract _onRemoveTypedSuggestionsItem: item: obj * index: obj -> unit

    /// Class when used with SuggestionsStore, renders a basic suggestions control
    type [<AllowNullLiteral>] SuggestionsCoreStatic =
        [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsCoreProps<'T> -> SuggestionsCore<'T>

module __components_FloatingPicker_Suggestions_SuggestionsCore_scss =

    type [<AllowNullLiteral>] IExports =
        abstract suggestionsContainer: obj

module __components_FloatingPicker_Suggestions_SuggestionsStore =
    type ISuggestionModel = Pickers.ISuggestionModel

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionsStore: SuggestionsStoreStatic

    type [<AllowNullLiteral>] SuggestionsStore<'T> =
        abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
        abstract updateSuggestions: newSuggestions: ResizeArray<'T> -> unit
        abstract getSuggestions: unit -> ResizeArray<ISuggestionModel<'T>>
        abstract getSuggestionAtIndex: index: float -> ISuggestionModel<'T>
        abstract removeSuggestion: index: float -> unit
        abstract convertSuggestionsToSuggestionItems: suggestions: Array<U2<ISuggestionModel<'T>, 'T>> -> ResizeArray<ISuggestionModel<'T>>
        abstract _isSuggestionModel: value: obj -> unit
        abstract _ensureSuggestionModel: suggestion: obj -> unit

    type [<AllowNullLiteral>] SuggestionsStoreStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SuggestionsStore<'T>

module __components_FocusTrapZone_examples_FocusTrapZone_Box_Click_Example =

    type [<AllowNullLiteral>] IExports =
        abstract BoxNoClickExample: BoxNoClickExampleStatic

    type [<AllowNullLiteral>] IBoxNoClickExampleExampleState =
        abstract isToggled: bool with get, set

    type [<AllowNullLiteral>] BoxNoClickExample =
        inherit React.Component<React.HTMLAttributes<HTMLDivElement>, IBoxNoClickExampleExampleState>
        abstract _toggle: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _internalContents: unit -> unit
        abstract _onButtonClickHandler: obj with get, set
        abstract _onExitButtonClickHandler: obj with get, set
        abstract _onFocusTrapZoneToggleChanged: obj with get, set
        abstract _setRef: obj with get, set

    type [<AllowNullLiteral>] BoxNoClickExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: React.HTMLAttributes<HTMLDivElement> -> BoxNoClickExample

module __components_FocusTrapZone_examples_FocusTrapZone_Box_Example =

    type [<AllowNullLiteral>] IExports =
        abstract BoxExample: BoxExampleStatic

    type [<AllowNullLiteral>] IBoxExampleExampleState =
        abstract isChecked: bool with get, set

    type [<AllowNullLiteral>] BoxExample =
        inherit React.Component<React.HTMLAttributes<HTMLDivElement>, IBoxExampleExampleState>
        abstract _toggle: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _internalContents: unit -> unit
        abstract _onButtonClickHandler: obj with get, set
        abstract _onExitButtonClickHandler: obj with get, set
        abstract _onFocusTrapZoneToggleChanged: obj with get, set
        abstract _setRef: obj with get, set

    type [<AllowNullLiteral>] BoxExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: React.HTMLAttributes<HTMLDivElement> -> BoxExample

module __components_FocusTrapZone_examples_FocusTrapZone_Box_FocusOnCustomElement_Example =

    type [<AllowNullLiteral>] IExports =
        abstract BoxExample: BoxExampleStatic

    type [<AllowNullLiteral>] IBoxExampleExampleState =
        abstract isChecked: bool with get, set

    type [<AllowNullLiteral>] BoxExample =
        inherit React.Component<React.HTMLAttributes<HTMLDivElement>, IBoxExampleExampleState>
        abstract _toggle: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _internalContents: unit -> unit
        abstract _onButtonClickHandler: obj with get, set
        abstract _onExitButtonClickHandler: obj with get, set
        abstract _onFocusTrapZoneToggleChanged: obj with get, set
        abstract _setRef: obj with get, set

    type [<AllowNullLiteral>] BoxExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: React.HTMLAttributes<HTMLDivElement> -> BoxExample

module __components_FocusTrapZone_examples_FocusTrapZone_Nested_Example =

    type [<AllowNullLiteral>] IExports =
        abstract FocusTrapZoneNestedExample: FocusTrapZoneNestedExampleStatic

    type [<AllowNullLiteral>] IFocusTrapZoneNestedExampleState =
        abstract stateMap: obj with get, set

    type [<AllowNullLiteral>] FocusTrapZoneNestedExample =
        inherit React.Component<obj, IFocusTrapZoneNestedExampleState>
        abstract render: unit -> JSX.Element
        abstract _setIsActive: obj with get, set
        abstract _randomize: obj with get, set

    type [<AllowNullLiteral>] FocusTrapZoneNestedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: FocusTrapZoneNestedExampleStaticProps -> FocusTrapZoneNestedExample

    type [<AllowNullLiteral>] FocusTrapZoneNestedExampleStaticProps =
        interface end

module __components_FocusZone_examples_FocusZone_Disabled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract FocusZoneDisabledExample: (unit -> JSX.Element)

module __components_FocusZone_examples_FocusZone_List_Example =

    type [<AllowNullLiteral>] IExports =
        abstract FocusZoneListExample: FocusZoneListExampleStatic

    type [<AllowNullLiteral>] FocusZoneListExample =
        inherit React.Component
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _isInnerZoneKeystroke: ev: obj -> unit

    type [<AllowNullLiteral>] FocusZoneListExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: FocusZoneListExampleStaticProps -> FocusZoneListExample

    type [<AllowNullLiteral>] FocusZoneListExampleStaticProps =
        interface end

module __components_FocusZone_examples_FocusZone_Photos_Example =

    type [<AllowNullLiteral>] IExports =
        abstract FocusZonePhotosExample: (unit -> JSX.Element)

module __components_FocusZone_examples_FocusZone_Tabbable_Example =

    type [<AllowNullLiteral>] IExports =
        abstract FocusZoneTabbableExample: (unit -> JSX.Element)

module __components_GroupedList_examples_GroupedList_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract GroupedListBasicExample: GroupedListBasicExampleStatic

    type [<AllowNullLiteral>] GroupedListBasicExample =
        inherit React.Component
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onRenderCell: nestingDepth: obj * item: obj * itemIndex: obj -> unit

    type [<AllowNullLiteral>] GroupedListBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: GroupedListBasicExampleStaticProps -> GroupedListBasicExample

    type [<AllowNullLiteral>] GroupedListBasicExampleStaticProps =
        interface end

module __components_GroupedList_examples_GroupedList_Custom_Example =

    type [<AllowNullLiteral>] IExports =
        abstract GroupedListCustomExample: GroupedListCustomExampleStatic

    type [<AllowNullLiteral>] GroupedListCustomExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onRenderCell: nestingDepth: obj * item: obj * itemIndex: obj -> unit
        abstract _onRenderHeader: props: obj -> unit
        abstract _onRenderFooter: props: obj -> unit

    type [<AllowNullLiteral>] GroupedListCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: GroupedListCustomExampleStaticProps -> GroupedListCustomExample

    type [<AllowNullLiteral>] GroupedListCustomExampleStaticProps =
        interface end

module __components_HoverCard_examples_HoverCard_Basic_Example =
    type BaseComponent = __components_HoverCard_examples_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IColumn = __components_HoverCard_examples_office_ui_fabric_react_lib_DetailsList.IColumn

    type [<AllowNullLiteral>] IExports =
        abstract HoverCardBasicExample: HoverCardBasicExampleStatic

    type [<AllowNullLiteral>] IHoverCardExampleState =
        abstract items: ResizeArray<obj option> option with get, set
        abstract columns: ResizeArray<IColumn> option with get, set

    type [<AllowNullLiteral>] HoverCardBasicExample =
        inherit BaseComponent<obj, IHoverCardExampleState>
        abstract render: unit -> JSX.Element
        abstract _onRenderItemColumn: obj with get, set
        abstract _onRenderCompactCard: obj with get, set
        abstract _onRenderExpandedCard: obj with get, set

    type [<AllowNullLiteral>] HoverCardBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: HoverCardBasicExampleStaticProps -> HoverCardBasicExample

    type [<AllowNullLiteral>] HoverCardBasicExampleStaticProps =
        interface end

module __components_HoverCard_examples_HoverCard_Target_Example =
    type BaseComponent = __components_HoverCard_examples_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IColumn = __components_HoverCard_examples_office_ui_fabric_react_lib_DetailsList.IColumn

    type [<AllowNullLiteral>] IExports =
        abstract HoverCardTargetExample: HoverCardTargetExampleStatic

    type [<AllowNullLiteral>] IHoverCardExampleState =
        abstract items: ResizeArray<obj option> option with get, set
        abstract columns: ResizeArray<IColumn> option with get, set

    type [<AllowNullLiteral>] HoverCardTargetExample =
        inherit BaseComponent<obj, IHoverCardExampleState>
        abstract render: unit -> JSX.Element
        abstract _onRenderItemColumn: obj with get, set
        abstract _onRenderCompactCard: obj with get, set
        abstract _onRenderExpandedCard: obj with get, set

    type [<AllowNullLiteral>] HoverCardTargetExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: HoverCardTargetExampleStaticProps -> HoverCardTargetExample

    type [<AllowNullLiteral>] HoverCardTargetExampleStaticProps =
        interface end

module __components_Icon_examples_Icon_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract IconBasicExample: IconBasicExampleStatic

    type [<AllowNullLiteral>] IconBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] IconBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IconBasicExample

module __components_Icon_examples_Icon_Color_Example =

    type [<AllowNullLiteral>] IExports =
        abstract IconColorExample: IconColorExampleStatic

    type [<AllowNullLiteral>] IconColorExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] IconColorExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IconColorExample

module __components_Icon_examples_Icon_ImageSheet_Example =

    type [<AllowNullLiteral>] IExports =
        abstract IconImageSheetExample: IconImageSheetExampleStatic

    type [<AllowNullLiteral>] IconImageSheetExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] IconImageSheetExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IconImageSheetExample

module __components_Icon_examples_Icon_Svg_Example =

    type [<AllowNullLiteral>] IExports =
        abstract IconSvgExample: IconSvgExampleStatic

    type [<AllowNullLiteral>] IconSvgExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] IconSvgExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> IconSvgExample

module __components_Image_examples_Image_Center_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ImageCenterExample: ImageCenterExampleStatic

    type [<AllowNullLiteral>] ImageCenterExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImageCenterExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImageCenterExample

module __components_Image_examples_Image_Contain_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ImageContainExample: ImageContainExampleStatic

    type [<AllowNullLiteral>] ImageContainExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImageContainExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImageContainExample

module __components_Image_examples_Image_Cover_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ImageCoverExample: ImageCoverExampleStatic

    type [<AllowNullLiteral>] ImageCoverExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImageCoverExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImageCoverExample

module __components_Image_examples_Image_Default_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ImageDefaultExample: ImageDefaultExampleStatic

    type [<AllowNullLiteral>] ImageDefaultExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImageDefaultExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImageDefaultExample

module __components_Image_examples_Image_MaximizeFrame_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ImageMaximizeFrameExample: ImageMaximizeFrameExampleStatic

    type [<AllowNullLiteral>] ImageMaximizeFrameExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImageMaximizeFrameExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImageMaximizeFrameExample

module __components_Image_examples_Image_None_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ImageNoneExample: ImageNoneExampleStatic

    type [<AllowNullLiteral>] ImageNoneExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ImageNoneExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ImageNoneExample

module __components_Keytip_examples_Keytips_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract KeytipsBasicExample: KeytipsBasicExampleStatic

    type [<AllowNullLiteral>] KeytipsBasicExample =
        inherit React.Component<obj>
        abstract _sampleOptions: obj with get, set
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] KeytipsBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> KeytipsBasicExample

module __components_Keytip_examples_Keytips_Button_Example =

    type [<AllowNullLiteral>] IExports =
        abstract KeytipsButtonExample: KeytipsButtonExampleStatic

    type [<AllowNullLiteral>] IKeytipsButtonExampleState =
        abstract btnDisabled: bool with get, set

    type [<AllowNullLiteral>] KeytipsButtonExample =
        inherit React.Component<obj, IKeytipsButtonExampleState>
        abstract render: unit -> JSX.Element
        abstract _toggleDisabled: obj with get, set

    type [<AllowNullLiteral>] KeytipsButtonExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: KeytipsButtonExampleStaticProps -> KeytipsButtonExample

    type [<AllowNullLiteral>] KeytipsButtonExampleStaticProps =
        interface end

module __components_Keytip_examples_Keytips_CommandBar_Example =

    type [<AllowNullLiteral>] IExports =
        abstract KeytipsCommandBarExample: KeytipsCommandBarExampleStatic

    type [<AllowNullLiteral>] IKeytipsCommandBarExampleState =
        abstract showModal: bool with get, set
        abstract showMessageBar: bool with get, set

    type [<AllowNullLiteral>] KeytipsCommandBarExample =
        inherit React.Component<obj, IKeytipsCommandBarExampleState>
        abstract render: unit -> JSX.Element
        abstract _showModal: obj with get, set
        abstract _hideModal: obj with get, set
        abstract _showMessageBar: obj with get, set
        abstract _hideMessageBar: obj with get, set

    type [<AllowNullLiteral>] KeytipsCommandBarExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: KeytipsCommandBarExampleStaticProps -> KeytipsCommandBarExample

    type [<AllowNullLiteral>] KeytipsCommandBarExampleStaticProps =
        interface end

module __components_Keytip_examples_Keytips_Overflow_Example =
    type IOverflowSetItemProps = __components_Keytip_examples_office_ui_fabric_react_lib_OverflowSet.IOverflowSetItemProps

    type [<AllowNullLiteral>] IExports =
        abstract KeytipsOverflowExample: KeytipsOverflowExampleStatic

    type [<AllowNullLiteral>] IKeytipsOverflowExampleState =
        abstract items: ResizeArray<IOverflowSetItemProps> with get, set
        abstract overflowItems: ResizeArray<IOverflowSetItemProps> with get, set

    type [<AllowNullLiteral>] KeytipsOverflowExample =
        inherit React.Component<obj, IKeytipsOverflowExampleState>
        abstract _initialItems: obj with get, set
        abstract _initialOverflowItems: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onRenderItem: item: obj -> unit
        abstract _onRenderOverflowButton: obj with get, set
        abstract _toggleOverflowItems: obj with get, set

    type [<AllowNullLiteral>] KeytipsOverflowExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: KeytipsOverflowExampleStaticProps -> KeytipsOverflowExample

    type [<AllowNullLiteral>] KeytipsOverflowExampleStaticProps =
        interface end

module __components_Keytip_examples_KeytipSetup =
    type IKeytipConfigMap = __utilities_keytips.IKeytipConfigMap

    type [<AllowNullLiteral>] IExports =
        abstract keytipMap: IKeytipConfigMap

module __components_Label_examples_Label_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract LabelBasicExample: (unit -> JSX.Element)

module __components_Layer_examples_Layer_Basic_Example =
    module PropTypes = Prop_types
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract LayerContentExample: LayerContentExampleStatic
        abstract LayerBasicExample: LayerBasicExampleStatic

    type [<AllowNullLiteral>] LayerContentExample =
        inherit BaseComponent<obj, obj>
        abstract contextTypes: obj with get, set
        abstract context: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LayerContentExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: LayerContentExampleStaticProps -> LayerContentExample

    type [<AllowNullLiteral>] LayerContentExampleStaticProps =
        interface end

    type [<AllowNullLiteral>] LayerBasicExample =
        inherit BaseComponent<obj, obj>
        abstract childContextTypes: obj with get, set
        abstract getChildContext: unit -> obj
        abstract render: unit -> JSX.Element
        abstract _onChange: ev: obj * ``checked``: obj -> unit

    type [<AllowNullLiteral>] LayerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: LayerBasicExampleStaticProps -> LayerBasicExample

    type [<AllowNullLiteral>] LayerBasicExampleStaticProps =
        interface end

module __components_Layer_examples_Layer_Customized_Example =

    type [<AllowNullLiteral>] IExports =
        abstract LayerCustomizedExample: LayerCustomizedExampleStatic

    type [<AllowNullLiteral>] ILayerCustomizedExampleState =
        abstract showPanel: bool with get, set
        abstract trapPanel: bool with get, set

    type [<AllowNullLiteral>] LayerCustomizedExample =
        inherit React.Component<obj, ILayerCustomizedExampleState>
        abstract render: unit -> JSX.Element
        abstract _onDismissPanel: obj with get, set
        abstract _onShowPanelChange: obj with get, set
        abstract _onTrapPanelChange: obj with get, set

    type [<AllowNullLiteral>] LayerCustomizedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: LayerCustomizedExampleStaticProps -> LayerCustomizedExample

    type [<AllowNullLiteral>] LayerCustomizedExampleStaticProps =
        interface end

module __components_Layer_examples_Layer_Hosted_Example =

    type [<AllowNullLiteral>] IExports =
        abstract LayerHostedExample: LayerHostedExampleStatic

    type [<AllowNullLiteral>] LayerHostedExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _log: text: obj -> unit
        abstract _onChangeCheckbox: obj with get, set
        abstract _onChangeCheckboxNoId: obj with get, set
        abstract _onChangeToggle: obj with get, set

    type [<AllowNullLiteral>] LayerHostedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: LayerHostedExampleStaticProps -> LayerHostedExample

    type [<AllowNullLiteral>] LayerHostedExampleStaticProps =
        interface end

module __components_Link_examples_Link_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract LinkBasicExample: LinkBasicExampleStatic

    type [<AllowNullLiteral>] LinkBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] LinkBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LinkBasicExample

module __components_List_examples_List_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ListBasicExample: ListBasicExampleStatic

    type [<AllowNullLiteral>] IListBasicExampleProps =
        abstract items: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] IListBasicExampleState =
        abstract filterText: string option with get, set
        abstract items: ResizeArray<obj option> option with get, set

    type [<AllowNullLiteral>] ListBasicExample =
        inherit React.Component<IListBasicExampleProps, obj option>
        abstract render: unit -> JSX.Element
        abstract _onFilterChanged: text: obj -> unit
        abstract _onRenderCell: item: obj * index: obj -> unit

    type [<AllowNullLiteral>] ListBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IListBasicExampleProps -> ListBasicExample

module __components_List_examples_List_Ghosting_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ListGhostingExample: ListGhostingExampleStatic

    type [<AllowNullLiteral>] IListGhostingExampleProps =
        abstract items: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] ListGhostingExample =
        inherit React.Component<IListGhostingExampleProps, obj>
        abstract render: unit -> JSX.Element
        abstract _onRenderCell: item: obj * index: obj * isScrolling: obj -> unit

    type [<AllowNullLiteral>] ListGhostingExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IListGhostingExampleProps -> ListGhostingExample

module __components_List_examples_List_Grid_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ListGridExample: ListGridExampleStatic

    type [<AllowNullLiteral>] IListGridExampleProps =
        abstract items: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] ListGridExample =
        inherit React.Component<IListGridExampleProps>
        abstract _columnCount: obj with get, set
        abstract _columnWidth: obj with get, set
        abstract _rowHeight: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getItemCountForPage: itemIndex: obj * surfaceRect: obj -> unit
        abstract _getPageHeight: itemIndex: obj * surfaceRect: obj -> unit
        abstract _onRenderCell: obj with get, set

    type [<AllowNullLiteral>] ListGridExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IListGridExampleProps -> ListGridExample

module __components_List_examples_List_Scrolling_Example =
    type ScrollToMode = __components_List_examples_office_ui_fabric_react_lib_List.ScrollToMode

    type [<AllowNullLiteral>] IExports =
        abstract ListScrollingExample: ListScrollingExampleStatic

    type [<AllowNullLiteral>] IListScrollingExampleProps =
        abstract items: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] IListScrollingExampleState =
        abstract selectedIndex: float with get, set
        abstract scrollToMode: ScrollToMode with get, set

    type [<AllowNullLiteral>] ListScrollingExample =
        inherit React.Component<IListScrollingExampleProps, IListScrollingExampleState>
        abstract _list: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getPageHeight: idx: obj -> unit
        abstract _onChangeText: obj with get, set
        abstract _onDropdownChanged: obj with get, set
        abstract _onRenderCell: obj with get, set
        abstract _scrollRelative: obj with get, set
        abstract _scroll: obj with get, set
        abstract _resolveList: obj with get, set

    type [<AllowNullLiteral>] ListScrollingExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IListScrollingExampleProps -> ListScrollingExample

module __components_MarqueeSelection_examples_MarqueeSelection_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract MarqueeSelectionBasicExample: MarqueeSelectionBasicExampleStatic

    type [<AllowNullLiteral>] IMarqueeSelectionBasicExampleState =
        abstract isMarqueeEnabled: bool with get, set

    type [<AllowNullLiteral>] MarqueeSelectionBasicExample =
        inherit React.Component<obj, IMarqueeSelectionBasicExampleState>
        abstract _selection: obj with get, set
        abstract _isMounted: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _log: text: obj -> unit
        abstract _onChange: obj with get, set

    type [<AllowNullLiteral>] MarqueeSelectionBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: MarqueeSelectionBasicExampleStaticProps -> MarqueeSelectionBasicExample

    type [<AllowNullLiteral>] MarqueeSelectionBasicExampleStaticProps =
        interface end

module __components_MessageBar_examples_MessageBar_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract MessageBarBasicExample: (unit -> JSX.Element)

module __components_Modal_examples_Modal_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ModalBasicExample: ModalBasicExampleStatic

    type [<AllowNullLiteral>] ModalBasicExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showModal: obj with get, set
        abstract _closeModal: obj with get, set

    type [<AllowNullLiteral>] ModalBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ModalBasicExampleStaticProps -> ModalBasicExample

    type [<AllowNullLiteral>] ModalBasicExampleStaticProps =
        interface end

module __components_Nav_examples_Nav_Basic_Example =
    type INavProps = __components_Nav_examples_office_ui_fabric_react_lib_Nav.INavProps

    type [<AllowNullLiteral>] IExports =
        abstract NavBasicExample: NavBasicExampleStatic

    type [<AllowNullLiteral>] NavBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onClickHandler: e: obj -> unit
        abstract _onClickHandler2: e: obj -> unit

    type [<AllowNullLiteral>] NavBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: INavProps -> NavBasicExample

module __components_Nav_examples_Nav_ByKeys_Example =

    type [<AllowNullLiteral>] IExports =
        abstract NavByKeysExample: NavByKeysExampleStatic

    type [<AllowNullLiteral>] NavByKeysExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] NavByKeysExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NavByKeysExample

module __components_Nav_examples_Nav_FabricDemoApp_Example =

    type [<AllowNullLiteral>] IExports =
        abstract NavFabricDemoAppExample: NavFabricDemoAppExampleStatic

    type [<AllowNullLiteral>] NavFabricDemoAppExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onRenderLink: obj with get, set

    type [<AllowNullLiteral>] NavFabricDemoAppExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NavFabricDemoAppExample

module __components_Nav_examples_Nav_Nested_Example =

    type [<AllowNullLiteral>] IExports =
        abstract NavNestedExample: NavNestedExampleStatic

    type [<AllowNullLiteral>] NavNestedExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] NavNestedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NavNestedExample

module __components_OverflowSet_examples_OverflowSet_Basic_Example =
    type BaseComponent = __components_OverflowSet_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract OverflowSetBasicExample: OverflowSetBasicExampleStatic

    type [<AllowNullLiteral>] OverflowSetBasicExample =
        inherit BaseComponent<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onRenderItem: item: obj -> unit
        abstract _onRenderOverflowButton: overflowItems: obj -> unit

    type [<AllowNullLiteral>] OverflowSetBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OverflowSetBasicExample

module __components_OverflowSet_examples_OverflowSet_Custom_Example =
    type BaseComponent = __components_OverflowSet_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract OverflowSetCustomExample: OverflowSetCustomExampleStatic

    type [<AllowNullLiteral>] OverflowSetCustomExample =
        inherit BaseComponent<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onRenderItem: item: obj -> unit
        abstract _onRenderOverflowButton: overflowItems: obj -> unit

    type [<AllowNullLiteral>] OverflowSetCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OverflowSetCustomExample

module __components_OverflowSet_examples_OverflowSet_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract overflowLinks: obj
        abstract overflowButton: obj
        abstract isEnabled: obj
        abstract isOpened: obj

module __components_OverflowSet_examples_OverflowSet_Vertical_Example =
    type BaseComponent = __components_OverflowSet_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract OverflowSetVerticalExample: OverflowSetVerticalExampleStatic

    type [<AllowNullLiteral>] OverflowSetVerticalExample =
        inherit BaseComponent<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onRenderItem: item: obj -> unit
        abstract _onRenderOverflowButton: overflowItems: obj -> unit

    type [<AllowNullLiteral>] OverflowSetVerticalExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> OverflowSetVerticalExample

module __components_Overlay_examples_Overlay_Dark_Example =
    type IStyleFunction = Utilities.IStyleFunction
    type IOverlayExampleStyles = __components_Overlay_examples_Overlay_Example_styles.IOverlayExampleStyles

    type [<AllowNullLiteral>] IExports =
        abstract OverlayDarkExample: OverlayDarkExampleStatic

    type [<AllowNullLiteral>] IOverlayDarkExampleProps =
        abstract getStyles: IStyleFunction<obj, IOverlayExampleStyles> option with get, set

    type [<AllowNullLiteral>] OverlayDarkExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _setVisibilityFalse: obj with get, set
        abstract _toggleOverlay: obj with get, set

    type [<AllowNullLiteral>] OverlayDarkExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: OverlayDarkExampleStaticProps -> OverlayDarkExample

    type [<AllowNullLiteral>] OverlayDarkExampleStaticProps =
        interface end

module __components_Overlay_examples_Overlay_Example_styles =
    type IStyle = Styling.IStyle

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (unit -> IOverlayExampleStyles)

    type [<AllowNullLiteral>] IOverlayExampleStyles =
        abstract root: IStyle with get, set

module __components_Overlay_examples_Overlay_Light_Example =
    type IStyleFunction = Utilities.IStyleFunction
    type IOverlayExampleStyles = __components_Overlay_examples_Overlay_Example_styles.IOverlayExampleStyles

    type [<AllowNullLiteral>] IExports =
        abstract OverlayLightExample: OverlayLightExampleStatic

    type [<AllowNullLiteral>] IOverlayLightExampleProps =
        abstract getStyles: IStyleFunction<obj, IOverlayExampleStyles> option with get, set

    type [<AllowNullLiteral>] OverlayLightExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _setVisibilityFalse: obj with get, set
        abstract _toggleOverlay: obj with get, set

    type [<AllowNullLiteral>] OverlayLightExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: OverlayLightExampleStaticProps -> OverlayLightExample

    type [<AllowNullLiteral>] OverlayLightExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_Custom_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelCustomExample: PanelCustomExampleStatic

    type [<AllowNullLiteral>] PanelCustomExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showPanel: obj with get, set
        abstract _closePanel: obj with get, set

    type [<AllowNullLiteral>] PanelCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelCustomExampleStaticProps -> PanelCustomExample

    type [<AllowNullLiteral>] PanelCustomExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_ExtraLarge_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelExtraLargeExample: PanelExtraLargeExampleStatic

    type [<AllowNullLiteral>] PanelExtraLargeExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PanelExtraLargeExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelExtraLargeExampleStaticProps -> PanelExtraLargeExample

    type [<AllowNullLiteral>] PanelExtraLargeExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_Footer_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelFooterExample: PanelFooterExampleStatic

    type [<AllowNullLiteral>] PanelFooterExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _onClosePanel: obj with get, set
        abstract _onRenderFooterContent: obj with get, set
        abstract _onShowPanel: obj with get, set

    type [<AllowNullLiteral>] PanelFooterExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelFooterExampleStaticProps -> PanelFooterExample

    type [<AllowNullLiteral>] PanelFooterExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_HiddenOnDismiss_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelHiddenOnDismissExample: PanelHiddenOnDismissExampleStatic

    type [<AllowNullLiteral>] PanelHiddenOnDismissExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showPanel: obj with get, set
        abstract _hidePanel: obj with get, set

    type [<AllowNullLiteral>] PanelHiddenOnDismissExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelHiddenOnDismissExampleStaticProps -> PanelHiddenOnDismissExample

    type [<AllowNullLiteral>] PanelHiddenOnDismissExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_Large_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelLargeExample: PanelLargeExampleStatic

    type [<AllowNullLiteral>] PanelLargeExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PanelLargeExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelLargeExampleStaticProps -> PanelLargeExample

    type [<AllowNullLiteral>] PanelLargeExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_LargeFixed_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelLargeFixedExample: PanelLargeFixedExampleStatic

    type [<AllowNullLiteral>] PanelLargeFixedExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showPanel: obj with get, set
        abstract _closePanel: obj with get, set

    type [<AllowNullLiteral>] PanelLargeFixedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelLargeFixedExampleStaticProps -> PanelLargeFixedExample

    type [<AllowNullLiteral>] PanelLargeFixedExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_LightDismiss_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelLightDismissExample: PanelLightDismissExampleStatic

    type [<AllowNullLiteral>] PanelLightDismissExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showPanel: obj with get, set
        abstract _hidePanel: obj with get, set

    type [<AllowNullLiteral>] PanelLightDismissExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelLightDismissExampleStaticProps -> PanelLightDismissExample

    type [<AllowNullLiteral>] PanelLightDismissExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_LightDismissCustom_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelLightDismissCustomExample: PanelLightDismissCustomExampleStatic

    type [<AllowNullLiteral>] PanelLightDismissCustomExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _showPanel: obj with get, set
        abstract _hidePanel: obj with get, set
        abstract _showDialog: obj with get, set
        abstract _closeDialog: obj with get, set
        abstract _closeDialogAndHidePanel: obj with get, set

    type [<AllowNullLiteral>] PanelLightDismissCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelLightDismissCustomExampleStaticProps -> PanelLightDismissCustomExample

    type [<AllowNullLiteral>] PanelLightDismissCustomExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_Medium_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelMediumExample: PanelMediumExampleStatic

    type [<AllowNullLiteral>] PanelMediumExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _setShowPanel: obj with get, set

    type [<AllowNullLiteral>] PanelMediumExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelMediumExampleStaticProps -> PanelMediumExample

    type [<AllowNullLiteral>] PanelMediumExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_NonModal_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelNonModalExample: PanelNonModalExampleStatic

    type [<AllowNullLiteral>] PanelNonModalExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _setShowPanel: obj with get, set

    type [<AllowNullLiteral>] PanelNonModalExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelNonModalExampleStaticProps -> PanelNonModalExample

    type [<AllowNullLiteral>] PanelNonModalExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_SmallFluid_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelSmallFluidExample: PanelSmallFluidExampleStatic

    type [<AllowNullLiteral>] PanelSmallFluidExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PanelSmallFluidExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelSmallFluidExampleStaticProps -> PanelSmallFluidExample

    type [<AllowNullLiteral>] PanelSmallFluidExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_SmallLeft_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelSmallLeftExample: PanelSmallLeftExampleStatic

    type [<AllowNullLiteral>] PanelSmallLeftExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PanelSmallLeftExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelSmallLeftExampleStaticProps -> PanelSmallLeftExample

    type [<AllowNullLiteral>] PanelSmallLeftExampleStaticProps =
        interface end

module __components_Panel_examples_Panel_SmallRight_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PanelSmallRightExample: PanelSmallRightExampleStatic

    type [<AllowNullLiteral>] PanelSmallRightExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _onClosePanel: obj with get, set
        abstract _onRenderFooterContent: obj with get, set
        abstract _onShowPanel: obj with get, set

    type [<AllowNullLiteral>] PanelSmallRightExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PanelSmallRightExampleStaticProps -> PanelSmallRightExample

    type [<AllowNullLiteral>] PanelSmallRightExampleStaticProps =
        interface end

module __components_Persona_examples_Persona_Alternate_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PersonaAlternateExample: PersonaAlternateExampleStatic

    type [<AllowNullLiteral>] PersonaAlternateExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PersonaAlternateExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PersonaAlternateExampleStaticProps -> PersonaAlternateExample

    type [<AllowNullLiteral>] PersonaAlternateExampleStaticProps =
        interface end

module __components_Persona_examples_Persona_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PersonaBasicExample: PersonaBasicExampleStatic

    type [<AllowNullLiteral>] PersonaBasicExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _onChange: obj with get, set

    type [<AllowNullLiteral>] PersonaBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PersonaBasicExampleStaticProps -> PersonaBasicExample

    type [<AllowNullLiteral>] PersonaBasicExampleStaticProps =
        interface end

module __components_Persona_examples_Persona_CustomCoinRender_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PersonaCustomCoinRenderExample: PersonaCustomCoinRenderExampleStatic

    type [<AllowNullLiteral>] PersonaCustomCoinRenderExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onRenderCoin: obj with get, set

    type [<AllowNullLiteral>] PersonaCustomCoinRenderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PersonaCustomCoinRenderExample

module __components_Persona_examples_Persona_CustomRender_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PersonaCustomRenderExample: PersonaCustomRenderExampleStatic

    type [<AllowNullLiteral>] PersonaCustomRenderExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _onRenderSecondaryText: obj with get, set

    type [<AllowNullLiteral>] PersonaCustomRenderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PersonaCustomRenderExample

module __components_Persona_examples_Persona_Initials_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PersonaInitialsExample: PersonaInitialsExampleStatic

    type [<AllowNullLiteral>] PersonaInitialsExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PersonaInitialsExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PersonaInitialsExample

module __components_Persona_examples_Persona_UnknownPersona_Example =

    type [<AllowNullLiteral>] IExports =
        abstract UnknownPersonaExample: UnknownPersonaExampleStatic

    type [<AllowNullLiteral>] UnknownPersonaExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] UnknownPersonaExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> UnknownPersonaExample

module __components_Persona_PersonaCoin_PersonaCoin_base =
    type BaseComponent = Utilities.BaseComponent
    type IPersonaCoinProps = __components_Persona_Persona_types.IPersonaCoinProps

    type [<AllowNullLiteral>] IExports =
        abstract PersonaCoinBase: PersonaCoinBaseStatic

    type [<AllowNullLiteral>] IPersonaState =
        abstract isImageLoaded: bool option with get, set
        abstract isImageError: bool option with get, set

    /// PersonaCoin with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] PersonaCoinBase =
        inherit BaseComponent<IPersonaCoinProps, IPersonaState>
        abstract defaultProps: IPersonaCoinProps with get, set
        abstract render: unit -> JSX.Element option
        abstract _onRenderCoin: obj with get, set
        /// Deprecation helper for getting text.
        abstract _getText: unit -> unit
        abstract _onRenderInitials: obj with get, set
        abstract _onPhotoLoadingStateChange: obj with get, set

    /// PersonaCoin with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] PersonaCoinBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPersonaCoinProps -> PersonaCoinBase

module __components_Persona_PersonaCoin_PersonaCoin =
    type IPersonaCoinProps = __components_Persona_Persona_types.IPersonaCoinProps

    type [<AllowNullLiteral>] IExports =
        abstract PersonaCoin: (IPersonaCoinProps -> JSX.Element)

module __components_Persona_PersonaCoin_PersonaCoin_styles =
    type IPersonaCoinStyleProps = __components_Persona_Persona_types.IPersonaCoinStyleProps
    type IPersonaCoinStyles = __components_Persona_Persona_types.IPersonaCoinStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IPersonaCoinStyleProps -> IPersonaCoinStyles)

module __components_Persona_PersonaPresence_PersonaPresence_base =
    type BaseComponent = Utilities.BaseComponent
    type IPersonaPresenceProps = __components_Persona_Persona_types.IPersonaPresenceProps

    type [<AllowNullLiteral>] IExports =
        abstract PersonaPresenceBase: PersonaPresenceBaseStatic

    /// PersonaPresence with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] PersonaPresenceBase =
        inherit BaseComponent<IPersonaPresenceProps, obj>
        abstract render: unit -> JSX.Element option
        abstract _onRenderIcon: obj with get, set
        abstract _determineIcon: obj with get, set

    /// PersonaPresence with no default styles.
    /// [Use the `getStyles` API to add your own styles.](https://github.com/OfficeDev/office-ui-fabric-react/wiki/Styling)
    type [<AllowNullLiteral>] PersonaPresenceBaseStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPersonaPresenceProps -> PersonaPresenceBase

module __components_Persona_PersonaPresence_PersonaPresence =
    type IPersonaPresenceProps = __components_Persona_Persona_types.IPersonaPresenceProps

    type [<AllowNullLiteral>] IExports =
        abstract PersonaPresence: (IPersonaPresenceProps -> JSX.Element)

module __components_Persona_PersonaPresence_PersonaPresence_styles =
    type IPersonaPresenceStyleProps = __components_Persona_Persona_types.IPersonaPresenceStyleProps
    type IPersonaPresenceStyles = __components_Persona_Persona_types.IPersonaPresenceStyles

    type [<AllowNullLiteral>] IExports =
        abstract getStyles: (IPersonaPresenceStyleProps -> IPersonaPresenceStyles)

module __components_pickers_examples_ITagPickerDemoPageState =

    type [<AllowNullLiteral>] ITagPickerDemoPageState =
        abstract isPickerDisabled: bool option with get, set

module __components_pickers_examples_Picker_CustomResult_Example =
    type IDocumentCardActionsProps = __components_pickers_examples_office_ui_fabric_react_lib_DocumentCard.IDocumentCardActionsProps
    type IDocumentCardPreviewProps = __components_pickers_examples_office_ui_fabric_react_lib_DocumentCard.IDocumentCardPreviewProps
    type IDocumentCardProps = __components_pickers_examples_office_ui_fabric_react_lib_DocumentCard.IDocumentCardProps
    type IDocumentCardTitleProps = __components_pickers_examples_office_ui_fabric_react_lib_DocumentCard.IDocumentCardTitleProps
    type IDocumentCardActivityProps = __components_pickers_examples_office_ui_fabric_react_lib_DocumentCard.IDocumentCardActivityProps
    type IBasePickerProps = __components_pickers_examples_office_ui_fabric_react_lib_Pickers.IBasePickerProps
    type BasePickerListBelow = __components_pickers_examples_office_ui_fabric_react_lib_Pickers.BasePickerListBelow
    type IPickerItemProps = __components_pickers_examples_office_ui_fabric_react_lib_Pickers.IPickerItemProps
    type ISuggestionItemProps = __components_pickers_examples_office_ui_fabric_react_lib_Pickers.ISuggestionItemProps

    type [<AllowNullLiteral>] IExports =
        abstract SuggestedDocumentItem: (IFullDocumentCardProps -> JSX.Element)
        abstract SuggestedBigItem: (IFullDocumentCardProps -> ISuggestionItemProps<obj option> -> JSX.Element)
        abstract SelectedDocumentItem: (IPickerItemProps<IFullDocumentCardProps> -> JSX.Element)
        abstract DocumentPicker: DocumentPickerStatic
        abstract PickerCustomResultExample: PickerCustomResultExampleStatic

    type [<AllowNullLiteral>] IPeoplePickerExampleState =
        abstract contextualMenuVisible: bool option with get, set
        abstract contextualMenuTarget: HTMLElement option with get, set
        abstract isPickerDisabled: bool option with get, set

    type [<AllowNullLiteral>] IFullDocumentCardProps =
        abstract documentCardProps: IDocumentCardProps option with get, set
        abstract documentActionsProps: IDocumentCardActionsProps option with get, set
        abstract documentPreviewProps: IDocumentCardPreviewProps option with get, set
        abstract documentActivityProps: IDocumentCardActivityProps option with get, set
        abstract documentTitleProps: IDocumentCardTitleProps option with get, set

    type [<AllowNullLiteral>] IDocumentPickerProps =
        inherit IBasePickerProps<IFullDocumentCardProps>

    type [<AllowNullLiteral>] DocumentPicker =
        inherit BasePickerListBelow<IFullDocumentCardProps, IDocumentPickerProps>

    type [<AllowNullLiteral>] DocumentPickerStatic =
        [<Emit "new $0($1...)">] abstract Create: props: DocumentPickerStaticProps -> DocumentPicker

    type [<AllowNullLiteral>] DocumentPickerStaticProps =
        interface end

    type [<AllowNullLiteral>] PickerCustomResultExample =
        inherit React.Component<obj, IPeoplePickerExampleState>
        abstract render: unit -> JSX.Element
        abstract _getTextFromItem: props: obj -> unit
        abstract _onDisabledButtonClick: obj with get, set
        abstract _onFilterChanged: filterText: obj * items: obj -> unit
        abstract _listContainsDocument: document: obj * items: obj -> unit

    type [<AllowNullLiteral>] PickerCustomResultExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PickerCustomResultExampleStaticProps -> PickerCustomResultExample

    type [<AllowNullLiteral>] PickerCustomResultExampleStaticProps =
        interface end

module __components_pickers_examples_TagPicker_Basic_Example =
    type BaseComponent = Utilities.BaseComponent
    type ITagPickerDemoPageState = __components_pickers_examples_office_ui_fabric_react_lib_components_pickers_examples_ITagPickerDemoPageState.ITagPickerDemoPageState

    type [<AllowNullLiteral>] IExports =
        abstract TagPickerBasicExample: TagPickerBasicExampleStatic

    type [<AllowNullLiteral>] TagPickerBasicExample =
        inherit BaseComponent<obj, ITagPickerDemoPageState>
        abstract _picker: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getTextFromItem: item: obj -> unit
        abstract _onDisabledButtonClick: obj with get, set
        abstract _onFilterChanged: obj with get, set
        abstract _onFilterChangedNoFilter: obj with get, set
        abstract _onItemSelected: obj with get, set
        abstract _listContainsDocument: tag: obj * tagList: obj -> unit

    type [<AllowNullLiteral>] TagPickerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TagPickerBasicExampleStaticProps -> TagPickerBasicExample

    type [<AllowNullLiteral>] TagPickerBasicExampleStaticProps =
        interface end

module __components_pickers_PeoplePicker_PeoplePicker_checklist =
    type ChecklistStatus = __demo_ComponentStatus_ComponentStatus_types.ChecklistStatus

    type [<AllowNullLiteral>] IExports =
        abstract PeoplePickerStatus: obj

module __components_pickers_PeoplePicker_PeoplePicker =
    type BasePicker = __components_pickers_BasePicker.BasePicker
    type BasePickerListBelow = __components_pickers_BasePicker.BasePickerListBelow
    type IBasePickerProps = __components_pickers_BasePicker_types.IBasePickerProps
    type IBasePickerSuggestionsProps = __components_pickers_BasePicker_types.IBasePickerSuggestionsProps
    type ValidationState = __components_pickers_BasePicker_types.ValidationState
    type IPersonaProps = Persona.IPersonaProps
    type IPeoplePickerItemProps = __components_pickers_PeoplePicker_PeoplePickerItems_PeoplePickerItem_types.IPeoplePickerItemProps

    type [<AllowNullLiteral>] IExports =
        abstract BasePeoplePicker: BasePeoplePickerStatic
        abstract MemberListPeoplePicker: MemberListPeoplePickerStatic
        abstract NormalPeoplePicker: NormalPeoplePickerStatic
        abstract CompactPeoplePicker: CompactPeoplePickerStatic
        abstract ListPeoplePicker: ListPeoplePickerStatic
        abstract createGenericItem: name: string * currentValidationState: ValidationState * allowPhoneInitials: bool -> obj

    type [<AllowNullLiteral>] IPeoplePickerProps =
        inherit IBasePickerProps<IPersonaProps>

    type [<AllowNullLiteral>] BasePeoplePicker =
        inherit BasePicker<IPersonaProps, IPeoplePickerProps>

    type [<AllowNullLiteral>] BasePeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BasePeoplePicker

    type [<AllowNullLiteral>] MemberListPeoplePicker =
        inherit BasePickerListBelow<IPersonaProps, IPeoplePickerProps>

    type [<AllowNullLiteral>] MemberListPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MemberListPeoplePicker

    /// Standard People Picker.
    type [<AllowNullLiteral>] NormalPeoplePicker =
        inherit BasePeoplePicker
        abstract defaultProps: obj with get, set

    /// Standard People Picker.
    type [<AllowNullLiteral>] NormalPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NormalPeoplePicker

    /// Compact layout. It uses small personas when displaying search results.
    type [<AllowNullLiteral>] CompactPeoplePicker =
        inherit BasePeoplePicker
        abstract defaultProps: obj with get, set

    /// Compact layout. It uses small personas when displaying search results.
    type [<AllowNullLiteral>] CompactPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CompactPeoplePicker

    /// MemberList layout. The selected people show up below the search box.
    type [<AllowNullLiteral>] ListPeoplePicker =
        inherit MemberListPeoplePicker
        abstract defaultProps: obj with get, set

    /// MemberList layout. The selected people show up below the search box.
    type [<AllowNullLiteral>] ListPeoplePickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ListPeoplePicker

    type [<AllowNullLiteral>] IGenericItem =
        abstract primaryText: string with get, set
        abstract imageInitials: string with get, set
        abstract ValidationState: ValidationState with get, set

module __components_pickers_PeoplePicker_PeoplePicker_scss =

    type [<AllowNullLiteral>] IExports =
        abstract resultContent: obj
        abstract resultItem: obj
        abstract peoplePickerPersona: obj
        abstract peoplePicker: obj
        abstract peoplePickerPersonaContent: obj

module __components_pickers_PeoplePicker_PeoplePickerPage =
    type IComponentDemoPageProps = __components_pickers_PeoplePicker_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract PeoplePickerPage: PeoplePickerPageStatic

    type [<AllowNullLiteral>] PeoplePickerPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PeoplePickerPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PeoplePickerPage

module __components_pickers_Suggestions_Suggestions =
    type BaseComponent = Utilities.BaseComponent
    type IButton = Button.IButton
    type ISuggestionItemProps = __components_pickers_Suggestions_Suggestions_types.ISuggestionItemProps
    type ISuggestionsProps = __components_pickers_Suggestions_Suggestions_types.ISuggestionsProps

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionsItem: SuggestionsItemStatic
        abstract Suggestions: SuggestionsStatic

    type [<RequireQualifiedAccess>] SuggestionActionType =
        | None = 0
        | ForceResolve = 1
        | SearchMore = 2

    type [<AllowNullLiteral>] ISuggestionsState =
        abstract selectedActionType: SuggestionActionType with get, set

    type [<AllowNullLiteral>] SuggestionsItem<'T> =
        inherit BaseComponent<ISuggestionItemProps<'T>, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SuggestionsItemStatic =
        [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsProps<'T> -> SuggestionsItem<'T>

    type [<AllowNullLiteral>] Suggestions<'T> =
        inherit BaseComponent<ISuggestionsProps<'T>, ISuggestionsState>
        abstract _forceResolveButton: obj with get, set
        abstract _searchForMoreButton: obj with get, set
        abstract _selectedElement: obj with get, set
        abstract SuggestionsItemOfProperType: obj with get, set
        abstract activeSelectedElement: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        /// Returns true if the event was handled, false otherwise
        abstract tryHandleKeyDown: (float -> float -> bool) with get, set
        abstract hasSuggestedAction: unit -> bool
        abstract hasSuggestedActionSelected: unit -> bool
        abstract executeSelectedAction: unit -> unit
        abstract focusAboveSuggestions: unit -> unit
        abstract focusBelowSuggestions: unit -> unit
        abstract focusSearchForMoreButton: unit -> unit
        abstract scrollSelected: unit -> unit
        abstract _renderSuggestions: unit -> unit
        abstract _getMoreResults: obj with get, set
        abstract _forceResolve: obj with get, set
        abstract _shouldShowForceResolve: obj with get, set
        abstract _onClickTypedSuggestionsItem: obj with get, set
        abstract _refocusOnSuggestions: obj with get, set
        abstract _onRemoveTypedSuggestionsItem: obj with get, set

    type [<AllowNullLiteral>] SuggestionsStatic =
        [<Emit "new $0($1...)">] abstract Create: suggestionsProps: ISuggestionsProps<'T> -> Suggestions<'T>

module __components_pickers_Suggestions_Suggestions_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract suggestionsItem: obj
        abstract closeButton: obj
        abstract suggestionsItemIsSuggested: obj
        abstract itemButton: obj
        abstract actionButton: obj
        abstract buttonSelected: obj
        abstract suggestionsTitle: obj
        abstract suggestionsContainer: obj
        abstract suggestionsNone: obj
        abstract suggestionsSpinner: obj
        abstract suggestionsAvailable: obj

module __components_pickers_Suggestions_Suggestions_types =
    type ISuggestionModel = __components_pickers_Suggestions_SuggestionsController.ISuggestionModel
    type IRenderFunction = Utilities.IRenderFunction
    type KeyCodes = Utilities.KeyCodes
    type IPersonaProps = __components_Persona_Persona_types.IPersonaProps

    type [<AllowNullLiteral>] ISuggestionsProps<'T> =
        inherit React.Props<obj option>
        /// Gets the component ref.
        abstract componentRef: (unit -> unit) option with get, set
        /// How the suggestion should look in the suggestion list.
        abstract onRenderSuggestion: ('T -> 'T -> JSX.Element) option with get, set
        /// What should occur when a suggestion is clicked
        abstract onSuggestionClick: (React.MouseEvent<HTMLElement> -> obj option -> float -> unit) with get, set
        /// The list of Suggestions that will be displayed
        abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
        /// How the "no result found" should look in the suggestion list.
        abstract onRenderNoResultFound: IRenderFunction<unit> option with get, set
        /// The text that appears at the top of the suggestions list.
        abstract suggestionsHeaderText: string option with get, set
        /// The text that should appear at the top of the most recenty used box.
        abstract mostRecentlyUsedHeaderText: string option with get, set
        /// The text that appears indicating to the user that they can search for more results.
        abstract searchForMoreText: string option with get, set
        /// The callback that should be called when the user attempts to get more results
        abstract onGetMoreResults: (unit -> unit) option with get, set
        /// The text that appears indicating to the use to force resolve the input
        abstract forceResolveText: string option with get, set
        /// The callback that should be called to see if the force resolve command should be shown
        abstract showForceResolve: (unit -> bool) option with get, set
        /// The callback that should be called when the user attempts to use the input text as as item
        abstract createGenericItem: (unit -> unit) option with get, set
        /// The CSS classname of the suggestions list.
        abstract className: string option with get, set
        /// The text that should appear if there is a search error.
        abstract searchErrorText: string option with get, set
        /// The text that should appear if no results are found when searching.
        abstract noResultsFoundText: string option with get, set
        /// the classname of the suggestionitem.
        abstract suggestionsItemClassName: string option with get, set
        /// Used to indicate whether or not the user can request more suggestions.
        /// Dictates whether or not the searchForMore button is displayed.
        abstract moreSuggestionsAvailable: bool option with get, set
        /// Used to indicate whether or not the suggestions are loading.
        abstract isLoading: bool option with get, set
        /// Used to indicate whether or not the component is searching for more results.
        abstract isSearching: bool option with get, set
        /// The text to display while the results are loading.
        abstract loadingText: string option with get, set
        /// The text to display while searching for more results in a limited sugesstions list.
        abstract searchingText: string option with get, set
        /// Indicates if a short list of recent suggestions should be shown.
        abstract isMostRecentlyUsedVisible: bool option with get, set
        /// Function to fire when one of the optional remove buttons on a suggestion is clicked.
        abstract onSuggestionRemove: (React.MouseEvent<HTMLElement> -> IPersonaProps -> float -> unit) option with get, set
        /// Indicates if the text in resultsFooter or resultsFooterFull should be shown at the end of the suggestion list.
        abstract isResultsFooterVisible: bool option with get, set
        /// Maximum number of suggestions to show in the full suggestion list.
        abstract resultsMaximumNumber: float option with get, set
        /// A renderer that adds an element at the end of the suggestions list it has more items than resultsMaximumNumber.
        abstract resultsFooterFull: (ISuggestionsProps<'T> -> JSX.Element) option with get, set
        /// A renderer that adds an element at the end of the suggestions list it has fewer items than resultsMaximumNumber.
        abstract resultsFooter: (ISuggestionsProps<'T> -> JSX.Element) option with get, set
        /// Indicates whether to show a button with each suggestion to remove that suggestion.
        abstract showRemoveButtons: bool option with get, set
        /// Screen reader message to read when there are suggestions available.
        abstract suggestionsAvailableAlertText: string option with get, set
        /// A function that resets focus to the expected item in the suggestion list
        abstract refocusSuggestions: (KeyCodes -> unit) option with get, set
        /// An ARIA label for the container that is the parent of the suggestions.
        abstract suggestionsContainerAriaLabel: string option with get, set
        /// An ARIA label to use for the buttons to remove individual suggestions.
        abstract removeSuggestionAriaLabel: string option with get, set

    type [<AllowNullLiteral>] ISuggestionItemProps<'T> =
        abstract componentRef: (unit -> unit) option with get, set
        abstract suggestionModel: ISuggestionModel<'T> with get, set
        abstract RenderSuggestion: ('T -> ISuggestionItemProps<'T> -> JSX.Element) with get, set
        abstract onClick: (React.MouseEvent<HTMLButtonElement> -> unit) with get, set
        abstract onRemoveItem: (React.MouseEvent<HTMLButtonElement> -> unit) with get, set
        abstract className: string option with get, set
        abstract id: string option with get, set
        abstract showRemoveButton: bool option with get, set
        abstract isSelectedOverride: bool option with get, set
        /// The ARIA label for the button to remove the suggestion from the list.
        abstract removeButtonAriaLabel: string option with get, set

module __components_pickers_Suggestions_SuggestionsController =

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionsController: SuggestionsControllerStatic

    type [<AllowNullLiteral>] ISuggestionModel<'T> =
        abstract item: 'T with get, set
        abstract selected: bool with get, set
        abstract ariaLabel: string option with get, set

    type [<AllowNullLiteral>] SuggestionsController<'T> =
        abstract currentIndex: float with get, set
        abstract currentSuggestion: ISuggestionModel<'T> option with get, set
        abstract suggestions: ResizeArray<ISuggestionModel<'T>> with get, set
        abstract updateSuggestions: newSuggestions: ResizeArray<'T> * ?selectedIndex: float -> unit
        /// Increments the suggestion index and gets the next suggestion in the list.
        abstract nextSuggestion: unit -> bool
        /// Decrements the suggestion index and gets the previous suggestion in the list.
        abstract previousSuggestion: unit -> bool
        abstract getSuggestions: unit -> ResizeArray<ISuggestionModel<'T>>
        abstract getCurrentItem: unit -> ISuggestionModel<'T>
        abstract getSuggestionAtIndex: index: float -> ISuggestionModel<'T>
        abstract hasSelectedSuggestion: unit -> bool
        abstract removeSuggestion: index: float -> unit
        abstract createGenericSuggestion: itemToConvert: U2<ISuggestionModel<'T>, 'T> -> unit
        abstract convertSuggestionsToSuggestionItems: suggestions: Array<U2<ISuggestionModel<'T>, 'T>> -> ResizeArray<ISuggestionModel<'T>>
        abstract deselectAllSuggestions: unit -> unit
        abstract setSelectedSuggestion: index: float -> unit
        abstract _isSuggestionModel: obj with get, set
        abstract _ensureSuggestionModel: obj with get, set

    type [<AllowNullLiteral>] SuggestionsControllerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SuggestionsController<'T>

module __components_pickers_TagPicker_TagItem =
    type IPickerItemProps = __components_pickers_PickerItem_types.IPickerItemProps
    type ITag = __components_pickers_TagPicker_TagPicker.ITag

    type [<AllowNullLiteral>] IExports =
        abstract TagItem: (ITagItemProps -> JSX.Element)

    type [<AllowNullLiteral>] ITagItemProps =
        inherit IPickerItemProps<ITag>
        abstract enableTagFocusInDisabledPicker: bool option with get, set

module __components_pickers_TagPicker_TagItem_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract isSelected: obj
        abstract tagItemText: obj
        abstract tagItemClose: obj
        abstract tagItemButton: obj
        abstract tagItemTextOverflow: obj

module __components_pickers_TagPicker_TagPicker =
    type BasePicker = __components_pickers_BasePicker.BasePicker
    type IBasePickerProps = __components_pickers_BasePicker_types.IBasePickerProps
    type ITagItemProps = __components_pickers_TagPicker_TagItem.ITagItemProps

    type [<AllowNullLiteral>] IExports =
        abstract TagPicker: TagPickerStatic

    type [<AllowNullLiteral>] ITag =
        abstract key: string with get, set
        abstract name: string with get, set

    type [<AllowNullLiteral>] ITagPickerProps =
        inherit IBasePickerProps<ITag>

    type [<AllowNullLiteral>] TagPicker =
        inherit BasePicker<ITag, ITagPickerProps>
        abstract defaultProps: obj with get, set

    type [<AllowNullLiteral>] TagPickerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TagPicker

module __components_Pivot_examples_Pivot_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotBasicExample: PivotBasicExampleStatic

    type [<AllowNullLiteral>] PivotBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotBasicExample

module __components_Pivot_examples_Pivot_Fabric_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotFabricExample: PivotFabricExampleStatic

    type [<AllowNullLiteral>] PivotFabricExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotFabricExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotFabricExample

module __components_Pivot_examples_Pivot_IconCount_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotIconCountExample: PivotIconCountExampleStatic

    type [<AllowNullLiteral>] PivotIconCountExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _customRenderer: link: obj * defaultRenderer: obj -> unit

    type [<AllowNullLiteral>] PivotIconCountExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotIconCountExample

module __components_Pivot_examples_Pivot_Large_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotLargeExample: PivotLargeExampleStatic

    type [<AllowNullLiteral>] PivotLargeExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotLargeExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotLargeExample

module __components_Pivot_examples_Pivot_OnChange_Example =
    type PivotItem = __components_Pivot_examples_office_ui_fabric_react_lib_Pivot.PivotItem

    type [<AllowNullLiteral>] IExports =
        abstract PivotOnChangeExample: PivotOnChangeExampleStatic

    type [<AllowNullLiteral>] PivotOnChangeExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract onLinkClick: item: PivotItem -> unit

    type [<AllowNullLiteral>] PivotOnChangeExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotOnChangeExample

module __components_Pivot_examples_Pivot_Override_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotOverrideExample: PivotOverrideExampleStatic

    type [<AllowNullLiteral>] PivotOverrideExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _handleClick: unit -> unit

    type [<AllowNullLiteral>] PivotOverrideExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> PivotOverrideExample

module __components_Pivot_examples_Pivot_Remove_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotRemoveExample: PivotRemoveExampleStatic

    type [<AllowNullLiteral>] IPivotOnChangeExampleState =
        abstract shouldShowFirstPivotItem: bool with get, set

    type [<AllowNullLiteral>] PivotRemoveExample =
        inherit React.Component<obj option, IPivotOnChangeExampleState>
        abstract _shouldShowFirstPivotItem: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _handleClick: unit -> unit

    type [<AllowNullLiteral>] PivotRemoveExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> PivotRemoveExample

module __components_Pivot_examples_Pivot_Separate_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotSeparateExample: PivotSeparateExampleStatic

    type [<AllowNullLiteral>] PivotSeparateExample =
        inherit React.Component<obj option, obj option>
        abstract state: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _handleLinkClick: obj with get, set
        abstract _getTabId: obj with get, set

    type [<AllowNullLiteral>] PivotSeparateExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotSeparateExample

module __components_Pivot_examples_Pivot_Tabs_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotTabsExample: PivotTabsExampleStatic

    type [<AllowNullLiteral>] PivotTabsExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotTabsExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotTabsExample

module __components_Pivot_examples_Pivot_TabsLarge_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PivotTabsLargeExample: PivotTabsLargeExampleStatic

    type [<AllowNullLiteral>] PivotTabsLargeExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] PivotTabsLargeExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PivotTabsLargeExample

module __components_ProgressIndicator_examples_ProgressIndicator_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ProgressIndicatorBasicExample: ProgressIndicatorBasicExampleStatic

    type [<AllowNullLiteral>] IProgressIndicatorBasicExampleState =
        abstract percentComplete: float with get, set

    type [<AllowNullLiteral>] ProgressIndicatorBasicExample =
        inherit React.Component<obj, IProgressIndicatorBasicExampleState>
        abstract _interval: obj with get, set
        abstract _async: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _startProgressDemo: unit -> unit

    type [<AllowNullLiteral>] ProgressIndicatorBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ProgressIndicatorBasicExampleStaticProps -> ProgressIndicatorBasicExample

    type [<AllowNullLiteral>] ProgressIndicatorBasicExampleStaticProps =
        interface end

module __components_ProgressIndicator_examples_ProgressIndicator_Indeterminate_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ProgressIndicatorIndeterminateExample: ProgressIndicatorIndeterminateExampleStatic

    type [<AllowNullLiteral>] ProgressIndicatorIndeterminateExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] ProgressIndicatorIndeterminateExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ProgressIndicatorIndeterminateExampleStaticProps -> ProgressIndicatorIndeterminateExample

    type [<AllowNullLiteral>] ProgressIndicatorIndeterminateExampleStaticProps =
        interface end

module __components_Rating_examples_Rating_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract RatingBasicExample: RatingBasicExampleStatic

    type [<AllowNullLiteral>] RatingBasicExample =
        inherit React.Component<obj, obj>
        abstract _customTheme: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onLargeStarChanged: obj with get, set
        abstract _onSmallStarChanged: obj with get, set
        abstract _onTenStarChanged: obj with get, set
        abstract _onThemedStarChanged: obj with get, set
        abstract _getRatingComponentAriaLabel: rating: obj * maxRating: obj -> unit

    type [<AllowNullLiteral>] RatingBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: RatingBasicExampleStaticProps -> RatingBasicExample

    type [<AllowNullLiteral>] RatingBasicExampleStaticProps =
        interface end

module __components_Rating_examples_Rating_Basic_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract dummy: obj

module __components_Rating_examples_Rating_ButtonControlled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract RatingButtonControlledExample: RatingButtonControlledExampleStatic

    type [<AllowNullLiteral>] RatingButtonControlledExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] RatingButtonControlledExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: RatingButtonControlledExampleStaticProps -> RatingButtonControlledExample

    type [<AllowNullLiteral>] RatingButtonControlledExampleStaticProps =
        interface end

module __components_ResizeGroup_examples_ResizeGroup_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract root: obj
        abstract resizeIsShort: obj
        abstract buttonGroup: obj
        abstract settingsGroup: obj
        abstract itemCountDropdown: obj

module __components_ResizeGroup_examples_ResizeGroup_FlexBox_Example =
    type BaseComponent = __components_ResizeGroup_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract FlexBoxResizeGroupExample: FlexBoxResizeGroupExampleStatic

    type [<AllowNullLiteral>] FlexBoxResizeGroupExample =
        inherit BaseComponent<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] FlexBoxResizeGroupExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FlexBoxResizeGroupExample

module __components_ResizeGroup_examples_ResizeGroup_OverflowSet_Example =
    type BaseComponent = __components_ResizeGroup_examples_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IContextualMenuItem = __components_ResizeGroup_examples_office_ui_fabric_react_lib_ContextualMenu.IContextualMenuItem

    type [<AllowNullLiteral>] IExports =
        abstract ResizeGroupOverflowSetExample: ResizeGroupOverflowSetExampleStatic

    type [<AllowNullLiteral>] IOverflowData =
        abstract primary: ResizeArray<IContextualMenuItem> with get, set
        abstract overflow: ResizeArray<IContextualMenuItem> with get, set
        abstract cacheKey: string option with get, set

    type [<AllowNullLiteral>] IResizeGroupOverflowSetExampleState =
        abstract short: bool with get, set
        abstract numberOfItems: float with get, set
        abstract buttonsChecked: bool with get, set
        abstract cachingEnabled: bool with get, set
        abstract onGrowDataEnabled: bool with get, set

    type [<AllowNullLiteral>] ResizeGroupOverflowSetExample =
        inherit BaseComponent<obj, IResizeGroupOverflowSetExampleState>
        abstract render: unit -> JSX.Element
        abstract _onReduceData: obj with get, set
        abstract _onGrowData: obj with get, set
        abstract _onCachingEnabledChanged: obj with get, set
        abstract _onGrowDataEnabledChanged: obj with get, set
        abstract _onButtonsCheckedChanged: obj with get, set
        abstract _onNumberOfItemsChanged: obj with get, set

    type [<AllowNullLiteral>] ResizeGroupOverflowSetExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ResizeGroupOverflowSetExampleStaticProps -> ResizeGroupOverflowSetExample

    type [<AllowNullLiteral>] ResizeGroupOverflowSetExampleStaticProps =
        interface end

module __components_ScrollablePane_examples_ScrollablePane_Default_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ScrollablePaneDefaultExample: ScrollablePaneDefaultExampleStatic

    type [<AllowNullLiteral>] ScrollablePaneDefaultExample =
        inherit React.Component
        abstract render: unit -> JSX.Element
        abstract _createContentArea: index: obj -> unit

    type [<AllowNullLiteral>] ScrollablePaneDefaultExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ScrollablePaneDefaultExample

module __components_ScrollablePane_examples_ScrollablePane_DetailsList_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ScrollablePaneDetailsListExample: ScrollablePaneDetailsListExampleStatic

    type [<AllowNullLiteral>] ScrollablePaneDetailsListExample =
        inherit React.Component<obj, obj>
        abstract _selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getSelectionDetails: unit -> unit

    type [<AllowNullLiteral>] ScrollablePaneDetailsListExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ScrollablePaneDetailsListExampleStaticProps -> ScrollablePaneDetailsListExample

    type [<AllowNullLiteral>] ScrollablePaneDetailsListExampleStaticProps =
        interface end

module __components_SearchBox_examples_SearchBox_Disabled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxDisabledExample: SearchBoxDisabledExampleStatic

    type [<AllowNullLiteral>] SearchBoxDisabledExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SearchBoxDisabledExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SearchBoxDisabledExample

module __components_SearchBox_examples_SearchBox_FullSize_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxFullSizeExample: SearchBoxFullSizeExampleStatic

    type [<AllowNullLiteral>] SearchBoxFullSizeExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SearchBoxFullSizeExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SearchBoxFullSizeExample

module __components_SearchBox_examples_SearchBox_Small_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxSmallExample: SearchBoxSmallExampleStatic

    type [<AllowNullLiteral>] SearchBoxSmallExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SearchBoxSmallExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SearchBoxSmallExample

module __components_SearchBox_examples_SearchBox_Underlined_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SearchBoxUnderlinedExample: SearchBoxUnderlinedExampleStatic

    type [<AllowNullLiteral>] SearchBoxUnderlinedExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SearchBoxUnderlinedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SearchBoxUnderlinedExample

module __components_SelectedItemsList_examples_SelectedPeopleList_Basic_Example =
    type BaseComponent = __components_SelectedItemsList_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract PeopleSelectedItemsListExample: PeopleSelectedItemsListExampleStatic

    type [<AllowNullLiteral>] PeopleSelectedItemsListExample =
        inherit BaseComponent<obj, obj>
        abstract _selectionList: obj with get, set
        abstract index: obj with get, set
        abstract selection: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _renderExtendedPicker: unit -> unit
        abstract _onRenderItem: obj with get, set
        abstract _renderPersonaElement: props: obj * defaultRender: obj -> unit
        abstract _setComponentRef: obj with get, set
        abstract _onAddItemButtonClicked: obj with get, set
        abstract _onExpandItem: obj with get, set
        abstract _onSelectionChange: unit -> unit
        abstract _onCopyItems: items: obj -> unit
        abstract _getExpandedGroupItems: item: obj -> unit

    type [<AllowNullLiteral>] PeopleSelectedItemsListExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PeopleSelectedItemsListExample

module __components_SelectedItemsList_examples_SelectedPeopleList_Basic_Example_scss =

    type [<AllowNullLiteral>] IExports =
        abstract persona: obj

module __components_SelectedItemsList_SelectedPeopleList_SelectedPeopleList =
    type BaseSelectedItemsList = __components_SelectedItemsList_BaseSelectedItemsList.BaseSelectedItemsList
    type IBaseSelectedItemsListProps = __components_SelectedItemsList_BaseSelectedItemsList_types.IBaseSelectedItemsListProps
    type ISelectedItemProps = __components_SelectedItemsList_BaseSelectedItemsList_types.ISelectedItemProps
    type IPersonaProps = Persona.IPersonaProps
    type IRenderFunction = Utilities.IRenderFunction
    type IBaseFloatingPickerProps = FloatingPicker.IBaseFloatingPickerProps

    type [<AllowNullLiteral>] IExports =
        abstract BasePeopleSelectedItemsList: BasePeopleSelectedItemsListStatic
        abstract SelectedPeopleList: SelectedPeopleListStatic

    type [<AllowNullLiteral>] IExtendedPersonaProps =
        inherit IPersonaProps
        abstract isValid: bool with get, set
        abstract blockRecipientRemoval: bool option with get, set
        abstract shouldBlockSelection: bool option with get, set
        abstract canExpand: bool option with get, set
        abstract isEditing: bool option with get, set

    type [<AllowNullLiteral>] ISelectedPeopleItemProps =
        inherit ISelectedItemProps<IExtendedPersonaProps>
        abstract onExpandItem: (unit -> unit) option with get, set
        abstract renderPersonaCoin: IRenderFunction<IPersonaProps> option with get, set
        abstract renderPrimaryText: IRenderFunction<IPersonaProps> option with get, set

    type [<AllowNullLiteral>] ISelectedPeopleProps =
        inherit IBaseSelectedItemsListProps<IExtendedPersonaProps>
        abstract onExpandGroup: (IExtendedPersonaProps -> unit) option with get, set
        abstract removeMenuItemText: string option with get, set
        abstract copyMenuItemText: string option with get, set
        abstract editMenuItemText: string option with get, set
        abstract getEditingItemText: (IExtendedPersonaProps -> string) option with get, set
        abstract onRenderFloatingPicker: (IBaseFloatingPickerProps<IPersonaProps> -> JSX.Element) option with get, set
        abstract floatingPickerProps: IBaseFloatingPickerProps<IPersonaProps> option with get, set

    type [<AllowNullLiteral>] BasePeopleSelectedItemsList =
        inherit BaseSelectedItemsList<IExtendedPersonaProps, ISelectedPeopleProps>

    type [<AllowNullLiteral>] BasePeopleSelectedItemsListStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BasePeopleSelectedItemsList

    /// Standard People Picker.
    type [<AllowNullLiteral>] SelectedPeopleList =
        inherit BasePeopleSelectedItemsList
        abstract defaultProps: obj option with get, set
        abstract replaceItem: (IExtendedPersonaProps -> ResizeArray<IExtendedPersonaProps> -> unit) with get, set
        abstract renderItems: (unit -> ResizeArray<JSX.Element>) with get, set
        abstract _renderItem: item: obj * index: obj -> unit
        abstract _beginEditing: obj with get, set
        abstract _completeEditing: obj with get, set
        abstract _createMenuItems: item: obj -> unit

    /// Standard People Picker.
    type [<AllowNullLiteral>] SelectedPeopleListStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SelectedPeopleList

module __components_SelectedItemsList_SelectedPeopleList_SelectedPeopleListPage =
    type IComponentDemoPageProps = __components_SelectedItemsList_SelectedPeopleList_@uifabric_example_app_base.IComponentDemoPageProps

    type [<AllowNullLiteral>] IExports =
        abstract SelectedPeopleListPage: SelectedPeopleListPageStatic

    type [<AllowNullLiteral>] SelectedPeopleListPage =
        inherit React.Component<IComponentDemoPageProps, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SelectedPeopleListPageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SelectedPeopleListPage

module __components_Slider_examples_Slider_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SliderBasicExample: SliderBasicExampleStatic

    type [<AllowNullLiteral>] SliderBasicExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SliderBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: SliderBasicExampleStaticProps -> SliderBasicExample

    type [<AllowNullLiteral>] SliderBasicExampleStaticProps =
        interface end

module __components_SpinButton_examples_SpinButton_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonBasicExample: SpinButtonBasicExampleStatic

    type [<AllowNullLiteral>] SpinButtonBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonBasicExample

module __components_SpinButton_examples_SpinButton_BasicDisabled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonBasicDisabledExample: SpinButtonBasicDisabledExampleStatic

    type [<AllowNullLiteral>] SpinButtonBasicDisabledExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonBasicDisabledExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonBasicDisabledExample

module __components_SpinButton_examples_SpinButton_BasicWithEndPosition_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonBasicWithEndPositionExample: SpinButtonBasicWithEndPositionExampleStatic

    type [<AllowNullLiteral>] SpinButtonBasicWithEndPositionExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonBasicWithEndPositionExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonBasicWithEndPositionExample

module __components_SpinButton_examples_SpinButton_BasicWithIcon_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonBasicWithIconExample: SpinButtonBasicWithIconExampleStatic

    type [<AllowNullLiteral>] SpinButtonBasicWithIconExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonBasicWithIconExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonBasicWithIconExample

module __components_SpinButton_examples_SpinButton_BasicWithIconDisabled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonBasicWithIconDisabledExample: SpinButtonBasicWithIconDisabledExampleStatic

    type [<AllowNullLiteral>] SpinButtonBasicWithIconDisabledExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonBasicWithIconDisabledExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonBasicWithIconDisabledExample

module __components_SpinButton_examples_SpinButton_CustomStyled_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonCustomStyledExample: SpinButtonCustomStyledExampleStatic

    type [<AllowNullLiteral>] SpinButtonCustomStyledExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinButtonCustomStyledExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonCustomStyledExample

module __components_SpinButton_examples_SpinButton_Stateful_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinButtonStatefulExample: SpinButtonStatefulExampleStatic

    type [<AllowNullLiteral>] SpinButtonStatefulExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _hasSuffix: value: obj * suffix: obj -> unit
        abstract _removeSuffix: value: obj * suffix: obj -> unit

    type [<AllowNullLiteral>] SpinButtonStatefulExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinButtonStatefulExample

module __components_Spinner_examples_Spinner_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SpinnerBasicExample: SpinnerBasicExampleStatic

    type [<AllowNullLiteral>] SpinnerBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SpinnerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> SpinnerBasicExample

module __components_SwatchColorPicker_examples_SwatchColorPicker_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract SwatchColorPickerBasicExample: SwatchColorPickerBasicExampleStatic

    type [<AllowNullLiteral>] IBasicSwatchColorPickerExampleState =
        abstract color: string option with get, set
        abstract previewColor: string option with get, set
        abstract color2: string option with get, set
        abstract previewColor2: string option with get, set

    type [<AllowNullLiteral>] SwatchColorPickerBasicExample =
        inherit React.Component<obj option, IBasicSwatchColorPickerExampleState>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SwatchColorPickerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> SwatchColorPickerBasicExample

module __components_TeachingBubble_examples_TeachingBubble_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleBasicExample: TeachingBubbleBasicExampleStatic

    type [<AllowNullLiteral>] ITeachingBubbleBasicExampleState =
        abstract isTeachingBubbleVisible: bool option with get, set

    type [<AllowNullLiteral>] TeachingBubbleBasicExample =
        inherit React.Component<obj, ITeachingBubbleBasicExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: ev: obj -> unit

    type [<AllowNullLiteral>] TeachingBubbleBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TeachingBubbleBasicExampleStaticProps -> TeachingBubbleBasicExample

    type [<AllowNullLiteral>] TeachingBubbleBasicExampleStaticProps =
        interface end

module __components_TeachingBubble_examples_TeachingBubble_Condensed_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleCondensedExample: TeachingBubbleCondensedExampleStatic

    type [<AllowNullLiteral>] ITeachingBubbleCondensedExampleState =
        abstract isTeachingBubbleVisible: bool option with get, set

    type [<AllowNullLiteral>] TeachingBubbleCondensedExample =
        inherit React.Component<obj, ITeachingBubbleCondensedExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: ev: obj -> unit

    type [<AllowNullLiteral>] TeachingBubbleCondensedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TeachingBubbleCondensedExampleStaticProps -> TeachingBubbleCondensedExample

    type [<AllowNullLiteral>] TeachingBubbleCondensedExampleStaticProps =
        interface end

module __components_TeachingBubble_examples_TeachingBubble_Illustration_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleIllustrationExample: TeachingBubbleIllustrationExampleStatic

    type [<AllowNullLiteral>] ITeachingBubbleIllustrationExampleState =
        abstract isTeachingBubbleVisible: bool option with get, set

    type [<AllowNullLiteral>] TeachingBubbleIllustrationExample =
        inherit React.Component<obj, ITeachingBubbleIllustrationExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: ev: obj -> unit

    type [<AllowNullLiteral>] TeachingBubbleIllustrationExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TeachingBubbleIllustrationExampleStaticProps -> TeachingBubbleIllustrationExample

    type [<AllowNullLiteral>] TeachingBubbleIllustrationExampleStaticProps =
        interface end

module __components_TeachingBubble_examples_TeachingBubble_SmallHeadline_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleSmallHeadlineExample: TeachingBubbleSmallHeadlineExampleStatic

    type [<AllowNullLiteral>] ITeachingBubbleSmallHeadlineExampleState =
        abstract isTeachingBubbleVisible: bool option with get, set

    type [<AllowNullLiteral>] TeachingBubbleSmallHeadlineExample =
        inherit React.Component<obj, ITeachingBubbleSmallHeadlineExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: ev: obj -> unit

    type [<AllowNullLiteral>] TeachingBubbleSmallHeadlineExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TeachingBubbleSmallHeadlineExampleStaticProps -> TeachingBubbleSmallHeadlineExample

    type [<AllowNullLiteral>] TeachingBubbleSmallHeadlineExampleStaticProps =
        interface end

module __components_TeachingBubble_examples_TeachingBubble_WideIllustration_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TeachingBubbleWideIllustrationExample: TeachingBubbleWideIllustrationExampleStatic

    type [<AllowNullLiteral>] ITeachingBubbleWideIllustrationExampleState =
        abstract isTeachingBubbleVisible: bool option with get, set

    type [<AllowNullLiteral>] TeachingBubbleWideIllustrationExample =
        inherit React.Component<obj, ITeachingBubbleWideIllustrationExampleState>
        abstract _menuButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onDismiss: ev: obj -> unit

    type [<AllowNullLiteral>] TeachingBubbleWideIllustrationExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TeachingBubbleWideIllustrationExampleStaticProps -> TeachingBubbleWideIllustrationExample

    type [<AllowNullLiteral>] TeachingBubbleWideIllustrationExampleStaticProps =
        interface end

module __components_TextField_examples_NumberTextField =

    type [<AllowNullLiteral>] IExports =
        abstract NumberTextField: NumberTextFieldStatic

    type [<AllowNullLiteral>] INumberTextFieldProps =
        abstract label: string with get, set
        abstract initialValue: string with get, set

    type [<AllowNullLiteral>] INumberTextFieldState =
        abstract value: string with get, set

    type [<AllowNullLiteral>] NumberTextField =
        inherit React.Component<INumberTextFieldProps, INumberTextFieldState>
        abstract render: unit -> JSX.Element
        abstract _validateNumber: value: obj -> unit
        abstract _onChanged: value: obj -> unit
        abstract _restore: unit -> unit

    type [<AllowNullLiteral>] NumberTextFieldStatic =
        [<Emit "new $0($1...)">] abstract Create: props: INumberTextFieldProps -> NumberTextField

module __components_TextField_examples_TextField_AllErrorMessage_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldAllErrorMessageExample: TextFieldAllErrorMessageExampleStatic

    type [<AllowNullLiteral>] TextFieldAllErrorMessageExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldAllErrorMessageExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldAllErrorMessageExample

module __components_TextField_examples_TextField_AutoComplete_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldAutoCompleteExample: TextFieldAutoCompleteExampleStatic

    type [<AllowNullLiteral>] TextFieldAutoCompleteExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldAutoCompleteExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldAutoCompleteExample

module __components_TextField_examples_TextField_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldBasicExample: TextFieldBasicExampleStatic

    type [<AllowNullLiteral>] TextFieldBasicExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldBasicExample

module __components_TextField_examples_TextField_Borderless_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldBorderlessExample: TextFieldBorderlessExampleStatic

    type [<AllowNullLiteral>] TextFieldBorderlessExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldBorderlessExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldBorderlessExample

module __components_TextField_examples_TextField_CustomRender_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldCustomRenderExample: TextFieldCustomRenderExampleStatic

    type [<AllowNullLiteral>] TextFieldCustomRenderExample =
        inherit React.Component<obj, obj>
        abstract _iconButtonElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onRenderLabel: obj with get, set
        abstract _onClick: obj with get, set
        abstract _onDismiss: obj with get, set

    type [<AllowNullLiteral>] TextFieldCustomRenderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: TextFieldCustomRenderExampleStaticProps -> TextFieldCustomRenderExample

    type [<AllowNullLiteral>] TextFieldCustomRenderExampleStaticProps =
        interface end

module __components_TextField_examples_TextField_ErrorMessage_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldErrorMessageExample: TextFieldErrorMessageExampleStatic

    type [<AllowNullLiteral>] TextFieldErrorMessageExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _getErrorMessage: value: obj -> unit
        abstract _getErrorMessagePromise: value: obj -> unit

    type [<AllowNullLiteral>] TextFieldErrorMessageExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> TextFieldErrorMessageExample

module __components_TextField_examples_TextField_Icon_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldIconExample: TextFieldIconExampleStatic

    type [<AllowNullLiteral>] TextFieldIconExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element
        abstract _onChanged: obj with get, set

    type [<AllowNullLiteral>] TextFieldIconExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldIconExample

module __components_TextField_examples_TextField_Multiline_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldMultilineExample: TextFieldMultilineExampleStatic

    type [<AllowNullLiteral>] TextFieldMultilineExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldMultilineExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldMultilineExample

module __components_TextField_examples_TextField_OnRenderDescription_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldOnRenderDescriptionExample: TextFieldOnRenderDescriptionExampleStatic

    type [<AllowNullLiteral>] TextFieldOnRenderDescriptionExample =
        inherit React.Component<obj, obj>
        abstract render: unit -> JSX.Element
        abstract _onRenderDescription: obj with get, set
        abstract _onLinkClick: obj with get, set

    type [<AllowNullLiteral>] TextFieldOnRenderDescriptionExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldOnRenderDescriptionExample

module __components_TextField_examples_TextField_Placeholder_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldPlaceholderExample: TextFieldPlaceholderExampleStatic

    type [<AllowNullLiteral>] TextFieldPlaceholderExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldPlaceholderExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldPlaceholderExample

module __components_TextField_examples_TextField_Prefix_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldPrefixExample: TextFieldPrefixExampleStatic

    type [<AllowNullLiteral>] TextFieldPrefixExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldPrefixExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldPrefixExample

module __components_TextField_examples_TextField_PrefixAndSuffix_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldPrefixAndSuffixExample: TextFieldPrefixAndSuffixExampleStatic

    type [<AllowNullLiteral>] TextFieldPrefixAndSuffixExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldPrefixAndSuffixExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldPrefixAndSuffixExample

module __components_TextField_examples_TextField_Suffix_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldSuffixExample: TextFieldSuffixExampleStatic

    type [<AllowNullLiteral>] TextFieldSuffixExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldSuffixExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldSuffixExample

module __components_TextField_examples_TextField_Underlined_Example =

    type [<AllowNullLiteral>] IExports =
        abstract TextFieldUnderlinedExample: TextFieldUnderlinedExampleStatic

    type [<AllowNullLiteral>] TextFieldUnderlinedExample =
        inherit React.Component<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TextFieldUnderlinedExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TextFieldUnderlinedExample

module __components_TextField_MaskedTextField_MaskedTextField =
    type ITextField = __components_TextField_TextField_types.ITextField
    type ITextFieldProps = __components_TextField_TextField_types.ITextFieldProps
    type BaseComponent = Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract DEFAULT_MASK_CHAR: obj
        abstract MaskedTextField: MaskedTextFieldStatic

    /// props.mask:
    ///   The string containing the prompt and format characters.
    /// Example:
    ///   'Phone Number: (999) 9999'
    /// 
    /// _maskCharData
    ///   An array of data containing information regarding the format characters,
    ///   their indices inside the display text, and their corresponding values.
    /// Example:
    ///   [
    ///     { value: '1', displayIndex: 16, format: /[0-9]/ },
    ///     { value: '2', displayIndex: 17, format: /[0-9]/ },
    ///     { displayIndex: 18, format: /[0-9]/ },
    ///     { value: '4', displayIndex: 22, format: /[0-9]/ },
    ///     ...
    ///   ]
    type [<AllowNullLiteral>] IMaskedTextFieldState =
        /// The mask string formatted with the input value.
        /// This is what is displayed inside the TextField
        /// Example:
        ///   'Phone Number: 12_ - 4___'
        abstract displayValue: string with get, set
        /// The index into the rendered value of the first unfilled format character 
        abstract maskCursorPosition: float option with get, set

    type [<AllowNullLiteral>] MaskedTextField =
        inherit BaseComponent<ITextFieldProps, IMaskedTextFieldState>
        inherit ITextField
        abstract defaultProps: ITextFieldProps with get, set
        /// Tell BaseComponent to bypass resolution of componentRef.
        abstract _shouldUpdateComponentRef: bool with get, set
        abstract _textField: obj with get, set
        abstract _maskCharData: obj with get, set
        abstract _isFocused: obj with get, set
        abstract _moveCursorOnMouseUp: obj with get, set
        abstract _changeSelectionData: obj with get, set
        abstract componentWillReceiveProps: newProps: ITextFieldProps -> unit
        abstract componentDidUpdate: unit -> unit
        abstract render: unit -> JSX.Element
        abstract value: string option
        abstract setValue: newValue: string -> unit
        abstract focus: unit -> unit
        abstract select: unit -> unit
        abstract setSelectionStart: value: float -> unit
        abstract setSelectionEnd: value: float -> unit
        abstract setSelectionRange: start: float * ``end``: float -> unit
        abstract selectionStart: float option
        abstract selectionEnd: float option
        abstract _onFocus: ``event``: obj -> unit
        abstract _onBlur: ``event``: obj -> unit
        abstract _onMouseDown: ``event``: obj -> unit
        abstract _onMouseUp: ``event``: obj -> unit
        abstract _onBeforeChange: value: obj -> unit
        abstract _onInputChange: value: obj -> unit
        abstract _onKeyDown: ``event``: obj -> unit
        abstract _onPaste: ``event``: obj -> unit

    type [<AllowNullLiteral>] MaskedTextFieldStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ITextFieldProps -> MaskedTextField

module __components_Toggle_examples_Toggle_AriaLabel_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ToggleAriaLabelExample: (unit -> JSX.Element)

module __components_Toggle_examples_Toggle_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract ToggleBasicExample: (unit -> JSX.Element)

module __components_Tooltip_examples_Tooltip_Basic_Example =
    type BaseComponent = __components_Tooltip_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract TooltipBasicExample: TooltipBasicExampleStatic

    type [<AllowNullLiteral>] TooltipBasicExample =
        inherit BaseComponent<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TooltipBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TooltipBasicExample

module __components_Tooltip_examples_Tooltip_Custom_Example =
    type BaseComponent = __components_Tooltip_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract TooltipCustomExample: TooltipCustomExampleStatic

    type [<AllowNullLiteral>] TooltipCustomExample =
        inherit BaseComponent<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TooltipCustomExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TooltipCustomExample

module __components_Tooltip_examples_Tooltip_Interactive_Example =
    type BaseComponent = __components_Tooltip_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract TooltipInteractiveExample: TooltipInteractiveExampleStatic

    type [<AllowNullLiteral>] TooltipInteractiveExample =
        inherit BaseComponent<obj option, obj option>
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TooltipInteractiveExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TooltipInteractiveExample

module __components_Tooltip_examples_Tooltip_Overflow_Example =
    type BaseComponent = __components_Tooltip_examples_office_ui_fabric_react_lib_Utilities.BaseComponent

    type [<AllowNullLiteral>] IExports =
        abstract TooltipOverflowExample: TooltipOverflowExampleStatic

    type [<AllowNullLiteral>] ITooltipOverflowExampleState =
        abstract overflow: bool with get, set
        abstract isTooltipVisible: bool with get, set

    type [<AllowNullLiteral>] TooltipOverflowExample =
        inherit BaseComponent<obj, ITooltipOverflowExampleState>
        abstract tooltipId: obj
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] TooltipOverflowExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: obj option -> TooltipOverflowExample

module __utilities_selection_examples_Selection_Basic_Example =
    type ISelection = __utilities_selection_examples_office_ui_fabric_react_lib_Selection.ISelection
    type SelectionMode = __utilities_selection_examples_office_ui_fabric_react_lib_Selection.SelectionMode

    type [<AllowNullLiteral>] IExports =
        abstract SelectionItemExample: SelectionItemExampleStatic
        abstract SelectionBasicExample: SelectionBasicExampleStatic

    type [<AllowNullLiteral>] ISelectionBasicExampleState =
        abstract items: ResizeArray<obj option> with get, set
        abstract selection: ISelection with get, set
        abstract selectionMode: SelectionMode option with get, set
        abstract canSelect: string option with get, set

    type [<AllowNullLiteral>] ISelectionItemExampleProps =
        abstract item: obj option with get, set
        abstract itemIndex: float option with get, set
        abstract selection: ISelection option with get, set
        abstract selectionMode: SelectionMode option with get, set

    /// The SelectionItemExample controls and displays the selection state of a single item
    type [<AllowNullLiteral>] SelectionItemExample =
        inherit React.Component<ISelectionItemExampleProps, obj>
        abstract render: unit -> JSX.Element

    /// The SelectionItemExample controls and displays the selection state of a single item
    type [<AllowNullLiteral>] SelectionItemExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: SelectionItemExampleStaticProps -> SelectionItemExample

    type [<AllowNullLiteral>] SelectionItemExampleStaticProps =
        interface end

    /// The SelectionBasicExample controls the selection state of all items
    type [<AllowNullLiteral>] SelectionBasicExample =
        inherit React.Component<obj, ISelectionBasicExampleState>
        abstract _hasMounted: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _alertItem: obj with get, set
        abstract _onSelectionChanged: unit -> unit
        abstract _onToggleSelectAll: unit -> unit
        abstract _onSelectionModeChanged: ev: obj * menuItem: obj -> unit
        abstract _onCanSelectChanged: ev: obj * menuItem: obj -> unit
        abstract _canSelectItem: item: obj -> unit
        abstract _getCommandItems: unit -> unit

    /// The SelectionBasicExample controls the selection state of all items
    type [<AllowNullLiteral>] SelectionBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: SelectionBasicExampleStaticProps -> SelectionBasicExample

    type [<AllowNullLiteral>] SelectionBasicExampleStaticProps =
        interface end

module __components_Coachmark_PositioningContainer_examples_PositioningContainer_Basic_Example =

    type [<AllowNullLiteral>] IExports =
        abstract PositioningContainerBasicExample: PositioningContainerBasicExampleStatic

    type [<AllowNullLiteral>] IPositioningContainerBasicExampleState =
        abstract isPositioningContainerVisible: bool option with get, set

    type [<AllowNullLiteral>] PositioningContainerBasicExample =
        inherit React.Component<obj, IPositioningContainerBasicExampleState>
        abstract render: unit -> JSX.Element
        abstract _onShowMenuClicked: unit -> unit
        abstract _onDismiss: unit -> unit

    type [<AllowNullLiteral>] PositioningContainerBasicExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PositioningContainerBasicExampleStaticProps -> PositioningContainerBasicExample

    type [<AllowNullLiteral>] PositioningContainerBasicExampleStaticProps =
        interface end

module __components_FloatingPicker_PeoplePicker_examples_FloatingPeoplePicker_Basic_Example =
    type BaseComponent = __components_FloatingPicker_PeoplePicker_examples_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IPersonaProps = __components_FloatingPicker_PeoplePicker_examples_office_ui_fabric_react_lib_Persona.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract FloatingPeoplePickerTypesExample: FloatingPeoplePickerTypesExampleStatic

    type [<AllowNullLiteral>] IPeoplePickerExampleState =
        abstract currentPicker: U2<float, string> option with get, set
        abstract peopleList: ResizeArray<IPersonaProps> with get, set
        abstract mostRecentlyUsed: ResizeArray<IPersonaProps> with get, set
        abstract currentSelectedItems: ResizeArray<IPersonaProps> option with get, set
        abstract searchValue: string with get, set

    type [<AllowNullLiteral>] FloatingPeoplePickerTypesExample =
        inherit BaseComponent<obj, IPeoplePickerExampleState>
        abstract _picker: obj with get, set
        abstract _inputElement: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onFocus: obj with get, set
        abstract _setInputElementRef: obj with get, set
        abstract _renderFloatingPicker: unit -> unit
        abstract _setComponentRef: obj with get, set
        abstract _onSearchChange: obj with get, set
        abstract _onPickerChange: obj with get, set
        abstract _onRemoveSuggestion: obj with get, set
        abstract _onFilterChanged: obj with get, set
        abstract _getTextFromItem: persona: obj -> unit
        abstract _listContainsPersona: persona: obj * personas: obj -> unit
        abstract _filterPersonasByText: filterText: obj -> unit
        abstract _doesTextStartWith: text: obj * filterText: obj -> unit
        abstract _removeDuplicates: personas: obj * possibleDupes: obj -> unit
        abstract _validateInput: obj with get, set

    type [<AllowNullLiteral>] FloatingPeoplePickerTypesExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: FloatingPeoplePickerTypesExampleStaticProps -> FloatingPeoplePickerTypesExample

    type [<AllowNullLiteral>] FloatingPeoplePickerTypesExampleStaticProps =
        interface end

module __components_FloatingPicker_PeoplePicker_PeoplePickerItems_PickerItemsDefault_scss =

    type [<AllowNullLiteral>] IExports =
        abstract personaContainer: obj
        abstract removeButton: obj
        abstract personaContainerIsSelected: obj
        abstract validationError: obj
        abstract itemContent: obj
        abstract personaDetails: obj
        abstract itemContainer: obj

module __components_FloatingPicker_PeoplePicker_PeoplePickerItems_SelectedItemDefault =
    type IPeoplePickerItemProps = ExtendedPicker.IPeoplePickerItemProps

    type [<AllowNullLiteral>] IExports =
        abstract SelectedItemDefault: (IPeoplePickerItemProps -> JSX.Element)

module __components_FloatingPicker_PeoplePicker_PeoplePickerItems_SuggestionItemDefault =
    type IPersonaProps = Persona.IPersonaProps
    type IBasePickerSuggestionsProps = Pickers.IBasePickerSuggestionsProps

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionItemNormal: (IPersonaProps -> IBasePickerSuggestionsProps -> JSX.Element)

module __components_pickers_PeoplePicker_examples_PeoplePicker_Types_Example =
    type BaseComponent = __components_pickers_PeoplePicker_examples_office_ui_fabric_react_lib_Utilities.BaseComponent
    type IPersonaProps = __components_pickers_PeoplePicker_examples_office_ui_fabric_react_lib_Persona.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract PeoplePickerTypesExample: PeoplePickerTypesExampleStatic

    type [<AllowNullLiteral>] IPeoplePickerExampleState =
        abstract currentPicker: U2<float, string> option with get, set
        abstract delayResults: bool option with get, set
        abstract peopleList: ResizeArray<IPersonaProps> with get, set
        abstract mostRecentlyUsed: ResizeArray<IPersonaProps> with get, set
        abstract currentSelectedItems: ResizeArray<IPersonaProps> option with get, set

    type [<AllowNullLiteral>] PeoplePickerTypesExample =
        inherit BaseComponent<obj option, IPeoplePickerExampleState>
        abstract _picker: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _getTextFromItem: persona: obj -> unit
        abstract _renderListPicker: unit -> unit
        abstract _renderNormalPicker: unit -> unit
        abstract _renderCompactPicker: unit -> unit
        abstract _renderPreselectedItemsPicker: unit -> unit
        abstract _renderLimitedSearch: unit -> unit
        abstract _renderProcessSelectionPicker: unit -> unit
        abstract _renderControlledPicker: unit -> unit
        abstract _onItemsChange: obj with get, set
        abstract _onSetFocusButtonClicked: obj with get, set
        abstract _renderFooterText: obj with get, set
        abstract _onRemoveSuggestion: obj with get, set
        abstract _onItemSelected: obj with get, set
        abstract _onFilterChanged: obj with get, set
        abstract _returnMostRecentlyUsed: obj with get, set
        abstract _returnMostRecentlyUsedWithLimit: obj with get, set
        abstract _onFilterChangedWithLimit: obj with get, set
        abstract _filterPromise: personasToReturn: obj -> unit
        abstract _listContainsPersona: persona: obj * personas: obj -> unit
        abstract _filterPersonasByText: filterText: obj -> unit
        abstract _doesTextStartWith: text: obj * filterText: obj -> unit
        abstract _convertResultsToPromise: results: obj -> unit
        abstract _removeDuplicates: personas: obj * possibleDupes: obj -> unit
        abstract _toggleDelayResultsChange: obj with get, set
        abstract _dropDownSelected: obj with get, set
        abstract _validateInput: obj with get, set
        /// <summary>Takes in the picker input and modifies it in whichever way
        /// the caller wants, i.e. parsing entries copied from Outlook (sample
        /// input: "Aaron Reid <aaron>").</summary>
        /// <param name="input">The text entered into the picker.</param>
        abstract _onInputChange: input: obj -> unit

    type [<AllowNullLiteral>] PeoplePickerTypesExampleStatic =
        [<Emit "new $0($1...)">] abstract Create: props: PeoplePickerTypesExampleStaticProps -> PeoplePickerTypesExample

    type [<AllowNullLiteral>] PeoplePickerTypesExampleStaticProps =
        interface end

module __components_pickers_PeoplePicker_examples_PeoplePickerExampleData =
    type IPersonaProps = __components_pickers_PeoplePicker_examples_office_ui_fabric_react_lib_Persona.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract people: ResizeArray<obj>
        abstract mru: ResizeArray<IPersonaProps>

module __components_pickers_PeoplePicker_PeoplePickerItems_PeoplePickerItem_types =
    type IPersonaProps = Persona.IPersonaProps
    type IPickerItemProps = __components_pickers_PickerItem_types.IPickerItemProps
    type IContextualMenuItem = ContextualMenu.IContextualMenuItem
    type ValidationState = __components_pickers_BasePicker_types.ValidationState

    type [<AllowNullLiteral>] IPeoplePickerItemProps =
        inherit IPickerItemProps<obj>

    type [<AllowNullLiteral>] IPeoplePickerItemWithMenuProps =
        inherit IPickerItemProps<IPersonaWithMenu>
        abstract item: IPersonaWithMenu with get, set

    type [<AllowNullLiteral>] IPersonaWithMenu =
        inherit IPersonaProps
        abstract menuItems: ResizeArray<IContextualMenuItem> option with get, set

module __components_pickers_PeoplePicker_PeoplePickerItems_PickerItemsDefault_scss =

    type [<AllowNullLiteral>] IExports =
        abstract personaContainer: obj
        abstract removeButton: obj
        abstract personaContainerIsSelected: obj
        abstract validationError: obj
        abstract itemContent: obj
        abstract personaDetails: obj
        abstract itemContainer: obj

module __components_pickers_PeoplePicker_PeoplePickerItems_SelectedItemDefault =
    type IPeoplePickerItemProps = __components_pickers_PeoplePicker_PeoplePickerItems_PeoplePickerItem_types.IPeoplePickerItemProps

    type [<AllowNullLiteral>] IExports =
        abstract SelectedItemDefault: (IPeoplePickerItemProps -> JSX.Element)

module __components_pickers_PeoplePicker_PeoplePickerItems_SelectedItemWithMenu =
    type BaseComponent = Utilities.BaseComponent
    type IPeoplePickerItemWithMenuProps = __components_pickers_PeoplePicker_PeoplePickerItems_PeoplePickerItem_types.IPeoplePickerItemWithMenuProps

    type [<AllowNullLiteral>] IExports =
        abstract SelectedItemWithMenu: SelectedItemWithMenuStatic

    type [<AllowNullLiteral>] IPeoplePickerItemState =
        abstract contextualMenuVisible: bool with get, set

    type [<AllowNullLiteral>] SelectedItemWithMenu =
        inherit BaseComponent<IPeoplePickerItemWithMenuProps, IPeoplePickerItemState>
        abstract refs: obj with get, set
        abstract _ellipsisRef: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onContextualMenu: obj with get, set
        abstract _onCloseContextualMenu: obj with get, set

    type [<AllowNullLiteral>] SelectedItemWithMenuStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IPeoplePickerItemWithMenuProps -> SelectedItemWithMenu

module __components_pickers_PeoplePicker_PeoplePickerItems_SuggestionItemDefault =
    type IPersonaProps = Persona.IPersonaProps
    type IBasePickerSuggestionsProps = __components_pickers_PeoplePicker_PeoplePickerItems_office_ui_fabric_react_lib_Pickers.IBasePickerSuggestionsProps

    type [<AllowNullLiteral>] IExports =
        abstract SuggestionItemNormal: (IPersonaProps -> IBasePickerSuggestionsProps -> JSX.Element)
        abstract SuggestionItemSmall: (IPersonaProps -> IBasePickerSuggestionsProps -> JSX.Element)

module __components_SelectedItemsList_SelectedPeopleList_Items_EditingItem =
    type BaseComponent = Utilities.BaseComponent
    type IBaseFloatingPickerProps = FloatingPicker.IBaseFloatingPickerProps
    type ISelectedPeopleItemProps = __components_SelectedItemsList_SelectedPeopleList_SelectedPeopleList.ISelectedPeopleItemProps
    type IExtendedPersonaProps = __components_SelectedItemsList_SelectedPeopleList_SelectedPeopleList.IExtendedPersonaProps
    type IPeoplePickerItemState = __components_SelectedItemsList_SelectedPeopleList_Items_ExtendedSelectedItem.IPeoplePickerItemState
    type IPersonaProps = __components_SelectedItemsList_SelectedPeopleList_Items_office_ui_fabric_react_lib_Persona.IPersonaProps

    type [<AllowNullLiteral>] IExports =
        abstract EditingItem: EditingItemStatic

    type [<AllowNullLiteral>] IEditingSelectedPeopleItemProps =
        inherit ISelectedPeopleItemProps
        abstract onEditingComplete: (obj option -> obj option -> unit) with get, set
        abstract onRenderFloatingPicker: (IBaseFloatingPickerProps<IPersonaProps> -> JSX.Element) option with get, set
        abstract floatingPickerProps: IBaseFloatingPickerProps<IPersonaProps> option with get, set
        abstract getEditingItemText: (IExtendedPersonaProps -> string) option with get, set

    type [<AllowNullLiteral>] EditingItem =
        inherit BaseComponent<IEditingSelectedPeopleItemProps, IPeoplePickerItemState>
        abstract _editingInput: obj with get, set
        abstract _editingFloatingPicker: obj with get, set
        abstract _onRenderFloatingPicker: obj with get, set
        abstract _floatingPickerProps: obj with get, set
        abstract componentDidMount: unit -> unit
        abstract render: unit -> JSX.Element
        abstract _renderEditingSuggestions: obj with get, set
        abstract _resolveInputRef: obj with get, set
        abstract _onInputClick: obj with get, set
        abstract _onInputBlur: obj with get, set
        abstract _onInputChange: obj with get, set
        abstract _onInputKeyDown: ev: obj -> unit
        abstract _onSuggestionSelected: obj with get, set

    type [<AllowNullLiteral>] EditingItemStatic =
        [<Emit "new $0($1...)">] abstract Create: props: IEditingSelectedPeopleItemProps -> EditingItem

module __components_SelectedItemsList_SelectedPeopleList_Items_EditingItem_scss =

    type [<AllowNullLiteral>] IExports =
        abstract editingInput: obj
        abstract editingContainer: obj

module __components_SelectedItemsList_SelectedPeopleList_Items_ExtendedSelectedItem =
    type BaseComponent = Utilities.BaseComponent
    type ISelectedPeopleItemProps = __components_SelectedItemsList_SelectedPeopleList_SelectedPeopleList.ISelectedPeopleItemProps

    type [<AllowNullLiteral>] IExports =
        abstract ExtendedSelectedItem: ExtendedSelectedItemStatic

    type [<AllowNullLiteral>] IPeoplePickerItemState =
        abstract contextualMenuVisible: bool with get, set

    type [<AllowNullLiteral>] ExtendedSelectedItem =
        inherit BaseComponent<ISelectedPeopleItemProps, IPeoplePickerItemState>
        abstract persona: obj with get, set
        abstract render: unit -> JSX.Element
        abstract _onClickIconButton: action: obj -> unit

    type [<AllowNullLiteral>] ExtendedSelectedItemStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ISelectedPeopleItemProps -> ExtendedSelectedItem

module __components_SelectedItemsList_SelectedPeopleList_Items_ExtendedSelectedItem_scss =

    type [<AllowNullLiteral>] IExports =
        abstract personaContainer: obj
        abstract hover: obj
        abstract actionButton: obj
        abstract personaContainerIsSelected: obj
        abstract validationError: obj
        abstract itemContent: obj
        abstract removeButton: obj
        abstract expandButton: obj
        abstract personaWrapper: obj
        abstract personaDetails: obj
        abstract itemContainer: obj

module __components_SelectedItemsList_SelectedPeopleList_Items_SelectedItemWithContextMenu =
    type BaseComponent = Utilities.BaseComponent
    type RefObject = Utilities.RefObject
    type IBaseProps = Utilities.IBaseProps
    type IExtendedPersonaProps = __components_SelectedItemsList_SelectedPeopleList_SelectedPeopleList.IExtendedPersonaProps
    type IContextualMenuItem = ContextualMenu.IContextualMenuItem

    type [<AllowNullLiteral>] IExports =
        abstract SelectedItemWithContextMenu: SelectedItemWithContextMenuStatic

    type [<AllowNullLiteral>] IPeoplePickerItemState =
        abstract contextualMenuVisible: bool with get, set

    type [<AllowNullLiteral>] ISelectedItemWithContextMenuProps =
        inherit IBaseProps
        abstract renderedItem: JSX.Element with get, set
        abstract beginEditing: (IExtendedPersonaProps -> unit) option with get, set
        abstract menuItems: ResizeArray<IContextualMenuItem> with get, set
        abstract item: IExtendedPersonaProps with get, set

    type [<AllowNullLiteral>] SelectedItemWithContextMenu =
        inherit BaseComponent<ISelectedItemWithContextMenuProps, IPeoplePickerItemState>
        abstract itemElement: RefObject<HTMLDivElement> with get, set
        abstract render: unit -> JSX.Element
        abstract _onClick: obj with get, set
        abstract _onCloseContextualMenu: obj with get, set

    type [<AllowNullLiteral>] SelectedItemWithContextMenuStatic =
        [<Emit "new $0($1...)">] abstract Create: props: ISelectedItemWithContextMenuProps -> SelectedItemWithContextMenu
