import { Component, EventEmitter, Output } from "@angular/core";
import { TodoItem } from "../models/todoItem";


@Component({
    selector: 'app-todo-items',
    templateUrl: './todo-items.component.html',
    styleUrl: './todo-items.component.css'
})
export class TodoItemsComponent {
    @Output() todoItemWasAdded = new EventEmitter<string>();

    showTodoItems: boolean = true;
    todoItems: TodoItem[] = [
        { id: 1, title: "Groceries", completed: false} ,
        { id: 2, title: "Work", completed: false},
        { id: 3, title: "Relax", completed: false},
    ]
    todoItemToAdd: string = "";

    toggleShowTodoItems() {
        console.log(`showTodoItems is right now ${this.showTodoItems}`);
        this.showTodoItems = !this.showTodoItems;
    }

    removeItem(item: TodoItem) {
        const index = this.todoItems.indexOf(item);
        if (index > -1) { 
            this.todoItems.splice(index, 1); 
        }
    }

    addTodoItem() {
        console.log(this.todoItemToAdd)
        if (this.todoItemToAdd.length === 0) {
            window.alert("Null can't be added!")
            return;
        }
        const alreadyExist = this.todoItems.some(todoItem => todoItem.title === this.todoItemToAdd);
        if (alreadyExist) { 
            window.alert("Already exists!")
            return;
        }
        const newTodoItem = {id: this.todoItems.length, title: this.todoItemToAdd, completed: false};
        this.todoItems.push(newTodoItem);
        this.todoItemWasAdded.emit(this.todoItemToAdd);
        this.todoItemToAdd = "";
    }

    ngOnInit() {
        
    }
}