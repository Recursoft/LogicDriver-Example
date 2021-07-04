# Logic Driver Pro Example Project

**Requires Logic Driver 2.4.6 or higher**

Looking for Logic Driver LITE's Blueprint Only example project? Download from [here](https://logicdriver.recursoft.net/liteexample).

## Installation

1. Open the [releases page](https://github.com/Recursoft/LogicDriver-Example/releases) *or clone the repository using `git clone --recurse-submodules`*
1. Download `LogicDriverExample.zip`

![Download Image](https://i.imgur.com/DeOYG4O.jpg)

3. Open `LogicDriverExample.uproject`
1. Unreal should prompt to build the project
    - Visual Studio is required for the project to build. It can be downloaded from https://visualstudio.microsoft.com/downloads/
        - Make sure [Game development with C++](https://devblogs.microsoft.com/cppblog/directx-game-development-with-c-in-visual-studio/) is checked during the install. Otherwise building the project may fail
        - Make sure .NET Framework 4.6 SDK is installed
        
## Installation & Walk-through Video

[![ExampleProject Walkthrough](https://img.youtube.com/vi/fOvyPBi_LM8/0.jpg)](https://www.youtube.com/watch?v=fOvyPBi_LM8)


## Documentation

- [Logic Driver User Guide and API Reference](https://logicdriver.recursoft.net/docs/)

## Example Map

- Basic state machine usage, contexts, and ticking
- Event based trigger with manual binding
- Event based elevator lift with interp.
- Event based trigger with auto binding
- Custom state class to print text and custom transition class with time delay
- Exposing a text variable with a default value, editing the default value, and using a text variable
- Dynamic instantiation of a state machine during run-time using custom classes and waiting for its completion
- State stack example of multiple state classes combined into one state node.

## AI Example Map

- AI Patrol Behavior

## Replication Example Map

- Various replication settings. Play with ListenServer or Client.

## Dialogue Example Map

- Sample Dialogue implementation using the [LogicDriver-Dialogue Plugin](https://github.com/Recursoft/LogicDriver-Dialogue)
    - This is a submodule of this project and is required for this example
    - The plugin can be used as an example on how to overload state and transition classes in C++
- A dialogue system can be implemented entirely using Blueprints. See [Dialogue System Concepts](https://logicdriver.recursoft.net/docs/pages/dialogue/) for more information

## Quest Example Map

- Sample implementation of a simple fetch quest system. Each quest node is a state machine class containing  quest objective state nodes.
- Behavior rules are setup so `BP_QuestObjectiveNode` states can only be placed in state machines of type `BP_QuestStateMachine`.
- First room runs sequential quests.
- Second room runs parallel quests.

## Skill Example Map

- Demonstrates branching parallel states and leaving states active.

## RPG Example Map [WIP]

- Demonstration of dialogue system interacting with an advanced quest system. Basic inventory system present (not made with Logic Driver).
