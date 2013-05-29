<?cs # The default search box that goes in the header ?><?cs 
def:default_search_box() ?>
<form accept-charset="utf-8" class="navbar-search" 
      onsubmit="return submit_search()">
  <input id="search_autocomplete" class="search-query" type="text" size="33" autocomplete="off"
    placeholder="Search"
    title="search developer docs" name="q"
    value="search developer docs"
    onFocus="search_focus_changed(this, true)"
    onBlur="search_focus_changed(this, false)"
    onkeydown="return search_changed(event, true, '<?cs var:toroot?>')"
    onkeyup="return search_changed(event, false, '<?cs var:toroot?>')" />
  <div id="search_filtered_div" class="no-display">
    <table id="search_filtered" cellspacing=0>
    </table>
  </div>
</form><?cs /def ?>