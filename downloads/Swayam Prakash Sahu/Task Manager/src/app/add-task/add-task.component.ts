import { Component } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css'],
  standalone: true,
  imports: [CommonModule, FormsModule]
})
export class AddTaskComponent {
  taskName: string = '';
  currentDate: string = '';

  constructor(private taskService: TaskService) {
    this.currentDate = new Date().toISOString(); // Initialize current date
  }

  addTask() {
    if (this.taskName.trim() !== '') {
      this.taskService.addTask({ title: this.taskName, date: this.currentDate });
      this.taskName = ''; // Clear input field after adding task
      this.currentDate = new Date().toISOString(); // Update current date
    }
  }
}

