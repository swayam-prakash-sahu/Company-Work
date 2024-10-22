import { Component, OnInit } from '@angular/core';
import { TaskService } from '../task.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css'],
  standalone: true,
  imports: [CommonModule,FormsModule]
})
export class TaskListComponent implements OnInit {
  tasks: { title: string; date: string }[] = [];
  editedTaskIndex: number | null = null;
  editedTaskTitle: string = '';

  constructor(private taskService: TaskService) {}

  ngOnInit(): void {
    this.taskService.getTasks().subscribe((tasks) => {
      this.tasks = tasks;
    });
  }

  deleteTask(index: number) {
    this.taskService.deleteTask(index);
  }

  editTask(index: number) {
    this.editedTaskIndex = index;
    this.editedTaskTitle = this.tasks[index].title;
  }

  cancelEdit() {
    this.editedTaskIndex = null;
    this.editedTaskTitle = '';
  }

  saveTaskChanges(index: number) {
    if (this.editedTaskIndex !== null) {
      const updatedTitle = this.editedTaskTitle.trim();
      if (updatedTitle) {
        this.taskService.updateTask(index, { title: updatedTitle, date: this.tasks[index].date });
        this.editedTaskIndex = null;
        this.editedTaskTitle = '';
      }
    }
  }
}
