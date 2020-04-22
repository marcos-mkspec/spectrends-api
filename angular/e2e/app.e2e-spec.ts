import { SpectrendsTemplatePage } from './app.po';

describe('Spectrends App', function() {
  let page: SpectrendsTemplatePage;

  beforeEach(() => {
    page = new SpectrendsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
