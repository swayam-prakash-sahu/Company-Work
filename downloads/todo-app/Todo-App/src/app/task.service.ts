import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class TaskService {

  private tasks: BehaviorSubject<string[]> = new BehaviorSubject<string[]>([]);

  constructor() { }

  getTasks() {
    return this.tasks.asObservable();
  }

  addTask(task: string) {
    const currentTasks = this.tasks.getValue();
    const updatedTasks = [...currentTasks, task];
    this.tasks.next(updatedTasks);
  }

  deleteTask(index: number) {
    const currentTasks = this.tasks.getValue();
    currentTasks.splice(index, 1);
    this.tasks.next(currentTasks);
  }

  updateTask(index: number, updatedTask: string) {
    const currentTasks = this.tasks.getValue();
    currentTasks[index] = updatedTask;
    this.tasks.next(currentTasks);
  }
}
