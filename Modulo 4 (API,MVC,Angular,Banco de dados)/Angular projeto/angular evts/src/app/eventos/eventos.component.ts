import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.css'
})
export class EventosComponent implements OnInit {
constructor(private http: HttpClient) {}
 public eventos: any = [];
public mostrar: boolean = true;

ngOnInit(): void {
  this.getEventos();
}

 public getEventos() : void {
  this.eventos = this.http.get('http://localhost:5037/api/Evento').subscribe(
  //  (response:any) =>
  {
    next : (response) => (this.eventos = response),
    error : (error) => console.log(error),
   }
  );
}

public mostrarImagem(){
  this.mostrar = !this.mostrar
}
}


