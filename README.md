# Parallel Program - Using For / ForEach

## Namespace and Using Statements:
#### The using directives at the beginning of the program import necessary namespaces, such as System and System.Collections.Generic, to access classes and functions.

## List Initialization:
#### The List<string> frutas = new(); statement initializes a list named frutas to store strings (fruit names).

## Adding Items to the List:
#### Fruit names are added to the frutas list using the Add method.

## User Interaction:
#### The program waits for the user to press Enter before starting the demonstration.

## Sequential Processing with foreach:
#### A traditional foreach loop is used to sequentially iterate through the frutas list. Each fruit name is displayed along with the ID of the current thread. This demonstrates the sequential nature of processing.

## Parallel Processing with Parallel.ForEach:
#### The Parallel.ForEach construct is used to process the frutas list in parallel. A lambda expression inside Parallel.ForEach is used to display each fruit name along with the ID of the thread that is processing it. This demonstrates concurrent processing and the automatic distribution of work across multiple threads.

## Concurrency and Thread Management:
#### The program utilizes multiple threads for parallel processing. The Thread.CurrentThread.ManagedThreadId property is used to obtain the ID of the current thread, illustrating the concept of thread management.

## User Interaction and Exiting:
#### After displaying the fruits using both sequential and parallel processing, the program waits for the user to press Enter again before exiting.

#### Overall, this example showcases the difference between sequential and parallel processing using the Parallel.ForEach construct. It highlights the benefits of parallelism for optimizing the execution of tasks that can be performed independently, such as iterating through a list of items.
