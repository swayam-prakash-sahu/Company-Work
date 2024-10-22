import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { AppComponent } from "./app/app.component"; // Import AppComponent
import { HeaderComponent } from "./components/header.component";
import { TodoItemsComponent } from "./components/todo-items.component";

@NgModule({
    declarations: [
      HeaderComponent,
      TodoItemsComponent
    ],
    imports: [
      BrowserModule,
      FormsModule  
    ],
    providers: [],
    bootstrap: [AppComponent] // Bootstrap AppComponent
})
export class AppModule { }
