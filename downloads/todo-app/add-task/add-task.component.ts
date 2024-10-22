import { Component } from '@angular/core';
import { TaskService } from '../task.service';
import { NgModule } from '@angular/core';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent {
  newTask: string = '';

  constructor(private taskService: TaskService) { }

  addTask() {
    if (this.newTask.trim()) {
      this.taskService.addTask({ title: this.newTask });
      this.newTask = ''; // Clear input field after adding task
    }
  }
}
