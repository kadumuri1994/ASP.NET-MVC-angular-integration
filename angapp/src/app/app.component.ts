import { Component } from '@angular/core';


interface book{
  title:string;
  author:string;
  price: number;
}
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  books: book[];
  isdataloading: boolean=false;

  send()
  {
    this.isdataloading=true;
    //obtain data from server
    let xhr= new XMLHttpRequest()//AJAX //AJAJ

    xhr.open("get","/api/books",true);  //false means do this request by blocking the main thread
    //true means sending request to operating system and releasing the main thread

    xhr.setRequestHeader("Accept","application/json");

    //collect the data that comes from server that OS receives and puts it in the message queue
    // The main thread will wake up and call the function registered in onload
    xhr.onload = () => {
      this.isdataloading=false;
     // alert(xhr.responseText); //json formatted string

    this.books=JSON.parse(xhr.responseText);//json => JS objects in RAM
    };

    xhr.send();  
    //sending request to operating system and releasing the main thread so that it can perform navigation- This is called async
    //When OS receives the response from the server, it puts the response in the message queue of the main thread

   
  }
}
