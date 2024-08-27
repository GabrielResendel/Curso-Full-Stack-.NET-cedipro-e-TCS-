import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EventosComponent } from "./eventos/eventos.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, EventosComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'

})
export class AppComponent {
  title = 'angular';
}


