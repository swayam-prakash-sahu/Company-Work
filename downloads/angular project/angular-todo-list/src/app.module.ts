import { NgModule } from "@angular/core";
import { AppComponent } from "./app/app.component";
import { BrowserModule } from "@angular/platform-browser";
import { HeaderComponent } from "./components/header.component";
import { TodoItemsComponent } from "./components/todo-items.component";
import { FormsModule } from "@angular/forms";

@NgModule({
    declarations: [
      AppComponent,
      HeaderComponent,
      TodoItemsComponent
    ],
    imports: [
      BrowserModule,
      FormsModule  
    ],
    providers: [],
    bootstrap: [AppComponent]  // Bootstrap AppComponent
  })
  export class AppModule { }