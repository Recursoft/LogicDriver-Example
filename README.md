# Logic Driver Pro Example Project

**Requires Logic Driver 2.6.0 or higher**

Looking for Logic Driver LITE's Blueprint Only example project? Download from [here](https://logicdriver.com/liteexample).

## Installation

1. Uninstall Logic Driver Lite if installed.
1. [Install Logic Driver Pro](https://logicdriver.com/docs/pages/installation/) from the Marketplace.
1. Clone or download the project as a zip.
1. Open `LogicDriverExample.uproject`.

- Previous versions required to build a C++ project. This is no longer necessary. Use the 
        
## Installation & Walk-through Video

[![ExampleProject Walkthrough](https://img.youtube.com/vi/fOvyPBi_LM8/0.jpg)](https://www.youtube.com/watch?v=fOvyPBi_LM8)

## Documentation

- [Logic Driver User Guide and API Reference](https://logicdriver.com/docs/)

## Example Map

- Basic state machine usage, contexts, and ticking.
- Event based trigger with manual binding.
- Event based elevator lift with interp.
- Event based trigger with auto binding.
- Custom state class to print text and custom transition class with time delay.
- Exposing a text variable with a default value, editing the default value, and using a text variable.
- Dynamic instantiation of a state machine during run-time using custom classes and waiting for its completion.
- State stack example of multiple state classes combined into one state node.
- Editor construction scripts.

## AI Example Map

- AI Patrol Behavior.

## Replication Example Map

- Various replication settings. Play with ListenServer or Client.

## Dialogue Example Map

- Sample blueprint dialogue implementation using the [LogicDriver-Dialogue Blueprint Project](https://github.com/Recursoft/LogicDriver-DialogueExample).
- For a C++ example, see the [C++ Dialogue Plugin](https://github.com/Recursoft/LogicDriver-Dialogue). This was used on older versions of this example project and in the `4.27-cpp`.

## Quest Example Map

- Sample implementation of a simple fetch quest system. Each quest node is a state machine class containing  quest objective state nodes.
- Behavior rules are setup so `BP_QuestObjectiveNode` states can only be placed in state machines of type `BP_QuestStateMachine`.
- First room runs sequential quests.
- Second room runs parallel quests.

## Skill Example Map

- Demonstrates branching parallel states and leaving states active.

## RPG Example Map [WIP]

- Demonstration of dialogue system interacting with an advanced quest system. Basic inventory system present (not made with Logic Driver).
