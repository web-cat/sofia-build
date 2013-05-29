<!DOCTYPE HTML>
<?cs include:"macros.cs" ?>
<html lang="en">
<?cs include:"head_tag.cs" ?>
<body>
<?cs call:custom_masthead() ?>

  <div id="page">
    <div id="nav-and-content">
      <?cs call:custom_left_nav() ?>

    <div id="page-content">

      <h1 class="page-header"><?cs var:page.title ?></h1>

      <div class="navbar">
        <div class="navbar-inner">
          <ul class="nav">
            <?cs each:letter=docs.classes ?>
              <li><a href="#letter_<?cs name:letter ?>"><?cs name:letter ?></a></li>
            <?cs /each?>
          </ul>
        </div>
      </div>

      <?cs each:letter=docs.classes ?>
      <h2 id="letter_<?cs name:letter ?>"><?cs name:letter ?></h2>
      <table class="table table-condensed table-striped table-bordered">
        <tbody>
          <?cs each:cl = letter ?>
            <tr class="api apilevel-<?cs var:cl.since.key ?>">
              <td class="jd-linkcol"><?cs call:type_link(cl.type) ?></td>
              <td class="jd-descrcol"><?cs call:short_descr(cl) ?>&nbsp;</td>
            </tr>
          <?cs /each ?>
        </tbody>
      </table>
      <?cs /each ?>

      </div>
    </div>
  </div>

</body>
</html>