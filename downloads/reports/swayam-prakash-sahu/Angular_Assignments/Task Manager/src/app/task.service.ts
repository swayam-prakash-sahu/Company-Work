import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  private tasks: BehaviorSubject<{ title: string; date: string }[]> = new BehaviorSubject<{ title: string; date: string }[]>([]);

  constructor() { }

  getTasks() {
    return this.tasks.asObservable();
  }

  addTask(task: { title: string; date: string }) {
    const currentTasks = this.tasks.getValue();
    const updatedTasks = [...currentTasks, task];
    this.tasks.next(updatedTasks);
  }

  deleteTask(index: number) {
    const currentTasks = this.tasks.getValue();
    currentTasks.splice(index, 1);
    this.tasks.next(currentTasks);
  }

  updateTask(index: number, updatedTask: { title: string; date: string }) {
    const currentTasks = this.tasks.getValue();
    currentTasks[index] = updatedTask;
    this.tasks.next(currentTasks);
  }
}
