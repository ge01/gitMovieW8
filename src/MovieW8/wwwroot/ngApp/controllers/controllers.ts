namespace MovieW8.Controllers {

    export class HomeController {
        public movies;

        constructor(private $http: ng.IHttpService) {
            this.$http.get<any>('/api/Movies')
                .then((response) => {
                    this.movies = response.data;
                });
        }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
