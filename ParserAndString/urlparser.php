<?php
/*
 * Parse FTP address 
 * http://www.php.net/manual/es/function.parse-url.php
 * 
 */
 
 
 // Parse an URL
 
 $url = 'http://username:password@hostname/path?arg=value#anchor';
 $url_data =  parse_url($url, PHP_URL_PATH);
 
 echo $url_data;
 
 // Parse a string, style "ARG1=LOLOLOLOLOLO,ARG2=LALALALALALA"
 
 $stringtoparse = 'ARG1:LOLOLOLOLOLO,ARG2:LALALALALALA';
 $stringparsed = parse_str($Stringtoparse);
 
 echo $stringparsed;
 

?>
