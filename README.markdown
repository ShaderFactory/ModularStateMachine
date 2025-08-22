Modular State Machine is an Unity package that offers functionality of a hierarchical finite state. It's ScriptableObject-based for easy implementation and modular reusability.

## Package name
com.shaderfactory.modularstatemachine

## How to install
- In Unity, go to **Windows > Package Management > Package Manager.**
- In the Package Manager window, click the '+' (Plus) icon in to top-left corner and choose the 'Install package from git URL...'
- Insert this package's git URL (https://github.com/ShaderFactory/ModularStateMachine.git) and press 'Install'.

## How to use
### Controller component.
- Select the GameObject you want to add the state machine to, click 'Add Component' and search for 'State Machine Controller'.
- Drag and drop your state machine (State Machine data SO) to the 'Root Machine'

### How to create the state machine.
- In Unity's project window, right-click in the folder where you want the state machine created. In the right-click menu go to **Create > Modular State Machine > State Machine**.
- Now you have a State Machine asset where you have a 'Initial State' field to drop a 'state (StateComposite)' to.

### How to create a state.
- In Unity's project window, right-click in the folder where you want the state machine created. In the right-click menu go to **Create > Modular State Machine > Composite State**.

## Components
=======
## How to install
- In Unity, go to **Windows > Package Management > Package Manager.**
- In the Package Manager window, click the '+' (Plus) icon in to top-left corner and choose the 'Install package from git URL...'
- Insert this package's git URL (https://github.com/ShaderFactory/ModularStateMachine.git) and press 'Install'.

## How to use
### Controller component.
- Select the GameObject you want to add the state machine to, click 'Add Component' and search for 'State Machine Controller'.
- Drag and drop your state machine (State Machine data SO) to the 'Root Machine'
### How to create the state machine.
- In Unity's project window, right-click in the folder where you want the state machine created. In the right-click menu go to **Create > Modular State Machine > State Machine**.
- Now you have a State Machine asset where you have a 'Initial State' field to drop a 'state (StateComposite)' to.
### How to create a state.
- In Unity's project window, right-click in the folder where you want the state machine created. In the right-click menu go to **Create > Modular State Machine > Composite State**.

## Classes (Scripts)
| Name                      | Type               | Description                               |
| ------------------------- | ------------------ | ----------------------------------------- |
| StateMachineController    | Component          | Attach a State Machine to a GameObject    |
| Transition                | Core Functionality | Scriptable Object that describes a state. |
| ModularStateMachineEvents | Core Functionality | Manages state machine events.             |
| StateSO                   | Scriptable Object  | Base class for states                     |
| DecisionSO                | Scriptable Object  | Checks conditions for transitions.        |
| StateMachineDataSO        | Scriptable Object  | Stores state machine configuration.       |
| StateSO                   | Scriptable Object  | Base state with lifecycle behaviors.      |

*Work in progress*
