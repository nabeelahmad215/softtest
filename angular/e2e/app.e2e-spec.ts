import { softtestTemplatePage } from './app.po';

describe('softtest App', function() {
  let page: softtestTemplatePage;

  beforeEach(() => {
    page = new softtestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
