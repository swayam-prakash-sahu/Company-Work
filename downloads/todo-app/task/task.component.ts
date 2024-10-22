import { Component, Input } from '@angular/core';
import { TaskService } from '../task.service';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent {
  @Input() task: any;

  constructor(private taskService: TaskService) { }

  deleteTask() {
    const index = this.taskService.tasks.indexOf(this.task);
    if (index !== -1) {
      this.taskService.deleteTask(index);
    }
  }
}
