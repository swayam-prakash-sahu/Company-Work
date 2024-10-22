import { Component, Input, OnInit } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css'],
  standalone: true,
  imports: [CommonModule,FormsModule],
  
})
export class TaskComponent {
  @Input() task: string = '';
  @Input() index: number = 0;

  constructor(private taskService: TaskService) { }

  deleteTask(index:number) {
    this.taskService.deleteTask(index);
  }

}
