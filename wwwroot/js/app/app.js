// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
  function hello(){
	  console.log('hello') 
  }

/**
 * Timeago is a jQuery plugin that makes it easy to support automatically
 * updating fuzzy timestamps (e.g. "4 minutes ago" or "about 1 day ago").
 *
 * @name timeago
 * @version 1.6.1
 * @requires jQuery v1.2.3+
 * @author Ryan McGeary
 * @license MIT License - http://www.opensource.org/licenses/mit-license.php
 *
 * For usage and examples, visit:
 * http://timeago.yarp.com/
 *
 * Copyright (c) 2008-2017, Ryan McGeary (ryan -[at]- mcgeary [*dot*] org)
 */

(function (factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['jquery'], factory);
  } else if (typeof module === 'object' && typeof module.exports === 'object') {
    factory(require('jquery'));
  } else {
    // Browser globals
    factory(jQuery);
  }
}(function ($) {
  $.timeago = function(timestamp) {
    if (timestamp instanceof Date) {
      return inWords(timestamp);
    } else if (typeof timestamp === "string") {
      return inWords($.timeago.parse(timestamp));
    } else if (typeof timestamp === "number") {
      return inWords(new Date(timestamp));
    } else {
      return inWords($.timeago.datetime(timestamp));
    }
  };
  var $t = $.timeago;

  $.extend($.timeago, {
    settings: {
      refreshMillis: 60000,
      allowPast: true,
      allowFuture: false,
      localeTitle: false,
      cutoff: 0,
      autoDispose: true,
      strings: {
        prefixAgo: null,
        prefixFromNow: null,
        suffixAgo: "ago",
        suffixFromNow: "from now",
        inPast: 'any moment now',
        seconds: "less than a minute",
        minute: "about a minute",
        minutes: "%d minutes",
        hour: "about an hour",
        hours: "about %d hours",
        day: "a day",
        days: "%d days",
        month: "about a month",
        months: "%d months",
        year: "about a year",
        years: "%d years",
        wordSeparator: " ",
        numbers: []
      }
    },

    inWords: function(distanceMillis) {
      if (!this.settings.allowPast && ! this.settings.allowFuture) {
          throw 'timeago allowPast and allowFuture settings can not both be set to false.';
      }

      var $l = this.settings.strings;
      var prefix = $l.prefixAgo;
      var suffix = $l.suffixAgo;
      if (this.settings.allowFuture) {
        if (distanceMillis < 0) {
          prefix = $l.prefixFromNow;
          suffix = $l.suffixFromNow;
        }
      }

      if (!this.settings.allowPast && distanceMillis >= 0) {
        return this.settings.strings.inPast;
      }

      var seconds = Math.abs(distanceMillis) / 1000;
      var minutes = seconds / 60;
      var hours = minutes / 60;
      var days = hours / 24;
      var years = days / 365;

      function substitute(stringOrFunction, number) {
        var string = $.isFunction(stringOrFunction) ? stringOrFunction(number, distanceMillis) : stringOrFunction;
        var value = ($l.numbers && $l.numbers[number]) || number;
        return string.replace(/%d/i, value);
      }

      var words = seconds < 45 && substitute($l.seconds, Math.round(seconds)) ||
        seconds < 90 && substitute($l.minute, 1) ||
        minutes < 45 && substitute($l.minutes, Math.round(minutes)) ||
        minutes < 90 && substitute($l.hour, 1) ||
        hours < 24 && substitute($l.hours, Math.round(hours)) ||
        hours < 42 && substitute($l.day, 1) ||
        days < 30 && substitute($l.days, Math.round(days)) ||
        days < 45 && substitute($l.month, 1) ||
        days < 365 && substitute($l.months, Math.round(days / 30)) ||
        years < 1.5 && substitute($l.year, 1) ||
        substitute($l.years, Math.round(years));

      var separator = $l.wordSeparator || "";
      if ($l.wordSeparator === undefined) { separator = " "; }
      return $.trim([prefix, words, suffix].join(separator));
    },

    parse: function(iso8601) {
      var s = $.trim(iso8601);
      s = s.replace(/\.\d+/,""); // remove milliseconds
      s = s.replace(/-/,"/").replace(/-/,"/");
      s = s.replace(/T/," ").replace(/Z/," UTC");
      s = s.replace(/([\+\-]\d\d)\:?(\d\d)/," $1$2"); // -04:00 -> -0400
      s = s.replace(/([\+\-]\d\d)$/," $100"); // +09 -> +0900
      return new Date(s);
    },
    datetime: function(elem) {
      var iso8601 = $t.isTime(elem) ? $(elem).attr("datetime") : $(elem).attr("title");
      return $t.parse(iso8601);
    },
    isTime: function(elem) {
      // jQuery's `is()` doesn't play well with HTML5 in IE
      return $(elem).get(0).tagName.toLowerCase() === "time"; // $(elem).is("time");
    }
  });

  // functions that can be called via $(el).timeago('action')
  // init is default when no action is given
  // functions are called with context of a single element
  var functions = {
    init: function() {
      functions.dispose.call(this);
      var refresh_el = $.proxy(refresh, this);
      refresh_el();
      var $s = $t.settings;
      if ($s.refreshMillis > 0) {
        this._timeagoInterval = setInterval(refresh_el, $s.refreshMillis);
      }
    },
    update: function(timestamp) {
      var date = (timestamp instanceof Date) ? timestamp : $t.parse(timestamp);
      $(this).data('timeago', { datetime: date });
      if ($t.settings.localeTitle) {
        $(this).attr("title", date.toLocaleString());
      }
      refresh.apply(this);
    },
    updateFromDOM: function() {
      $(this).data('timeago', { datetime: $t.parse( $t.isTime(this) ? $(this).attr("datetime") : $(this).attr("title") ) });
      refresh.apply(this);
    },
    dispose: function () {
      if (this._timeagoInterval) {
        window.clearInterval(this._timeagoInterval);
        this._timeagoInterval = null;
      }
    }
  };

  $.fn.timeago = function(action, options) {
    var fn = action ? functions[action] : functions.init;
    if (!fn) {
      throw new Error("Unknown function name '"+ action +"' for timeago");
    }
    // each over objects here and call the requested function
    this.each(function() {
      fn.call(this, options);
    });
    return this;
  };

  function refresh() {
    var $s = $t.settings;

    //check if it's still visible
    if ($s.autoDispose && !$.contains(document.documentElement,this)) {
      //stop if it has been removed
      $(this).timeago("dispose");
      return this;
    }

    var data = prepareData(this);

    if (!isNaN(data.datetime)) {
      if ( $s.cutoff === 0 || Math.abs(distance(data.datetime)) < $s.cutoff) {
        $(this).text(inWords(data.datetime));
      } else {
        if ($(this).attr('title').length > 0) {
            $(this).text($(this).attr('title'));
        }
      }
    }
    return this;
  }

  function prepareData(element) {
    element = $(element);
    if (!element.data("timeago")) {
      element.data("timeago", { datetime: $t.datetime(element) });
      var text = $.trim(element.text());
      if ($t.settings.localeTitle) {
        element.attr("title", element.data('timeago').datetime.toLocaleString());
      } else if (text.length > 0 && !($t.isTime(element) && element.attr("title"))) {
        element.attr("title", text);
      }
    }
    return element.data("timeago");
  }

  function inWords(date) {
    return $t.inWords(distance(date));
  }

  function distance(date) {
    return (new Date().getTime() - date.getTime());
  }

  // fix for IE6 suckage
  document.createElement("abbr");
  document.createElement("time");
}));
/*
 * Title: Typewriter JS
 * Description: A native javascript plugin that can be used to create an elegent automatic typewriter animation effect on websites.
 * Author: Tameem Safi
 * Website: https://safi.me.uk
 * Version: 1.0.0
 */

(function() {
    
        "use strict";
    
        // http://paulirish.com/2011/requestanimationframe-for-smart-animating/
        // http://my.opera.com/emoller/blog/2011/12/20/requestanimationframe-for-smart-er-animating
        // requestAnimationFrame polyfill by Erik Möller. fixes from Paul Irish and Tino Zijdel
        // MIT license
        (function() {
            var lastTime = 0;
            var vendors = ['ms', 'moz', 'webkit', 'o'];
            for(var x = 0; x < vendors.length && !window.requestAnimationFrame; ++x) {
                window.requestAnimationFrame = window[vendors[x]+'RequestAnimationFrame'];
                window.cancelAnimationFrame = window[vendors[x]+'CancelAnimationFrame'] 
                                           || window[vendors[x]+'CancelRequestAnimationFrame'];
            }
         
            if (!window.requestAnimationFrame)
                window.requestAnimationFrame = function(callback, element) {
                    var currTime = new Date().getTime();
                    var timeToCall = Math.max(0, 16 - (currTime - lastTime));
                    var id = window.setTimeout(function() { callback(currTime + timeToCall); }, 
                      timeToCall);
                    lastTime = currTime + timeToCall;
                    return id;
                };
         
            if (!window.cancelAnimationFrame)
                window.cancelAnimationFrame = function(id) {
                    clearTimeout(id);
                };
        }());
    
        window.Typewriter = function Typewriter(element, options) {
            this._settings = {
                cursorAnimationPaused: false,
                opacityIncreasing: false,
                currentOpacity: 1,
                delayedQue: [],
                delayItemsCount: 0,
                eventQue: [],
                calledEvents: [],
                eventRunning: false,
                timeout: false,
                delayExecution: false,
                fps: (60/1000),
                typingFrameCount: 0,
                stringToTypeHTMLArray: [],
                currentTypedCharacters: [],
                typing: false,
                usedIDs: [],
                charAmountToDelete: false,
                userOptions: {},
                eventLoopRerun: 0
            };
    
            if(!element) {
                return console.error('Please choose an DOM element so that type writer can display itself.');
            }
    
            // if(!options.strings && !(options.strings instanceof Array || typeof options.strings === 'string')) {
            // 	return console.error('Please enter an array of strings for the typewriter animation to work.');
            // }
    
            if(typeof options !== 'object') {
                return console.error('Typewriter only accepts the options as an object.');
            }
    
            this._settings.userOptions = options;
    
            this.default_options = {
                strings: false,
                cursorClassName: 'typewriter-cursor',
                cursor: '|',
                animateCursor: true,
                blinkSpeed: 50,
                typingSpeed: 'natural',
                deleteSpeed: 'natural',
                charSpanClassName: 'typewriter-char',
                wrapperClassName: 'typewriter-wrapper',
                loop: false,
                autoStart: false,
                devMode: false
            };
    
            this.options = this._setupOptions(options);
    
            this.el = element;
    
            this._setupTypwriterWrapper();
    
            this._startCursorAnimation();
    
            if(this.options.autoStart === true && this.options.strings) {
                this.typeOutAllStrings();
            }
    
        };
    
        var TypewriterPrototype = window.Typewriter.prototype;
    
        TypewriterPrototype.stop = function() {
            this._addToEventQue(this._stopEventLoop)
            return this;
        };
    
        TypewriterPrototype.start = function() {
            this._startEventLoop();
            return this;
        };
    
        TypewriterPrototype.rerun = function() {
            this._addToEventQue(this._rerunCalledEvents);
            return this;
        };
    
        TypewriterPrototype.typeString = function(string) {
            if(!string || typeof string != 'string') {
                return console.error('Please enter a string as the paramater.');
            }
    
            var string_chars = this._getCharacters(string);
    
            this._addToEventQue([this._typeCharacters, [string_chars]]);
            return this;
        };
    
        TypewriterPrototype.deleteAll = function() {
            this._addToEventQue([this._deleteChars, ['all']]);
            return this;
        };
    
        TypewriterPrototype.deleteChars = function(amount) {
            this._addToEventQue([this._deleteChars, [amount]]);
            return this;
        };
    
        TypewriterPrototype.pauseFor = function(ms) {
            this._addToEventQue([this._pauseFor, [ms]]);
            return this;
        };
    
        TypewriterPrototype.typeOutAllStrings = function() {		
            var characters_array = this._getStringsAsCharsArray();
    
            if(characters_array.length === 1) {
                this._typeCharacters(characters_array[0]);
            } else {
                for(var i = 0, length = characters_array.length; i < length; i++) {
                    this._addToEventQue([this._typeCharacters, [characters_array[i]]]);
                    this.pauseFor(this._randomInteger(1500, 2500));
                    this.deleteAll();
                    this.pauseFor(this._randomInteger(1500, 2500));
                }
            }
    
            return this;
    
        };
    
        TypewriterPrototype.changeSettings = function(new_settings) {
            if(!new_settings && typeof new_settings !== 'object') {
                return console.error('Typewriter will only accept an object as the settings.');
            }
    
            this._addToEventQue([this._changeSettings, [JSON.stringify(new_settings)]]);
    
            return this;
    
        };
    
        TypewriterPrototype.changeBlinkSpeed = function(new_speed) {
            if(!new_speed && typeof new_speed !== 'number') {
                return console.error('Please enter a number for the new blink speed.');
            }
    
            this.changeSettings({
                blinkSpeed: new_speed
            });
    
            return this;
        };
    
        TypewriterPrototype.changeTypingSpeed = function(new_speed) {
            if(!new_speed && typeof new_speed !== 'number') {
                return console.error('Please enter a number for the new typing speed.');
            }
    
            var new_settings = {
                typingSpeed: new_speed
            };
    
            this.changeSettings({
                typingSpeed: new_speed
            });
    
            return this;
        };
    
        TypewriterPrototype.changeDeleteSpeed = function(new_speed) {
            if(!new_speed && typeof new_speed !== 'number') {
                return console.error('Please enter a number for the new delete speed.');
            }
    
            this.changeSettings({
                changeDeleteSpeed: new_speed
            });
    
            return this;
        };
    
        TypewriterPrototype._rerunCalledEvents = function() {
            if(this._settings.currentTypedCharacters.length > 0) {
                this.deleteAll();
                this._resetEventLoop('rerunCalledEvents');
            } else {
                this._settings.eventQue = this._settings.calledEvents;
                this._settings.calledEvents = [];
                this.options = this._setupOptions(this._settings.userOptions);
                this._settings.usedIDs = [];
                this.charAmountToDelete = false;
                this._startEventLoop();
            }
        };
    
        TypewriterPrototype._deleteChars = function(amount) {
    
    
            if(amount) {
                this._settings.charAmountToDelete = amount;
            }
            this._deletingCharIdsAnimation = window.requestAnimationFrame(this._deletingCharAnimationFrame.bind(this));
            return this;
        };
    
        TypewriterPrototype._pauseFor = function(ms) {
            var self = this;
            self._settings.eventRunning = true;
            setTimeout(function() {
                self._resetEventLoop('pauseFor');
            }, ms);
        };
    
        TypewriterPrototype._changeSettings = function(new_settings) {
            this.options = this._setupOptions(JSON.parse(new_settings[0]));
            this._resetEventLoop('changeSettings');
    
            if(this.options.devMode) {
                console.log('New settings', this.options);
            }
    
        };
    
        TypewriterPrototype._deletingCharAnimationFrame = function() {
            var self = this;
            var delete_speed = this.options.deleteSpeed;
            var typewriter_wrapper_class_name = self.options.wrapperClassName;
            var current_typed_char_ids = self._settings.currentTypedCharacters;
            var char_amount_to_delete = self._settings.charAmountToDelete;
    
            if(!self._settings.charAmountToDelete || self._settings.charAmountToDelete === 0 || current_typed_char_ids === 0) {
                self._resetEventLoop('deletingCharAnimationFrame');
                return true;
            }
    
            if(delete_speed == 'natural') {
                delete_speed = self._randomInteger(50, 150);
            }
    
            if(char_amount_to_delete == 'all') {
                char_amount_to_delete = current_typed_char_ids.length;
                self._settings.charAmountToDelete = char_amount_to_delete;
            } 
    
            setTimeout(function() {
                if(self._settings.charAmountToDelete) {
                    var last_typed_char_index = current_typed_char_ids.length - 1;
                    var get_last_typed_char = current_typed_char_ids[last_typed_char_index];
    
                    self._settings.currentTypedCharacters.splice(last_typed_char_index, 1);
    
                    var char_to_delete_el = document.getElementById(get_last_typed_char);
    
                    if(char_to_delete_el) {
                        var typewriter_wrapper_el = self.el.querySelector('.' + typewriter_wrapper_class_name);
                        typewriter_wrapper_el.removeChild(char_to_delete_el);
                        self._settings.charAmountToDelete = char_amount_to_delete - 1;
    
                        if(self.options.devMode) {
                            console.log('Deleted char with ID', get_last_typed_char);
                        }
                    }
    
                }
    
                self._deletingCharIdsAnimation = window.requestAnimationFrame(self._deletingCharAnimationFrame.bind(self));
    
            }, delete_speed);
        };
    
        TypewriterPrototype._setupOptions = function(new_options) {
            var merged_options = {};
    
            for (var attrname in this.default_options) {
                merged_options[attrname] = this.default_options[attrname];
            }
    
            if(this._settings.userOptions) {
                for (var attrname in this._settings.userOptions) {
                    merged_options[attrname] = this._settings.userOptions[attrname];
                }
            }
    
            for (var attrname in new_options) {
                merged_options[attrname] = new_options[attrname];
            }
    
            return merged_options;
        }
    
        TypewriterPrototype._addToEventQue = function(event) {
            this._settings.eventQue.push(event);
            if(this._settings.eventQue.length > 0 && !this._settings.eventRunning && this.options.autoStart) {
                this._startEventLoop();
            }
        };
    
        TypewriterPrototype._startEventLoop = function() {
            if(this.options.devMode) {
                console.log('Event loop started.');
            }
    
            if(!this._settings.eventRunning) {
    
                if(this._settings.eventQue.length > 0) {
                    this.eventLoopRerun = 0;
                    var first_event = this._settings.eventQue[0];
                    if(typeof first_event == 'function') {
                        this._settings.eventRunning = true;
                        this._settings.calledEvents.push(first_event);
                        this._settings.eventQue.splice(0, 1);
                        first_event.call(this);
                        if(this.options.devMode) {
                            console.log('Event started.');
                        }
                    } else if(first_event instanceof Array) {
                        if(typeof first_event[0] == 'function' && first_event[1] instanceof Array) {
                            this._settings.eventRunning = true;
                            this._settings.calledEvents.push(first_event);
                            this._settings.eventQue.splice(0, 1);
                            first_event[0].call(this, first_event[1]);
                            if(this.options.devMode) {
                                console.log('Event started.');
                            }
                        }
                    }
                }
                this._eventQueAnimation = window.requestAnimationFrame(this._startEventLoop.bind(this));
            }
    
            if(!this._settings.eventRunning && this._settings.eventQue.length <= 0) {
                var self = this;
                self._stopEventLoop();
                setTimeout(function() {
                    if(self.options.loop) {
                        self.eventLoopRerun++;
                        if(self.options.devMode) {
                            console.log('Before Loop State', self._settings);
                        }
                        if(self.eventLoopRerun > 4) {
                            console.error('Maximum amount of loop retries reached.');
                            self._stopEventLoop();
                        } else {
                            if(self.options.devMode) {
                                console.log('Looping events.');
                            }
                            self._rerunCalledEvents();
                        }
                    }
                }, 1000);
                return;
            }
    
        };
    
        TypewriterPrototype._resetEventLoop = function(name) {
            var event_name = name || 'Event';
            this._settings.eventRunning = false;
            this._startEventLoop();
            if(this.options.devMode) {
                console.log(event_name, 'Finished');
            }
        };
    
        TypewriterPrototype._stopEventLoop = function() {
            window.cancelAnimationFrame(this._eventQueAnimation);
            if(this.options.devMode) {
                console.log('Event loop stopped.');
            }
        };
    
        TypewriterPrototype._setupTypwriterWrapper = function() {
            var typewriter_wrapper_class_name = this.options.wrapperClassName;
            var typewriter_wrapper = document.createElement('span');
            typewriter_wrapper.className = typewriter_wrapper_class_name;
            this.el.innerHTML = '';
            this.el.appendChild(typewriter_wrapper);
        };
    
        TypewriterPrototype._typeCharacters = function(characters_array) {
            this._settings.stringToTypeHTMLArray = this._convertCharsToHTML(characters_array);
            this._typingAnimation = window.requestAnimationFrame(this._typingAnimationFrame.bind(this, characters_array.length));
            return this;
        };
    
        TypewriterPrototype._typingAnimationFrame = function(total_items) {
            var self = this;
            var typing_speed = this.options.typingSpeed;
            var typewriter_wrapper_class_name = self.options.wrapperClassName;
    
            if(self._settings.stringToTypeHTMLArray.length == 0) {
                window.cancelAnimationFrame(self._typingAnimation);
                this._resetEventLoop('typingAnimationFrame');
                return true;
            }
    
            if(typing_speed == 'natural') {
                typing_speed = this._randomInteger(50, 150);
            }
    
            setTimeout(function() {
                var el_inner_html = self.el.innerHTML;
                var item_to_type = self._settings.stringToTypeHTMLArray[0];
                self.el.querySelector('.' + typewriter_wrapper_class_name).appendChild(item_to_type.el);
                self._settings.currentTypedCharacters.push(item_to_type.id);
                self._settings.stringToTypeHTMLArray.splice(0, 1);
                self._typingAnimation = window.requestAnimationFrame(self._typingAnimationFrame.bind(self, total_items));
                if(self.options.devMode) {
                    console.log('Typed', item_to_type);
                }
            }, typing_speed);
        };
    
        TypewriterPrototype._convertCharsToHTML = function(chars) {
            var chars_html_wrap_array = [];
            var char_class_name = this.options.charSpanClassName;
            var chars_array = chars[0];
    
            for(var i = 0, length = chars_array.length; i < length; i++) {
                var char_element = document.createElement('span');
                var char_id = this._generateUniqueID();
                char_element.id = char_id;
                char_element.className = char_class_name + ' typewriter-item-' + i;
                char_element.innerHTML = chars_array[i];
                chars_html_wrap_array.push({
                    id: char_id,
                    el: char_element
                });
            }
    
            return chars_html_wrap_array;
        };
    
        TypewriterPrototype._getCharacters = function(string) {
            if(typeof string !== 'string') {
                return false;
            }
            return string.split("");
        };
    
        TypewriterPrototype._getStringsAsCharsArray = function() {
            var strings_array_check = this.options.strings instanceof Array;
            var strings_string_check = typeof this.options.strings === 'string';
            if(!strings_array_check) {
                if(!strings_string_check) {
                    return console.error('Typewriter only accepts strings or an array of strings as the input.');
                }
                return [this.options.strings.split("")];
            }
    
            var strings_chars_array = [];
    
            for (var i = 0, length = this.options.strings.length; i < length; i++) {
                var string_chars = this._getCharacters(this.options.strings[i]);
                if(!string_chars) {
                    console.error('Please enter only strings.');
                    break;
                }
                strings_chars_array.push(string_chars);
            }
    
            return strings_chars_array;
        };
    
        TypewriterPrototype._cursorAnimationFrame = function() {
            if(!this._settings.cursorAnimationPaused) {
                var blink_speed = this.options.blinkSpeed;
                var opacity_amount = (1/1000) * blink_speed;
    
                var cursor_el = this.el.querySelector('.typewriter-cursor');
    
                if(this._settings.opacityIncreasing == true) {
                    if(this._settings.currentOpacity >= 1) {
                        this._settings.opacityIncreasing = false;
                        this._settings.currentOpacity = 1;
                    }
    
                    this._settings.currentOpacity += opacity_amount;
                }
    
                if(this._settings.opacityIncreasing == false) {
                    if(this._settings.currentOpacity <= 0) {
                        this._settings.opacityIncreasing = true;
                        this._settings.currentOpacity = 0;
                    }
    
                    this._settings.currentOpacity -= opacity_amount;
                }
    
                cursor_el.style.opacity = this._settings.currentOpacity;
                this._cursorAnimation = window.requestAnimationFrame(this._cursorAnimationFrame.bind(this));
            }
        };
    
        TypewriterPrototype._startCursorAnimation = function() {
            var cursor = this.options.cursor;
            var cursor_class_name = this.options.cursorClassName;
            
            var cursor_element = document.createElement('span');
            cursor_element.className = cursor_class_name;
            cursor_element.innerHTML = cursor;
    
            this.el.appendChild(cursor_element);
            if(this.options.animateCursor) {
                this._cursorAnimation = window.requestAnimationFrame(this._cursorAnimationFrame.bind(this));
            }
        };
    
        TypewriterPrototype._pauseCursorAnimation = function() {
            if(!this._settings.cursorAnimationPaused) {
                window.cancelAnimationFrame(this._cursorAnimation);
                this._settings.cursorAnimationPaused = true;
            }
        };
    
        TypewriterPrototype._restartCursorAnimation = function() {
            if(!this._settings.cursorAnimationPaused) {
                return console.error('Cursor animation is already running.')
            }
    
            this._settings.cursorAnimationPaused = false;
            this._cursorAnimation = window.requestAnimationFrame(this._cursorAnimationFrame.bind(this));
        };
    
        /* Utils */
        TypewriterPrototype._randomInteger = function(min, max) {
            return Math.floor(Math.random() * (max - min + 1)) + min;
        };
    
        TypewriterPrototype._randomID = function() {
            var text = "";
            var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    
            for( var i=0; i < this._randomInteger(5, 15); i++ ) {
                text += possible.charAt(Math.floor(Math.random() * possible.length));
            }
            return text;
        };
    
        TypewriterPrototype._generateUniqueID = function() {
            var temp_id = this._randomID();
            if(this._settings.usedIDs.indexOf(temp_id) == -1) {
                this._settings.usedIDs.push(temp_id);
                return temp_id;
            }
            return this._generateUniqueID.call(this); 
        };
    
    
    })();