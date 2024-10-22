import { Component, EventEmitter, Output } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css'],
  standalone: true,
  imports: [CommonModule,FormsModule]
})
export class AddTaskComponent {
  taskName: string = '';

  constructor(private taskService: TaskService) { }

  addTask() {
    if (this.taskName.trim() !== '') {
      this.taskService.addTask(this.taskName);
      this.taskName = '';
    }
  }

}
