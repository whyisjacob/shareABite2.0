var gulp = require('gulp');
var sass = require("gulp-sass");
var minifyCSS = require('gulp-csso');
var minify = require('gulp-minify');
var concat = require('gulp-concat');
var sourcemaps = require('gulp-sourcemaps');
var paths = {
  scripts: ['wwwroot/js/*.js'],
  scss:["wwwroot/scss/style.scss"],
  images: 'client/img/**/*'
};


gulp.task('scss', function(){
  return gulp.src(paths.scss)
    .pipe(sass())
    .pipe(minifyCSS())
    .pipe(gulp.dest('wwwroot/css'))
});

gulp.task('scripts', function() {
  // Minify and copy all JavaScript (except vendor scripts)
  // with sourcemaps all the way down
  return gulp.src(paths.scripts)
    .pipe(concat('app.js'))
    .pipe(minify())
    .pipe(gulp.dest('wwwroot/js/app'));
});

gulp.task('watch', function(){
  gulp.watch('wwwroot/scss/*.scss', ['scss']); 
  gulp.watch('wwwroot/js/*.js', ['scripts']); 
  // Other watchers
})
